using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Atlantik
{
    public partial class FormModifierBateau : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader jeuEnr = null;

        public FormModifierBateau()
        {
            InitializeComponent();
        }

        private void FormModifierBateau_Load(object sender, EventArgs e)
        {
            try
            {
                string requete;
                maCnx.Open(); // on se connecte

                // DEBUT requête paramétrée
                requete = "Select * from BATEAU";
                var maCde = new MySqlCommand(requete, maCnx);

                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    //cmbNomSecteur.Items.Add(new Secteur((int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]));
                    cmbNomBateauModif.Items.Add(new Bateau(jeuEnr.GetInt32("nobateau"), jeuEnr.GetString("nom")));
                }
                jeuEnr.Close();

                // DEBUT requête paramétrée
                requete = "Select * from CATEGORIE";
                maCde = new MySqlCommand(requete, maCnx);

                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                int i = 0;
                Label lbl;
                TextBox tbx;

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    i += 1;
                    lbl = new Label();
                    lbl.Text = jeuEnr["lettrecategorie"].ToString() + " (" + jeuEnr["libelle"].ToString() + ") :";
                    lbl.Location = new Point(10, 50 * i);
                    gbxModifierBateau.Controls.Add(lbl);

                    tbx = new TextBox();
                    tbx.Location = new Point(107, 50 * i);
                    tbx.Tag = jeuEnr["lettrecategorie"].ToString();
                    gbxModifierBateau.Controls.Add(tbx);

                    //cmbNomSecteur.Items.Add(new Secteur((int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]));

                }
                jeuEnr.Close();
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur " + erreur.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
        }

        private void btnModifierBateau_Click(object sender, EventArgs e)
        {
            foreach (Control element in gbxModifierBateau.Controls)
            {
                if (element is TextBox)
                {
                    string texteTag = element.Tag.ToString();
                    //tarif = recupTarif.


                    try
                    {
                        string requete;
                        maCnx.Open();

                        requete = "Update CONTENIR set capacitemax = @CAPAMAX where nobateau = @NOBATEAU and lettrecategorie = @LETTRE";
                        var maCde = new MySqlCommand(requete, maCnx);
                        maCde.Parameters.AddWithValue("@LETTRE", texteTag);
                        maCde.Parameters.AddWithValue("@NOBATEAU", ((Bateau)(cmbNomBateauModif.SelectedItem)).GetNoBateau());
                        maCde.Parameters.AddWithValue("@CAPAMAX", int.Parse(element.Text));
                        //POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci - dessus
                        // FIN requête paramétrée

                        int nbLigneAffectees;
                        nbLigneAffectees = maCde.ExecuteNonQuery();
                        MessageBox.Show("Nombre de ligne mise(s) à jour :" + nbLigneAffectees.ToString());
                    }
                    catch (MySqlException ex)

                    {
                        Console.WriteLine("Erreur " + ex.ToString());
                    }
                    finally

                    {


                        if (maCnx is object & maCnx.State == ConnectionState.Open)

                        {

                            maCnx.Close(); // on se déconnecte

                        }

                    }
                }
            }
        }
    }
}


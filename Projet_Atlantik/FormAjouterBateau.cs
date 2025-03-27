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
    public partial class FormAjouterBateau : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader jeuEnr = null;
        public FormAjouterBateau()
        {
            InitializeComponent();
        }

        private void FormAjouterBateau_Load(object sender, EventArgs e)
        {
            try
            {
                string requete;
                maCnx.Open(); // on se connecte

                // DEBUT requête paramétrée
                requete = "Select * from CATEGORIE";
                var maCde = new MySqlCommand(requete, maCnx);

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
                    gbxAjouterBateau.Controls.Add(lbl);

                    tbx = new TextBox();
                    tbx.Location = new Point(107, 50 * i);
                    tbx.Tag = jeuEnr["lettrecategorie"].ToString();
                    gbxAjouterBateau.Controls.Add(tbx);

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
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close(); // s'il existe et n'est pas déjà fermé
                }

                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
        }

        private void btnAjouterBateau_Click(object sender, EventArgs e)
        {
            long noBateauGenere = 0;
            try
            {
                string requete;
                maCnx.Open();

                //requete = "Insert into BATEAU(nom) values (@NOMBATEAU);SELECT LAST_INSERT_ID();";
                requete = "Insert into BATEAU(nom) values (@NOMBATEAU)";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@NOMBATEAU", tbxNomBateau.Text);
                //POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci - dessus
                // FIN requête paramétrée


                //noBateauGenere = Convert.ToInt32((maCde.ExecuteScalar()));
                maCde.ExecuteNonQuery();
                noBateauGenere = maCde.LastInsertedId;
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
           



            foreach (Control element in gbxAjouterBateau.Controls)
            {
                if (element is TextBox)
                {
                    string texteTag = element.Tag.ToString();
                    //tarif = recupTarif.

               
                try
                {
                    string requete;
                    maCnx.Open();

                    requete = "Insert into CONTENIR(lettrecategorie, nobateau, capacitemax) values (@LETTRE, @NOBATEAU, @CAPAMAX)";
                    var maCde = new MySqlCommand(requete, maCnx);
                    maCde.Parameters.AddWithValue("@LETTRE", texteTag);
                    maCde.Parameters.AddWithValue("@NOBATEAU", noBateauGenere);
                    maCde.Parameters.AddWithValue("@CAPAMAX", int.Parse(element.Text));
                    //POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci - dessus
                    // FIN requête paramétrée

                    int nbLigneAffectees;
                    nbLigneAffectees = maCde.ExecuteNonQuery();
                    MessageBox.Show("Nombre de ligne affectée(s) :" + nbLigneAffectees.ToString());
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
    
    


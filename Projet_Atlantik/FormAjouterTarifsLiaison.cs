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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Projet_Atlantik
{
    public partial class FormAjouterTarifsLiaison : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader jeuEnr = null;
        
        public FormAjouterTarifsLiaison()
        {
            InitializeComponent();
        }

        private void FormAjouterTarifsLiaison_Load(object sender, EventArgs e)
        {
            try
            {
                string requete;
                maCnx.Open(); // on se connecte

                // DEBUT requête paramétrée
                requete = "Select * from TYPE";
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
                    lbl.Text = jeuEnr["lettrecategorie"].ToString() + jeuEnr["notype"].ToString() + " - " + jeuEnr["libelle"].ToString() + " :";
                    lbl.Location = new Point(10, 25 * i);
                    gbxTarifsCategorieType.Controls.Add(lbl);

                    tbx = new TextBox();
                    tbx.Location = new Point(107, 25 * i);
                    tbx.Tag = jeuEnr["lettrecategorie"].ToString() + ";" + jeuEnr["notype"].ToString();
                    gbxTarifsCategorieType.Controls.Add(tbx);
                    
                    //cmbNomSecteur.Items.Add(new Secteur((int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]));

                }
                jeuEnr.Close();

                requete = "Select * from SECTEUR";
                 maCde = new MySqlCommand(requete, maCnx);

                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    //cmbNomSecteur.Items.Add(new Secteur((int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]));
                    lbxSecteursAjouterTarifs.Items.Add(new Secteur(jeuEnr.GetInt32("nosecteur"), jeuEnr.GetString("nom")));
                }
                jeuEnr.Close();
               

                

                requete = "Select * from PERIODE";
                maCde = new MySqlCommand(requete, maCnx);

                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    //cmbNomSecteur.Items.Add(new Secteur((int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]));
                    cmbPeriode.Items.Add(new Periode(jeuEnr.GetInt32("noperiode"), jeuEnr.GetDateTime("datedebut"), jeuEnr.GetDateTime("datefin")));
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

        private void lbxSecteursAjouterTarifs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string requete;
                maCnx.Open();
               // lbxSecteursAjouterTarifs.SelectedIndex = 0;
                requete = "SELECT liaison.NOLIAISON noliaison, liaison.NOPORT_DEPART portdepart, liaison.NOPORT_ARRIVEE portarrivee, d.NOM depart, a.NOM arrivee FROM liaison INNER JOIN secteur ON liaison.NOSECTEUR = secteur.NOSECTEUR INNER JOIN port d ON liaison.NOPORT_DEPART = d.NOPORT INNER JOIN port a ON liaison.NOPORT_ARRIVEE = a.NOPORT WHERE secteur.NOSECTEUR = @NOSECTEUR";
                var maCde = new MySqlCommand(requete, maCnx);
                int numero = ((Secteur)(lbxSecteursAjouterTarifs.SelectedItem)).GetNoSecteur();
                maCde.Parameters.AddWithValue("@NOSECTEUR", numero);

                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    //cmbNomSecteur.Items.Add(new Secteur((int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]));
                    cmbLiaisonAjouterTarifs.Items.Add(new Liaison(jeuEnr.GetInt32("noliaison"), jeuEnr.GetString("depart"), jeuEnr.GetString("arrivee")));
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
                    maCnx.Close();
                }
            }
        }

        private void btnAjouterTarifs_Click(object sender, EventArgs e)
        {
            string numeroTag="";
            string lettreTag="";
            int numeroType=0;
            double tarif=0;
            foreach (Control element in gbxTarifsCategorieType.Controls)
            {
                if (element is TextBox)
                {
                    string[] texteTag = element.Tag.ToString().Split(';');
                    lettreTag = texteTag[0];
                    numeroTag = texteTag[1];
                    numeroType = int.Parse(numeroTag);
                    tarif = double.Parse(element.Text);
                    //tarif = recupTarif.
                    
                }
                try
                {
                    string requete;
                    maCnx.Open();

                    requete = "Insert into TARIFER(noperiode, lettrecategorie, notype, noliaison, tarif) values (@NOPERIODE, @LETTRE, @NOTYPE, @NOLIAISON, @TARIF)";
                    var maCde = new MySqlCommand(requete, maCnx);
                    maCde.Parameters.AddWithValue("@NOPERIODE", ((Periode)(cmbPeriode.SelectedItem)).GetNoPeriode());
                    maCde.Parameters.AddWithValue("@LETTRE", lettreTag);
                    maCde.Parameters.AddWithValue("@NOTYPE", numeroType);
                    maCde.Parameters.AddWithValue("@NOLIAISON", ((Liaison)cmbLiaisonAjouterTarifs.SelectedItem).GetNoLiaison());
                    maCde.Parameters.AddWithValue("@TARIF", tarif);
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

                    //if (jeuEnr is object & !jeuEnr.IsClosed)

                    //{

                    //    jeuEnr.Close(); // s'il existe et n'est pas déjà fermé

                    //}



                    if (maCnx is object & maCnx.State == ConnectionState.Open)

                    {

                        maCnx.Close(); // on se déconnecte

                    }

                }
            }
        }
    }
}

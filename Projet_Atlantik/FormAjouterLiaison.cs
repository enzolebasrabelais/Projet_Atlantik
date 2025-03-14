using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class FormAjouterLiaison : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader jeuEnr = null;
        public FormAjouterLiaison()
        {
            InitializeComponent();
        }

        private void FormAjouterLiaison_Load(object sender, EventArgs e)
        {
            try
            {
                string requete;
                maCnx.Open(); // on se connecte

                // DEBUT requête paramétrée
                requete = "Select * from SECTEUR";
                var maCde = new MySqlCommand(requete, maCnx);
                
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    //cmbNomSecteur.Items.Add(new Secteur((int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]));
                    lbxNomSecteur.Items.Add(new Secteur(jeuEnr.GetInt32("nosecteur"), jeuEnr.GetString("nom")));
                }
                jeuEnr.Close();

                requete = "Select * from PORT";
                maCde = new MySqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbDepart.Items.Add(new Port(jeuEnr.GetInt32("noport"), jeuEnr.GetString("nom")));
                    cmbArrivee.Items.Add(new Port(jeuEnr.GetInt32("noport"), jeuEnr.GetString("nom")));
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

            //try
            //{
            //    string requete1;
            //    maCnx.Open(); // on se connecte

            //    // DEBUT requête paramétrée
            //    requete1 = "Select * from PORT";
            //    var maCde1 = new MySqlCommand(requete1, maCnx);
            //    // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
            //    // FIN requête paramétrée

            //    jeuEnr1 = maCde1.ExecuteReader();
            //    while (jeuEnr1.Read())
            //    {
            //        cmbDepart.Items.Add(new Port(jeuEnr.GetInt32("noport"), jeuEnr.GetString("nom")));
            //        cmbArrivee.Items.Add(new Port(jeuEnr.GetInt32("noport"), jeuEnr.GetString("nom")));
            //    }
            //}
            //catch (MySqlException erreur)
            //{
            //    MessageBox.Show("Erreur " + erreur.ToString());
            //}
            //finally
            //{
            //    if (maCnx is object & maCnx.State == ConnectionState.Open)
            //    {
            //        maCnx.Close(); // on se déconnecte
            //    }
            //}
        }

        private void btnAjouterLiaison_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Id du client sélectionné:" + ((Secteur)(lbxNomSecteur.SelectedItem)).GetNoSecteur().ToString());
            try
            {
                string requete;
                maCnx.Open(); // on se connecte

                // DEBUT requête paramétrée
                requete = "Insert into LIAISON(noport_depart, nosecteur, noport_arrivee, distance) values (@NOPORT_DEPART, @NOSECTEUR, @NOPORT_ARRIVEE, @DISTANCE)";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@NOPORT_DEPART", ((Port)(cmbDepart.SelectedItem)).GetNoPort());
                maCde.Parameters.AddWithValue("@NOSECTEUR", ((Secteur)(lbxNomSecteur.SelectedItem)).GetNoSecteur());
                maCde.Parameters.AddWithValue("@NOPORT_ARRIVEE", ((Port)(cmbArrivee.SelectedItem)).GetNoPort());
                maCde.Parameters.AddWithValue("@DISTANCE", tbxDistance.Text);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée

                int nbLigneAffectees;
                nbLigneAffectees = maCde.ExecuteNonQuery();
                MessageBox.Show("Nombre de ligne affectée(s) :" + nbLigneAffectees.ToString());

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
    }
}

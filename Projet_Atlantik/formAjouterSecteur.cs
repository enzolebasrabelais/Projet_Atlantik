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
    public partial class formAjouterSecteur : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        public formAjouterSecteur()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                string requete;
                maCnx.Open(); // on se connecte

                // DEBUT requête paramétrée
                requete = "Insert into SECTEUR(NOM) values (@NOM)";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@NOM", tbxNomSecteur.Text);
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

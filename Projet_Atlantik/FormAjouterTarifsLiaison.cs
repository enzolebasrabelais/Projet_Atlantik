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
                    gbxTarifsCategorieType.Controls.Add(tbx);
                    gbxTarifsCategorieType.Tag = jeuEnr["lettrecategorie"].ToString() + jeuEnr["notype"].ToString();
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
    }
}

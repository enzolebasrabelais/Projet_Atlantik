using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class FormAjouterTraversee : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader jeuEnr = null;

        public FormAjouterTraversee()
        {
            InitializeComponent();
        }

        private void FormAjouterTraversee_Load(object sender, EventArgs e)
        {
            try
            {
                string requete;
                maCnx.Open();


                requete = "Select * from SECTEUR";
                var maCde = new MySqlCommand(requete, maCnx);

                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    //cmbNomSecteur.Items.Add(new Secteur((int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]));
                    lbxSecteursTraversee.Items.Add(new Secteur(jeuEnr.GetInt32("nosecteur"), jeuEnr.GetString("nom")));
                }
                jeuEnr.Close();

                requete = "Select * from BATEAU";
                maCde = new MySqlCommand(requete, maCnx);

                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    //cmbNomSecteur.Items.Add(new Secteur((int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]));
                    cmbBateauTraversee.Items.Add(new Bateau(jeuEnr.GetInt32("nobateau"), jeuEnr.GetString("nom")));
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

        private void lbxSecteursTraversee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string requete;
                maCnx.Open();
                // lbxSecteursAjouterTarifs.SelectedIndex = 0;
                requete = "SELECT liaison.NOLIAISON noliaison, liaison.NOPORT_DEPART portdepart, liaison.NOPORT_ARRIVEE portarrivee, d.NOM depart, a.NOM arrivee FROM liaison INNER JOIN secteur ON liaison.NOSECTEUR = secteur.NOSECTEUR INNER JOIN port d ON liaison.NOPORT_DEPART = d.NOPORT INNER JOIN port a ON liaison.NOPORT_ARRIVEE = a.NOPORT WHERE secteur.NOSECTEUR = @NOSECTEUR";
                var maCde = new MySqlCommand(requete, maCnx);
                int numero = ((Secteur)(lbxSecteursTraversee.SelectedItem)).GetNoSecteur();
                maCde.Parameters.AddWithValue("@NOSECTEUR", numero);

                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    //cmbNomSecteur.Items.Add(new Secteur((int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]));
                    cmbLiaisonsTraversee.Items.Add(new Liaison(jeuEnr.GetInt32("noliaison"), jeuEnr.GetString("depart"), jeuEnr.GetString("arrivee")));
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

        private void btnAjouterTraversee_Click(object sender, EventArgs e)
        {
            try
            {
                string requete;
                maCnx.Open(); // on se connecte

                // DEBUT requête paramétrée
                requete = "Insert into TRAVERSEE(noliaison, nobateau, dateheuredepart, dateheurearrivee, clotureembarquement) values (@NOLIAISON, @NOBATEAU, @DATEDEPART, @DATEARRIVEE, @CLOTURE)";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@NOLIAISON", ((Liaison)(cmbLiaisonsTraversee.SelectedItem)).GetNoLiaison());
                maCde.Parameters.AddWithValue("@NOBATEAU", ((Bateau)(cmbBateauTraversee.SelectedItem)).GetNoBateau());
                maCde.Parameters.AddWithValue("@DATEDEPART", dtpDepart.Value);
                maCde.Parameters.AddWithValue("@DATEARRIVEE", dtpArrivee.Value);
                maCde.Parameters.AddWithValue("@CLOTURE", 0);
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



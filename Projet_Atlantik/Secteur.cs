using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Atlantik
{
    public class Secteur
    {
        private int NoSecteur;
        private string Nom;

        public Secteur(int NoSecteur, string Nom)
        {
            this.NoSecteur = NoSecteur;
            this.Nom = Nom;
        }

        public int GetNoSecteur()
        {
            return NoSecteur;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}

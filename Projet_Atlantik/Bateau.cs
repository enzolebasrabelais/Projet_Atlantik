using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Atlantik
{
    class Bateau
    {
        private int noBateau;
        private string nom;

        public Bateau(int noBateau, string nom)
        {
            this.noBateau = noBateau;
            this.nom = nom;
        }

        public int GetNoBateau()
        {
            return noBateau;
        }

        public override string ToString()
        {
            return nom;
        }
    }
}

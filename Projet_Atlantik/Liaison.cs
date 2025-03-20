using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Atlantik
{
    class Liaison
    {
        private int NoLiaison;
        private string NomDepart, NomArrivee;

        public Liaison(int NoLiaison, string NomDepart, string NomArrivee)
        {
            this.NoLiaison = NoLiaison;
            this.NomDepart = NomDepart;
            this.NomArrivee = NomArrivee;
        }

        public int GetNoLiaison()
        {
            return NoLiaison;
        }


        public override string ToString()
        {
            return NomDepart + " - " + NomArrivee;
        }
    }
}

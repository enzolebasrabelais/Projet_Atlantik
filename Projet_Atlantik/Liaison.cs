using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Atlantik
{
    class Liaison
    {
        private int NoLiaison, NoPortDepart, NoPortArrivee;
        private string NomDepart, NomArrivee;

        public Liaison(int NoLiaison, int NoPortDepart, int NoPortArrivee, string NomDepart, string NomArrivee)
        {
            this.NoLiaison = NoLiaison;
            this.NoPortDepart = NoPortDepart;
            this.NoPortArrivee = NoPortArrivee;
            this.NomDepart = NomDepart;
            this.NomArrivee = NomArrivee;
        }


        public override string ToString()
        {
            return NomDepart + " - " + NomArrivee;
        }
    }
}

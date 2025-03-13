using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Atlantik
{
    public class Port
    {
        private int NoPort;
        private string Nom;

        public Port(int NoPort, string Nom)
        {
            this.NoPort = NoPort;
            this.Nom = Nom;
        }

        public int GetNoPort()
        {
            return NoPort;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}

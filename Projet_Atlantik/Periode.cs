using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Atlantik
{
    class Periode
    {
        private int NoPeriode;
        private DateTime DateDebut, DateFin;

        public Periode(int NoPeriode, DateTime DateDebut, DateTime DateFin)
        {
            this.NoPeriode = NoPeriode;
            this.DateDebut = DateDebut;
            this.DateFin = DateFin;
        }

        public int GetNoPeriode()
        {
            return NoPeriode;
        }

        public override string ToString()
        {
            return DateDebut.ToString("dd'/'MM'/'yyyy") + " ou " + DateFin.ToString("dd'/'MM'/'yyyy");
        }
    }
}

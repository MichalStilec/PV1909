using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV1909
{
    internal class PlatebniKarta
    {
        private Ucet u;
        private int limit;
        private int cislo;

        public PlatebniKarta(Ucet u, int limit, int cislo)
        {
            this.u = u;
            Limit = limit;
            Cislo = cislo;
        }

        public int Limit { get => limit; set => limit = value; }
        public int Cislo { get => cislo; set => cislo = value; }

        public void Platba(double vklad)
        {
            u.Vyber(vklad);
        }
    }
}

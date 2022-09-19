using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV1909
{
    internal class Ucet
    {
        private double stav;

        public Ucet(double stav)
        {
            Stav = stav;
        }

        protected double Stav { get => stav; set => stav = value; }

        public virtual void Vloz(double vklad)
        {
            if(vklad < 0)
            {
                stav += vklad;
            }
        }
        public virtual void Vyber(double vklad)
        {
            if (vklad < 0)
            {
              stav -= vklad;
            }
        }
    }
}

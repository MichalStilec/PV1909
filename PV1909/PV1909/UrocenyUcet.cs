using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV1909
{
    internal class UrocenyUcet : Ucet
    {
        protected double urok;
        public UrocenyUcet(int stav) : base(stav)
        {
        }

        public virtual void PripsaniStanovenehoUroku()
        {
            this.Stav *= urok;
        } 
    }
}

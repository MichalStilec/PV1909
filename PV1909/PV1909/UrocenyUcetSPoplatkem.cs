using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV1909
{
    internal class UrocenyUcetSPoplatkem : UrocenyUcet
    {
        private int poplatek;
        public UrocenyUcetSPoplatkem(int stav, int poplatek) : base(stav)
        {
            this.poplatek = poplatek;
        }

        public int Poplatek { get => poplatek; set => poplatek = value; }

        public override void PripsaniStanovenehoUroku()
        {
            base.PripsaniStanovenehoUroku();
            Stav -= poplatek;
        }
    }
}

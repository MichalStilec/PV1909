using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV1909
{
    internal class Clovek
    {
        protected int vek;



        public virtual bool Odpoved()
        {
            Random r = new Random();
            int rng = r.Next(0, 2);
            bool odpoved = true;

            if(rng == 0)
            {
                odpoved = false;
            }
            if (rng == 1)
            {
                odpoved = true;
            }

            return odpoved;

        }
    }
}

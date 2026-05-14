using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    class coin
    {
        private string sideUp;
        private static readonly Random Random = new Random();
        public coin()
        {
            sideUp = "Heads";
        }

        public void toss()
        {
            Random rand = new Random();
            int face = rand.Next(2);

            if (face == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }

        public string getSideUp()
        {
            return sideUp;
        }
    }
}
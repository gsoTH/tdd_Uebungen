using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    public class Reifen
    {
        private int zoll;

        public Reifen(int zoll)
        {
            if (zoll < 12 || zoll > 29)
            {
                throw new ArgumentOutOfRangeException("Reifengröße ist außerhalb des gültigen Bereichs.");
            } else {
                this.zoll = zoll;
            }
        }

        public int Zoll 
        { 
            get
                {
                return zoll;
                }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    public class Fahrrad
    {
        private string farbe;
        private int gaenge;
        private Reifen[] reifen = new Reifen[2];
        private int sitze;

        public Fahrrad(string farbe, int gaenge, int reifengroesseInZoll)
        {
            this.farbe = farbe;
            this.gaenge = gaenge;
            reifen[0] = new Reifen(reifengroesseInZoll);
            reifen[1] = new Reifen(reifengroesseInZoll);
            this.sitze = 1;
        }

        public Fahrrad(string farbe, int gaenge, int reifengroesseInZoll, int sitze) : this(farbe, gaenge, reifengroesseInZoll)
        {
            this.sitze = sitze;
        }

        public Fahrrad(string farbe, int gaenge, Reifen[] reifen) : this(farbe, gaenge, 12)
        {
            this.reifen = reifen;
        }

        public string Farbe
        {
            get { return farbe; }
            
            set
            {
                farbe = value;
            }
        }
        public int Gaenge
        {
            get { return gaenge; }
        }

        public int ReifengroesseInZoll
        {
            get 
            {
                int maxReifengroesse = 0;

                for (int i = 0; i < reifen.Length; i++)
                {
                    if (reifen[i].Zoll > maxReifengroesse)
                    {
                        maxReifengroesse = reifen[i].Zoll;
                    }
                }

                return maxReifengroesse;
            }
        }
        public int Sitze
        {
            get { return sitze;}
        }
    }
}

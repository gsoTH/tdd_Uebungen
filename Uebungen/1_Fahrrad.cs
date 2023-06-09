﻿using System;
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
        private int reifengroesseInZoll;
        private int sitze;

        public Fahrrad(string farbe, int gaenge, int reifengroesseInZoll)
        {
            this.farbe = farbe;
            this.gaenge = gaenge;
            this.reifengroesseInZoll = reifengroesseInZoll;
            this.sitze = 1;
        }

        public Fahrrad(string farbe, int gaenge, int reifengroesseInZoll, int sitze) : this(farbe, gaenge, reifengroesseInZoll)
        {
            this.sitze = sitze;
        }

        public Fahrrad(string farbe, int gaenge, Reifen[] reifen) : this(farbe, gaenge, 12)
        {
            int maxReifengroesse = 0;
            for (int i = 0; i < reifen.Length; i++)
            {
                if( reifen[i].Zoll > maxReifengroesse)
                {
                    maxReifengroesse = reifen[i].Zoll;
                }
            }

            this.reifengroesseInZoll = maxReifengroesse;
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
            get { return reifengroesseInZoll; }
        }
        public int Sitze
        {
            get { return sitze;}
        }
    }
}

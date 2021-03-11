using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPGitLabs.Pages.Lab5_Classes
{
    public class Autoradio
    {
        public Autoradio()
        {
        }

        public double NaladenyKmitocet { get; private set; }
        public bool RadioZapnuto { get; set; }

        private Dictionary<int, double> Predvolby = new Dictionary<int, double> {
            { 1, 55.6}
        };

        public void NastavPredvolbu(int cislo, double kmit)
        {
            Predvolby.Add(cislo, kmit);
        }

        public void PreladNaPredvolbu(int cislo)
        {
            NaladenyKmitocet = Predvolby[cislo];
        }

        public override string ToString()
        {
            double[] tmp = Predvolby.Values.ToArray();
            return "Saved freqs: " + string.Join(", ", tmp);
        }


    }
}

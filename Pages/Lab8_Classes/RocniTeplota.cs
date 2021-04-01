using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPGitLabs.Pages.Lab8_Classes
{
    public class RocniTeplota
    {
        public RocniTeplota(int rok, List<double> val)
        {
            Rok = rok;
            MesicniTeploty = val;
        }

        public int Rok;
        public double MaxTeplota => MesicniTeploty.Max();
        public double MinTeplota => MesicniTeploty.Min();
        public double PrumRocniTeplota => MesicniTeploty.Average();

        public List<double> MesicniTeploty;

        public override string ToString()
        {
            return Rok + ": " + String.Join("; ", MesicniTeploty.ToArray());

        }

    }
}

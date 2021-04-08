using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;

namespace OOPGitLabs.Pages.Lab8_Classes
{
    public class ArchivTeplot
    {
        public ArchivTeplot()
        {
        }

        public SortedDictionary<int, RocniTeplota> archiv = new();

        public void Kalibrace(double coef)
        {
            //var coef = args.Value.ToString();
            foreach (KeyValuePair<int, RocniTeplota> tmp in archiv)
            {
                tmp.Value.MesicniTeploty = tmp.Value.MesicniTeploty.Select(s => s + coef).ToList();

            }
        }

        public RocniTeplota Vyhledej(int rok)
        {
            return archiv.GetValueOrDefault(rok);
        }

        public string TiskTeplot()
        {
            string foo = "";
            foreach (KeyValuePair<int, RocniTeplota> tmp in archiv)
            {
                foo += tmp.Value.ToString() + "<br>";
            }
            return foo;
        }

        public string TiskPrumernychRocnichTeplot()
        {
            string foo = "Average yearly temps: <br>";

            foreach (KeyValuePair<int, RocniTeplota> tmp in archiv)
            {
                foo += tmp.Key + ": " + tmp.Value.PrumRocniTeplota + "<br>";
            }
            return foo;
        }

        public string TiskPrumernychMesicnichTeplot()
        {
            string foo = "Average monthly temps: ";
            List<double>[] years = new List<double>[12];
            int ctr = 0;

            foreach (KeyValuePair<int, RocniTeplota> tmp in archiv)
            {
                years[ctr] = tmp.Value.MesicniTeploty;
                ctr++;
            }

            //TODO Monthly avgs sill don't work!!!
            //var averages = Enumerable.Range(0, 11).Select(x => years.Average(y => y[x]));
            //return foo + String.Join(" ", averages.ToArray());
            return foo;
        }
    }
}

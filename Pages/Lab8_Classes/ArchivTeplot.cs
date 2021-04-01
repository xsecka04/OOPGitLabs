using System;
using System.Collections.Generic;
using System.Linq;


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

            foreach (KeyValuePair<int, RocniTeplota> tmp in archiv)
            {
                //tmp.Value.MesicniTeploty.ElementAtOrDefault(1)
            }
            return foo;


        }
    }
}

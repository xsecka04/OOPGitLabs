using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPGitLabs.Pages.Lab7_Classes
{
    public static class Extremy
    {

        public static T Nejvetsi<T>(List<T> compare) where T : IComparable
        {

            return compare.Max();

        }

        public static T Nejmensi<T>(List<T> compare) where T : IComparable
        {

            return compare.Min();

        }

    }
}

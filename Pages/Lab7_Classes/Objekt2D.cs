using System;
namespace OOPGitLabs.Pages.Lab7_Classes
{
    public abstract class Objekt2D : I2D, IComparable
    {
        public Objekt2D()
        {
        }

        public abstract double Plocha();

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is Objekt2D)
                return Plocha().CompareTo(((Objekt2D)obj).Plocha());
            else
                throw new ArgumentException("Object is not a 2D Shape");

        }
    }
}

using System;
namespace OOPGitLabs.Pages.Lab7_Classes
{
    public class Kruh : Objekt2D
    {

        private double radius;

        public Kruh(double rad)
        {
            radius = rad;
        }


        public override String ToString()
        {
            return "Circle with radius " + radius;

        }

        public override double Plocha()
        {
            return Math.PI * radius * radius;
        }
    }
}

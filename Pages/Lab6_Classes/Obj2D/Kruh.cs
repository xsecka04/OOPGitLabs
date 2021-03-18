using System;
namespace OOPGitLabs.Pages.Lab6_Classes
{
    public class Kruh : Objekt2D
    {

        private double radius;

        public Kruh(double rad)
        {
            radius = rad;
        }


        public override String Kresli()
        {
            return "Circle wíth radius " + radius;

        }

        public override double SpoctiPlochu()
        {
            return Math.PI * radius * radius;
        }
    }
}

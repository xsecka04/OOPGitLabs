using System;
namespace OOPGitLabs.Pages.Lab6_Classes
{
    public class Elipsa : Objekt2D
    {

        private double width;
        private double height;

        public Elipsa(double width, double height)
        {
            this.width = width;
            this.height = height;

        }


        public override String Kresli()
        {
            return "Ellipse wíth axes " + width + " and " + height;

        }

        public override double SpoctiPlochu()
        {
            return Math.PI * width * height;
        }
    }
}
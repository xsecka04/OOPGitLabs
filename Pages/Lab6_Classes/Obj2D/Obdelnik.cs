using System;
namespace OOPGitLabs.Pages.Lab6_Classes
{
    public class Obdelnik : Objekt2D
    {

        private double width;
        private double height;


        public Obdelnik(double width, double height)
        {
            this.width = width;
            this.height = height;

        }


        public override String Kresli()
        {
            return "Rectangle wíth sides " + width + " and " + height;

        }

        public override double SpoctiPlochu()
        {
            return width * height;
        }
    }
}
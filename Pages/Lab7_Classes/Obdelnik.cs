using System;
namespace OOPGitLabs.Pages.Lab7_Classes
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


        public override String ToString()
        {
            return "Rectangle with sides " + width + " and " + height;

        }

        public override double Plocha()
        {
            return width * height;
        }
    }
}
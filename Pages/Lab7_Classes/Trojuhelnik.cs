using System;
namespace OOPGitLabs.Pages.Lab7_Classes
{
    public class Trojuhelnik : Objekt2D
    {

        private double width;
        private double height;


        public Trojuhelnik(double width, double height)
        {
            this.width = width;
            this.height = height;

        }


        public override String ToString()
        {
            return "Triangle with base " + width + " and height " + height;

        }

        public override double Plocha()
        {
            return (width * height)/2;
        }
    }
}
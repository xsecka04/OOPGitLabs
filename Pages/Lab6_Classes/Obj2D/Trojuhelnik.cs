using System;
namespace OOPGitLabs.Pages.Lab6_Classes
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


        public override String Kresli()
        {
            return "Triangle wíth base " + width + " and height " + height;

        }

        public override double SpoctiPlochu()
        {
            return (width * height)/2;
        }
    }
}
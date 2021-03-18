using System;
namespace OOPGitLabs.Pages.Lab6_Classes
{
    public class Jehlan : Objekt3D
    {

        private double width;
        private double height;

        public Jehlan(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override string Kresli()
        {
            return "Pyramid wíth height " + height + " and base " + width;
        }

        public override double SpoctiObjem()
        {
            return 1/3 * width * width * height;
        }

        public override double SpoctiPovrch()
        {
            return width * (width + Math.Sqrt( 4 * height * height + width * width));
        }
    }
}

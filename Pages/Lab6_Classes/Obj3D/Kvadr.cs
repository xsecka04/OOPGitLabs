using System;
namespace OOPGitLabs.Pages.Lab6_Classes
{
    public class Kvadr : Objekt3D
    {

        private double width;
        private double height;
        private double depth;

        public Kvadr(double width, double height, double depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }

        public override string Kresli()
        {
            return "Cuboid wíth dimensions " + width + ", " + height + " and " + depth;
        }

        public override double SpoctiObjem()
        {
            return width * depth * height;
        }

        public override double SpoctiPovrch()
        {
            return 2 * (width * depth + width * height + depth * height);
        }
    }
}

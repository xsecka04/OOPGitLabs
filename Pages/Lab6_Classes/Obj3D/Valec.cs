using System;
namespace OOPGitLabs.Pages.Lab6_Classes
{
    public class Valec : Objekt3D
    {

        private double radius;
        private double height;

        public Valec(double rad, double height)
        {
            radius = rad;
            this.height = height;
        }

        public override string Kresli()
        {
            return "Cylinder wíth height " + height + " and radius " + radius;
        }

        public override double SpoctiObjem()
        {
            return Math.PI * radius * radius * height;
        }

        public override double SpoctiPovrch()
        {
            return 2 * Math.PI * radius * (radius + height);
        }
    }
}

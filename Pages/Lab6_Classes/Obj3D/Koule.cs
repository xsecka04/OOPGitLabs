using System;
namespace OOPGitLabs.Pages.Lab6_Classes
{
    public class Koule : Objekt3D
    {

        private double radius;

        public Koule(double rad)
        {
            radius = rad;
        }

        public override string Kresli()
        {
            return "Sphere wíth radius " + radius;
        }

        public override double SpoctiObjem()
        {
            return 4/3 * Math.PI * Math.Pow(radius, 3);
        }

        public override double SpoctiPovrch()
        {
            return 4 * Math.PI + Math.Pow(radius, 2);
        }
    }
}

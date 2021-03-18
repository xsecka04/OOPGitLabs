using System;
namespace OOPGitLabs.Pages.Lab6_Classes
{
    public class Objekt3D : GrObjekt
    {
        public Objekt3D()
        {
        }

        public virtual double SpoctiPovrch() { return 0; }
        public virtual double SpoctiObjem() { return 0; }

        
    }
}

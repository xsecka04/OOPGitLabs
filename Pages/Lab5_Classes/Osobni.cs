using System;
namespace OOPGitLabs.Pages.Lab5_Classes
{
    public class Osobni : Auto
    {
        public Osobni(int vel, TypPaliva typ, int max) : base(vel, typ)
        {
            MaxOsob = max;
            PrepravovaneOsoby = 0;
        }

        public int MaxOsob { get; private set; }

        private int _PrepravovaneOsoby;
        public int PrepravovaneOsoby {

            get { return _PrepravovaneOsoby; }
            set
            {
                if (value <= MaxOsob)
                    _PrepravovaneOsoby = value;

                else
                    throw new Exception("Too many peeps on board");
            }
        }

        public override string ToString()
        {
            return "Persons on board:" + PrepravovaneOsoby;
        }


    }
}

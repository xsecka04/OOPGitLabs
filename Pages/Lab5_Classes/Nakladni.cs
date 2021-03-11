using System;
namespace OOPGitLabs.Pages.Lab5_Classes
{
    public class Nakladni : Auto
    {
        public Nakladni(int vel, TypPaliva typ, int max) : base(vel, typ)
        {
            MaxNaklad = max;
            PrepravovanyNaklad = 0;
        }

        public int MaxNaklad { get; private set; }

        private int _PrepravovanyNaklad;
        public int PrepravovanyNaklad {

            get { return _PrepravovanyNaklad; }
            set
            {
                if (value <= MaxNaklad)
                    _PrepravovanyNaklad = value;

                else
                    throw new Exception("Too much stuff on board");
            }
        }

        public override string ToString()
        {
            return "Stuff on board:" + PrepravovanyNaklad;
        }



    }
}

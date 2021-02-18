using System;
namespace OOPGitLabs.Pages.Lab2_Classes
{
    public class TestComplex
    {
        public Complex Measured;
        public Complex Expected;
        public string Name;
        private const double Epsylon = 1E-6;

        public static string Test(Complex me, Complex ex, string name)
        {
            return (Math.Abs(me.Realna - ex.Realna) < Epsylon && Math.Abs(me.Imaginarni - ex.Imaginarni) < Epsylon) ?
                $"{name} OK" : $"{name} Chyba: Ocekavana hodnota: {ex.ToString()} Skutecna hodnota: {me.ToString()}";
        }
    }
}


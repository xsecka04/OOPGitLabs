using System;
namespace OOPGitLabs.Pages.Lab5_Classes
{
    public abstract class Auto
    {
        public Auto(int vel, TypPaliva typ)
        {
            VelikostNadrze = vel;
            Palivo = typ;
            StavNadrze = 0;
            Radio = new Autoradio();
        }

        public enum TypPaliva
        {
            Benzin,
            Nafta
        }

        public int VelikostNadrze { get; protected set; }
        public int StavNadrze { get; protected set; }
        public TypPaliva Palivo { get; protected set; }
        public Autoradio Radio;
        public void Natankuj(TypPaliva p, int amount)
        {
            if (p == Palivo && (amount + StavNadrze) <= VelikostNadrze)
                StavNadrze += amount;

            else
                throw new Exception("Wrong fuel type or the car is full");
        }

    }
}

using System;
namespace OOPGitLabs.Pages.Lab2_Classes
{
    public class Complex
    {
        public double Realna { get; set; }
        public double Imaginarni { get; set; }

        public Complex() { }
        public Complex(double re, double im)
        {
            Realna = re;
            Imaginarni = im;
        }

        public static Complex operator +(Complex first, Complex sec)
        {
            return new Complex(first.Realna + sec.Realna, first.Imaginarni + sec.Imaginarni);
        }

        public static Complex operator -(Complex first, Complex sec)
        {
            return new Complex(first.Realna - sec.Realna, first.Imaginarni - sec.Imaginarni);
        }

        public static Complex operator *(Complex first, Complex sec)
        {
            return new Complex(first.Realna * sec.Realna, first.Imaginarni * sec.Imaginarni);
        }

        public static Complex operator /(Complex first, Complex sec)
        {
            return new Complex(first.Realna / sec.Realna, first.Imaginarni / sec.Imaginarni);
        }

        public static Boolean operator ==(Complex first, Complex sec)
        {
            return (first.Realna == sec.Realna && first.Imaginarni == sec.Imaginarni) ? true : false;
        }

        public static Boolean operator !=(Complex first, Complex sec)
        {
            return (first == sec) ? false : true;
            //return (first.Realna == sec.Realna && first.Imaginarni == sec.Imaginarni) ? false : true;
        }

        public static Complex operator -(Complex first)
        {
            return new Complex(-first.Realna, -first.Imaginarni);
        }

        public Complex conjugate()
        {
            return new Complex(this.Realna, -this.Imaginarni);
        }

        public double modus()
        {
            return Math.Sqrt(this.Realna * this.Realna + this.Imaginarni * this.Imaginarni);
        }

        public double argument()
        {
            return Math.Atan2(this.Imaginarni, this.Realna);
        }

        public override string ToString()
        {
            return $"{this.Realna}+{this.Imaginarni}i";
        }

    }

}


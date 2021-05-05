using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace OOPGitLabs.Pages.Project_Classes
{
    public static class Parser
    {

        private static readonly Regex algebraic = new(@"([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)\s*\+\s*([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)i");
        private static readonly Regex exponential = new(@"([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)\s*e\^i\s*([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)");

        public static Complex Parse(string input)
        {
            Match match;
            double real, img;
            if (input.Contains("e^i"))
            {
                match = exponential.Match(input);
                double r = double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
                double phi = double.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
                real = r * Math.Cos(phi);
                img = r * Math.Sin(phi);
            }
            else
            {
                match = algebraic.Match(input);
                real = double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
                img = double.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);

            }
            return new Complex(real, img);

        }

        public static string switchNotation(string input)
        {
            Match match = algebraic.Match(input);
            double real = double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
            double img = double.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
            return String.Format("{0:0.000}e^i{1:0.000}", Math.Sqrt(Math.Pow(real, 2) + Math.Pow(img, 2)), Math.Atan(img / real));

        }
    }
}

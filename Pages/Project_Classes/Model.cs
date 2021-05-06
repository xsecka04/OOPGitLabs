using System;
using System.Collections.Generic;

namespace OOPGitLabs.Pages.Project_Classes
{
    public enum Operator
    {
        plus = '+',
        minus = '-',
        mult = '*',
        divide = '/',
    }

    public class Model
    {
        public Model()
        {

        }

        public List<Tuple<Complex, Operator>> numbers = new List<Tuple<Complex, Operator>>();

        public string Input { get; set; }
        public Complex Output { get; set; } = null;
        public int err;
        public void Add(string input, Operator op)
        {
            try {
                numbers.Add(new Tuple<Complex, Operator>(Parser.Parse(input), op));
                err = 0;
            }
            catch
            {
                err = 1;
            }
        }

        public void Ans()
        {
            if (Output is not null)
            {
                numbers = new();
                numbers.Add(new Tuple<Complex, Operator>(Output, Operator.plus));
                Output = null;
            }
        }

        public void Del()
        {
            if (numbers.Count > 0)
            {
                numbers.RemoveAt(numbers.Count - 1);
            }
        }

        public void Calculate()
        {
            Complex result = new(0,0);

            foreach(Tuple<Complex, Operator> number in numbers)
            {
                switch (number.Item2) {

                    case Operator.plus:
                        result = result + number.Item1;
                        break;
                    case Operator.minus:
                        result = result - number.Item1;
                        break;
                    case Operator.mult:
                        result = result * number.Item1;
                        break;
                    case Operator.divide:
                        result = result / number.Item1;
                        break;
                }
            }
            Output = result;

        }
    }

}

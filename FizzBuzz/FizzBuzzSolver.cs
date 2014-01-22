using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzSolver : IFizzBuzzSolver
    {
        private readonly IList<string> _strings = new[] {null, "Fizz", "Buzz", "FizzBuzz"};

        public string Solve(int numberToPrint)
        {
            int key = 0;
            if (numberToPrint%3 == 0)
                key |= 1;
            if (numberToPrint%5 == 0)
                key |= 2;

            string s = _strings[key];
            return s != null ? s : numberToPrint.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzSolver : FizzBuzz.IFizzBuzzSolver
    {
        private IDictionary<int, string> _strings = new Dictionary<int, string> {{1 , "Fizz"}, {2 , "Buzz"}, {3 , "FizzBuzz"}}; 
        public string Solve(int numberToPrint)
        {
            int x = 0;
            if (numberToPrint%3 == 0)
                x |= 1;
            if (numberToPrint%5 == 0)
                x |= 2;

            string s;
            return _strings.TryGetValue(x, out s) ? s : numberToPrint.ToString();
        }
    }
}

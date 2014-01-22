using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzSolver : FizzBuzz.IFizzBuzzSolver
    {
        public string Solve(int numberToPrint)
        {
            int x = 0;
            if (numberToPrint%3 == 0)
                x |= 1;
            if (numberToPrint%5 == 0)
                x |= 2;
            switch (x)
            {
                case 1:
                    return "Fizz";
                    break;
                case 2:
                    return "Buzz";
                    break;
                case 3:
                    return "FizzBuzz";
                    break;
                default:
                    return numberToPrint.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class NegativeNumberException : Exception
    {   // If number is negative then throw negative number exception.
        public NegativeNumberException(string message) : base(message)
        {

        }
    }
    public class NegativeExp
    {
        static void Main(string[] args)
        {
            int number = -5;
            try
            {
                if (number < 0)
                {
                    throw new NegativeNumberException("Number cannot be negative");
                }
            }
            catch(NegativeNumberException exp)
            {
               Console.WriteLine(exp.Message);
            }
              
        }
    }
}

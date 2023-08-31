using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class NameExcp
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                string str = null;
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("Name is required");
                }
                Console.WriteLine(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Inside the finally block");

            }
        }
    }
}

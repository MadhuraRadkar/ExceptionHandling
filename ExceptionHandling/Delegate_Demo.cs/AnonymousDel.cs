using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Delegate_Demo.cs
{   // Anonymous method using Delegate.

    public delegate void PerDelegate2();
    public class Student1
    {
        public event PerDelegate Fail;
        public event PerDelegate Pass;
        public void AcceptPercentage(double per)
        {
            if (per < 40)
            {
                Fail();

            }
            else
            {
                Pass();
            }
        }
    }
    public class ProgramAnony
    {
        static void Main(string[] args)
        {
            try
            {
                Student std1 = new Student();

                std1.Fail += delegate () { Console.WriteLine("You are fail in the exam"); };
                std1.Pass += delegate () { Console.WriteLine("You are pass in the exam"); };

                std1.AcceptPercentage(45);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }



        }


    }
}
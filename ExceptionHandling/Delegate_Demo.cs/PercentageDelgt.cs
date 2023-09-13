using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Delegate_Demo.cs
{   // Using Event.
    public delegate void PerDelegate();
    public class Student
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
    public class Message
    {
        public void SuccessMessage()
        {
            Console.WriteLine("You are pass in the exam");
        }
        public void FailMessage()
        {
            Console.WriteLine("You are fail in the exam");
        }
    }
    public class ProgramPer
    {
        static void Main(string[] args)
        {
            try
            {
                Student std1 = new Student();
                Message msg = new Message();
                std1.Fail += new PerDelegate(msg.FailMessage);
                std1.Pass += new PerDelegate(msg.SuccessMessage);

                std1.AcceptPercentage(45);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
    }

}

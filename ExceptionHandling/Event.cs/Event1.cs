using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Event.cs
{
        public class event1
        {
            static void Main(string[] args)
            {
                try
                {
                    Student stud1 = new Student();
                    Message msg = new Message();

                    // bind event with delegate
                    stud1.Fail += new MyDelegate(msg.FailMessage);
                    stud1.Pass += new MyDelegate(msg.SuccessMessage);

                    stud1.AcceptPercen(25);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }

        public delegate void MyDelegate();
        public class Student
        {
            
            public event MyDelegate Fail; 
            public event MyDelegate Pass;
            public void AcceptPercen(double per)
            {
                if (per < 30)
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
                Console.WriteLine("You are Pass ");
            }
            public void FailMessage()
            {
                Console.WriteLine("You are Fail ");
            }
        }
    
}

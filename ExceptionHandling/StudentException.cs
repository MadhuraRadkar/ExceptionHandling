using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class NameException : Exception
    {
        public NameException(string error) : base(error)
        {

        }
    }
    public class Student
    {
        public Student(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameException("name is required");
            }
        }
    }
    public class ProgramExcep
    {
        static void Main(string[] args)
        {
            try
            {
                Student std1 = new Student(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

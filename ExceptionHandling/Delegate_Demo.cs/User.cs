using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Delegate_Demo.cs
{  
    // 1.Create a class user, create method with AcceptName(string name),Convert the name in upper case and return. */ SingleCast
    // & Create the delegate to hold acceptname method reference & invoke using delegate & Convert name in lower case also.*/Multicast.
   
    public delegate string MyDelegate(string name);
    public class User
    {
        public string AcceptName(string name)
        {
            return name;
        }
        public string ConvertToUpper(string name)
        {
            return name.ToUpper();
        }
        public string ConvertToLower(string name)
        {
            return name.ToLower();
        }
    }

    public class programDelegate
    {
        static void Main(string[] args)
        {
            User user = new User();
           
            MyDelegate myDelegate = new MyDelegate(user.AcceptName);
            myDelegate += new MyDelegate(user.ConvertToUpper);
            myDelegate += new MyDelegate(user.ConvertToLower);

            Delegate[] list = myDelegate.GetInvocationList();
            foreach(Delegate d in list)
            {
                Console.WriteLine(d.Method);
                string result = Convert.ToString(d.DynamicInvoke("Madhura"));
                Console.WriteLine(result);
            }
        }
    }

}

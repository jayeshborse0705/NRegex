using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Validation");
            Validation validation = new Validation();
           
            //uc1 : first  name
            Console.WriteLine("Enter the First Name : ");
            var first_Name = Console.ReadLine();
            validation.First_Name(first_Name);

            //uc2 : last name
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Last Name");
            var last_Name = Console.ReadLine();
            validation.Last_Name(last_Name);

            //uc3 : Email
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Email Id");
            var email_Id = Console.ReadLine();
            validation.EmailId(email_Id);

            //uc4 : Mobile Number
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Mobile Number");
            var mobileNum = Console.ReadLine();
            validation.Mobile(mobileNum);

        }
    }
}

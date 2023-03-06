using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principes
{
    public class PersonDataCapture
    {
        public static Person capture()
        {
            Person userResult = new Person();

            Console.Write("What is your first name: ");
            userResult.firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            userResult.lastName = Console.ReadLine();

            return userResult;
        }
    }
}

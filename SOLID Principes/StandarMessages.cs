using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principes
{
    public class StandarMessages
    {
        public static void welcomeMessage()
            {
             Console.WriteLine("my application");
        }

        public static void endApplication()
        {
            Console.ReadLine();
        }

        public static void displayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid {fieldName}");
        }
    }
}

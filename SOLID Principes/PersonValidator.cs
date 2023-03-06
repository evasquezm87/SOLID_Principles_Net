using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principes
{
    public class PersonValidator
    {
        public static bool validate(Person person)
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(person.firstName))
            {
                StandarMessages.displayValidationError("first Name");
                result = false;
            }

            if(string.IsNullOrWhiteSpace(person.lastName))
            {
                StandarMessages.displayValidationError("Last Name");
                result = false;
            }

            return result;
        }
    }
}

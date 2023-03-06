using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCP_Library.Applicants;

namespace OCP_Library.Accounts
{
    public class ManagerAccounts : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.firstName = person.firstName;
            output.lastName = person.lastName;
            output.emailAdress = $"{person.firstName.Substring(0, 1)}{person.lastName}@ourcorporate.com";

            output.isManager = true;

            return output;
        }
    }
}

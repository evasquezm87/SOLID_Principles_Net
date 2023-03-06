using OCP_Library.Applicants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Library.Accounts
{
    public class ExecutiveAccount : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.firstName = person.firstName;
            output.lastName = person.lastName;
            output.emailAdress = $"{person.firstName}{person.lastName}@ourcorporate.com";
            output.isManager = true;
            output.isExecutive = true;

            return output;
        }
    }
}

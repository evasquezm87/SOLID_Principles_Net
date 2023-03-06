using OCP_Library.Accounts;
using OCP_Library.Applicants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Library.Applicants
{
    public class ExecutiveModel : IApplicantModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public IAccount AccountProcessor { get; set; } = new ExecutiveAccount();
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCP_Library.Accounts;

namespace OCP_Library.Applicants
{
    public class ManagerModel : IApplicantModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public IAccount AccountProcessor { get; set; } = new ManagerAccounts();
    }
}

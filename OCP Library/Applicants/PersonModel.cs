using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Library
{
    public class PersonModel : IApplicantModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public IAccount AccountProcessor { get; set; } = new Account();

    }
}

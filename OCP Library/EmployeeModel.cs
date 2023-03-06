using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Library
{
    public class EmployeeModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAdress { get; set; }
        public bool isManager { get; set; } = false;
        public bool isExecutive { get; set; }   = false;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeqomTestSolution
{
    public class Employee
    {
        public string Name { get; set; }
        public EmployeeType Type { get; set; }
        public int Years { get; set; }
        public decimal Salary { get; set; }

        public string MaskName()
        {
            return Name.Length <= 3 ? Name : Name.Substring(0, 3) + new string('*', Name.Length - 3);
        }
    }

}

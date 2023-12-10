using BeqomTestSolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeqomTestSolution.SalaryStrategies
{
    public class TraineeSalaryStrategy : ISalaryStrategy
    {
        public decimal CalculateNewSalary(Employee employee)
        {
            return employee.Salary * 1.01m;
        }
    }
}

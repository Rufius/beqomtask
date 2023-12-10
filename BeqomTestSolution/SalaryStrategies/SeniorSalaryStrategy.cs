using BeqomTestSolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeqomTestSolution.SalaryStrategies
{
    public class SeniorSalaryStrategy : ISalaryStrategy
    {
        public decimal CalculateNewSalary(Employee employee)
        {
            int effectiveYears = Math.Min(employee.Years, 5);
            return employee.Salary * (1.1m + 0.01m * effectiveYears);
        }
    }
}

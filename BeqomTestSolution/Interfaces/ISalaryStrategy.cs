using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeqomTestSolution.Interfaces
{
    public interface ISalaryStrategy
    {
        decimal CalculateNewSalary(Employee employee);
    }
}

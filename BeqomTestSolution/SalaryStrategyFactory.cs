using BeqomTestSolution.Interfaces;
using BeqomTestSolution.SalaryStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeqomTestSolution
{
    public class SalaryStrategyFactory: ISalaryStrategyFactory
    {
        public ISalaryStrategy GetSalaryStrategy(EmployeeType type)
        {
            switch (type)
            {
                case EmployeeType.Trainee:
                    return new TraineeSalaryStrategy();
                case EmployeeType.Junior:
                    return new JuniorSalaryStrategy();
                case EmployeeType.Senior:
                    return new SeniorSalaryStrategy();
                case EmployeeType.Manager:
                    return new ManagerSalaryStrategy();
                default:
                    throw new ArgumentException("Invalid employee type");
            }
        }
    }

}

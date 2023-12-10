using BeqomTestSolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeqomTestSolution
{
    public class EmployeeProcessor: IEmployeeProcessor
    {
        private readonly ISalaryStrategyFactory _salaryStrategyFactory;

        public EmployeeProcessor(ISalaryStrategyFactory salaryStrategyFactory)
        {
            _salaryStrategyFactory = salaryStrategyFactory;
        }

        public string GenerateEmployeeReport(Employee employee)
        {
            var strategy = _salaryStrategyFactory.GetSalaryStrategy(employee.Type);
            var newSalary = strategy.CalculateNewSalary(employee);
            return $"Employee Name: {employee.MaskName()}, Type: {employee.Type}, Years: {employee.Years}, Salary: {employee.Salary}, New Salary: {newSalary}";
        }

        public string GenerateReport(List<Employee> employees)
        {
            var report = new StringBuilder();
            foreach (var employee in employees)
            {
                report.AppendLine(GenerateEmployeeReport(employee));
            }
            return report.ToString();
        }
    }
}

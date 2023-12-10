using BeqomTestSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class EmployeeProcessorTests
    {
        [Fact]
        public void GenerateReport_ShouldReturnCorrectReportFormat()
        {
            var employees = new List<Employee>
            {
                new Employee { Name = "John Lennon", Type = EmployeeType.Manager, Years = 10, Salary = 90000 },
                new Employee { Name = "Paul McCartney", Type = EmployeeType.Senior, Years = 8, Salary = 85000 },
                new Employee { Name = "George Harrison", Type = EmployeeType.Junior, Years = 5, Salary = 60000 },
                new Employee { Name = "Ringo Starr", Type = EmployeeType.Trainee, Years = 2, Salary = 45000 }
            };

            var processor = new EmployeeProcessor(new SalaryStrategyFactory());

            var report = processor.GenerateReport(employees);
        }
    }
}

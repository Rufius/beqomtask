using BeqomTestSolution;
using Xunit;

namespace Tests
{
    public class SalaryStrategyTests
    {
        [Theory]

        // Junior Employee Test Cases
        [InlineData(50000, 3, EmployeeType.Junior, 54000)]
        [InlineData(55000, 2, EmployeeType.Junior, 58850)] 
        [InlineData(60000, 5, EmployeeType.Junior, 66000)] 

        // Senior Employee Test Cases
        [InlineData(80000, 10, EmployeeType.Senior, 92000)]
        [InlineData(85000, 4, EmployeeType.Senior, 96900)]
        [InlineData(75000, 6, EmployeeType.Senior, 86250)]

        // Trainee Employee Test Cases
        [InlineData(40000, 1, EmployeeType.Trainee, 40400)]
        [InlineData(45000, 2, EmployeeType.Trainee, 45450)]
        [InlineData(35000, 0, EmployeeType.Trainee, 35350)]

        // Manager Employee Test Cases
        [InlineData(90000, 3, EmployeeType.Manager, 106200)]
        [InlineData(95000, 7, EmployeeType.Manager, 114000)]
        [InlineData(100000, 5, EmployeeType.Manager, 120000)]

        public void CalculateNewSalary_ShouldReturnExpectedSalary(decimal salary, int years, EmployeeType type, decimal expected)
        {
            var employee = new Employee { Salary = salary, Years = years, Type = type };
            var factory = new SalaryStrategyFactory();
            var strategy = factory.GetSalaryStrategy(type);

            var newSalary = strategy.CalculateNewSalary(employee);

            Assert.Equal(expected, newSalary);
        }
    }

}
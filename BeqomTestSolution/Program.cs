using BeqomTestSolution.Interfaces;
using BeqomTestSolution;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

var serviceProvider = new ServiceCollection()
    .AddTransient<IEmployeeProcessor, EmployeeProcessor>()
    .AddTransient<ISalaryStrategyFactory, SalaryStrategyFactory>()
    .BuildServiceProvider();

var employees = new List<Employee>
{
    new Employee { Name = "John Lennon", Type = EmployeeType.Manager, Years = 10, Salary = 90000 },
    new Employee { Name = "Paul McCartney", Type = EmployeeType.Senior, Years = 8, Salary = 85000 },
    new Employee { Name = "George Harrison", Type = EmployeeType.Junior, Years = 5, Salary = 60000 },
    new Employee { Name = "Ringo Starr", Type = EmployeeType.Trainee, Years = 2, Salary = 45000 }
};


// Resolve the EmployeeProcessor instance
var employeeProcessor = serviceProvider.GetService<IEmployeeProcessor>();

// Generate and print the report
string report = employeeProcessor.GenerateReport(employees);
Console.WriteLine(report);
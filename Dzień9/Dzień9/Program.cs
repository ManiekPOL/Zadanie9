

using Dzień9;

var employee = new Employee("Adam", "Mork");
employee.AddGrade(6);
employee.AddGrade(2);
employee.AddGrade(2);
var statistics = employee.GetStatistics();
Console.WriteLine("Pracownik Adam Mork ");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");




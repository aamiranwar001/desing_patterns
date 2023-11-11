using Design_Patterns.Specification.EmployeeSpecification;

var employee = new Employee
{
    FirstName = "Aamir",
    LastName = "Anwar",
    Basic = 5000,
    IsFullTime = true
};

var basicSpecification = new BasicSpecification();
var fullTimeSpecification = new FullTimeSpecification();

var compositeSpecification = basicSpecification.And(fullTimeSpecification);
var isSatisfied = compositeSpecification.IsSatisfied(employee);

if (isSatisfied)
{
    Console.WriteLine("👍 Employee meets basic and fulltime criteria");
}
else
{
    Console.WriteLine("Employee does not meet basic and fulltime criteria 🙃");
}
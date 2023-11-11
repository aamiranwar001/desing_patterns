namespace Design_Patterns.Specification.EmployeeSpecification
{
    public class FullTimeSpecification : Specification<Employee>
    {
        public override bool IsSatisfied(Employee employee)
        {
            return employee.IsFullTime;
        }
    }
}

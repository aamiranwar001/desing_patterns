namespace Design_Patterns.Specification.EmployeeSpecification
{
    public class BasicSpecification : Specification<Employee>
    {
        public override bool IsSatisfied(Employee employee)
        {
            return employee.Basic >= 5000;
        }
    }
}

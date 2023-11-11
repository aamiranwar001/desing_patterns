namespace Design_Patterns.Specification
{
    public interface ISpecification<in T>
    {
        bool IsSatisfied(T item);
    }
}

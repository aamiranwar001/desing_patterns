namespace Design_Patterns.Specification
{
    public class NotSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _specification;

        public NotSpecification(Specification<T> specification)
        {
            _specification = specification;
        }

        public override bool IsSatisfied(T item)
        {
            return !_specification.IsSatisfied(item);
        }
    }
}

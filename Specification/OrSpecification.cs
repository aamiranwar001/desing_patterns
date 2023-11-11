namespace Design_Patterns.Specification
{
    public class OrSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _leftSpecification;
        private readonly Specification<T> _rightSpecification;

        public OrSpecification(Specification<T> leftSpecification, Specification<T> rightSpecification)
        {
            _leftSpecification = leftSpecification;
            _rightSpecification = rightSpecification;
        }

        public override bool IsSatisfied(T item)
        {
            return _leftSpecification.IsSatisfied(item) || _rightSpecification.IsSatisfied(item);
        }
    }
}

namespace OpenClosedPrinciple
{
    // Enterprise Specification Pattern 
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
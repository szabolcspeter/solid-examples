using System.Collections.Generic;

namespace OpenClosedPrinciple
{
  public class BetterFilter : IFilter<Product>
  {
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
      foreach (var p in items)
        if (spec.IsSatisfied(p))
            yield return p;
    }
  }
}
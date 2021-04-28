namespace InterfaceSegregationPrinciple
{
  public class PhotoCopier : IPrinter, IScanner
  {
    public void Print(Document d)
    {
      throw new System.NotImplementedException();
    }

    public void Scan(Document d)
    {
      throw new System.NotImplementedException();
    }
  }
}
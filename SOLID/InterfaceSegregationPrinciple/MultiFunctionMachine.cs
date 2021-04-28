using System;

namespace InterfaceSegregationPrinciple
{
  public class MultiFunctionMachine : IMultiFunctionDevice
  {
    private IPrinter _printer;
    private IScanner _scanner;

    public MultiFunctionMachine(IPrinter printer, IScanner scanner)
    {
      _printer = printer ?? throw new ArgumentNullException(paramName: nameof(printer));
      _scanner = scanner ?? throw new ArgumentNullException(paramName: nameof(scanner));
    }

    // Delegating (decorator)
    public void Print(Document d)
    {
      _printer.Print(d);
    }

    // Delegating (decorator)
    public void Scan(Document d)
    {
      _scanner.Scan(d);
    }
  }
}
using System;
using System.Diagnostics;
using SingleResponsibilityPrinciple;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            Console.WriteLine(j);

            var p = new Persistence();
            var filename = @"d:\journal.txt";
            p.SaveToFile(j, filename, true);
            // Process.Start(filename);
        }
    }
}

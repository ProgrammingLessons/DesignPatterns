using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    // The class that will visit the printers required for fax processing
    public class FaxVisitor : IVisitor
    {
        // Visiting for HPPrinter model
        public void Visit(HPPrinter hPPrinter)
        {
            Console.WriteLine($"Sending fax from {nameof(HPPrinter)}");
        }

        // Visiting for LexmarkPrinter model
        public void Visit(LexmarkPrinter lexmarkPrinter)
        {
            Console.WriteLine($"Sending fax from {nameof(LexmarkPrinter)}");
        }
    }
}

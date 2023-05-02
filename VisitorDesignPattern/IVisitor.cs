using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    // Visitor interface is defined for methods to visit printers
    public interface IVisitor
    {
        void Visit(HPPrinter hPPrinter);
        void Visit(LexmarkPrinter lexmarkPrinter);
    }
}

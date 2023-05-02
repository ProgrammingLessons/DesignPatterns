using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    // Defining the printer interface
    public interface IPrinter
    {
        // Print feature on printers
        void Print();

        // method to establish a relationship with the visitor object
        void Accept(IVisitor visitor);
    }
}

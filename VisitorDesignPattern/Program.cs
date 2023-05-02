using System;

namespace VisitorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Printer are defined
            HPPrinter hp = new();
            LexmarkPrinter lexmark = new();

            // Printing is done
            hp.Print();
            lexmark.Print();

            // The visitor is defined and given to the visitor class with accept,
            // the control is passed to the visitor and fax operations are made.
            IVisitor fax = new FaxVisitor();
            hp.Accept(fax);
            lexmark.Accept(fax);
        }
    }
}

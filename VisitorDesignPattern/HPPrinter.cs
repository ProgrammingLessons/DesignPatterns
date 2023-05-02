using System;

namespace VisitorDesignPattern
{
    // Printer definition is done
    public class HPPrinter : IPrinter
    {
        // It sends its real object to the Concrete Visitor object with this keyword
        // and the responsibility for the functional process is now given to the Concrete Visitor object. 
        public void Accept(IVisitor visitor) => visitor.Visit(this);

        public void Print()
        {
            Console.WriteLine($"{nameof(HPPrinter)} yazdırıyor...");
        }
    }
}
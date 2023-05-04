using System;

namespace ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining proxy object. 
            GeographyProxy geographyProxy = new ();
            // Coordinate calling method
            geographyProxy.GetGeograpghCode("London");
            geographyProxy.GetGeograpghCode("Amsterdam");
        }
    }
}

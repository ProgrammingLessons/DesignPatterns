using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    // Defining proxy class
    public class GeographyProxy : IGeography
    {
        // Defining a class that cannot be accessed by the client
        private Geography _geography;
        // Retrieving data from real class with the help of proxy
        public string GetGeograpghCode(string city)
        {
            return _geography.GetGeograpghCode(city);
        }
    }
}

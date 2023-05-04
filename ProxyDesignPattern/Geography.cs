using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    // We define the inaccessible class
    public class Geography : IGeography
    {
        // Method that gives coordinates by city
        public string GetGeograpghCode(string city)
        {
            if (city == "Amsterdam")
            {
                return "52.3700° N, 4.8900° E";
            }
            else if (city == "London")
            {
                return "51.5171° N, 0.1062° W";
            }
            else if (city == "Paris")
            {
                return "48.8742° N, 2.3470° E";
            }
            else if (city == "Berlin")
            {
                return "52.5233° N, 13.4127° E";
            }
            else
            {
                throw new Exception("Invalid City");
            }
        }
    }
}

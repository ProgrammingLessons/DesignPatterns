using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    // Defines the proxy and the interface that our real object will use
    public interface IGeography
    {
        // The method to perform the operation is defined
        string GetGeograpghCode(string city);
    }
}

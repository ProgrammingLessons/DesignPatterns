using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.Case6
{
    public sealed class Singleton
    {
        // A variable is defined using lambda expression
        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());

        // Instance is returned when invoked
        public static Singleton Instance { get { return lazy.Value; } }

        private Singleton()
        {
        }
    }
}

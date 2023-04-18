using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.Case2
{
    public sealed class Singleton
    {
        // static Singleton variable is defined
        private static Singleton instance = null;
        // A variable is defined to use the lock structure.
        private static readonly object padlock = new object();

        // The constructor method is created
        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                // The lock and control only work once at a time and the operation is ensured to be sequential.
                lock (padlock)
                {
                    // Check for null when instance variable variable is called
                    if (instance == null)
                    {
                        // If there is no instance, send a new instance
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }
}

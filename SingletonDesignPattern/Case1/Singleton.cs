using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.Case1
{
    public sealed class Singleton
    {
        // static Singleton variable is defined
        private static Singleton instance = null;

        // The constructor method is created
        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
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

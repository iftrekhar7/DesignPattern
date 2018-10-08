using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class LockSingleton
    {
        private static LockSingleton instance = null;
        private static readonly object padlock = new object();

        LockSingleton()
        {
        }

        public static LockSingleton InstanceGet()
        {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new LockSingleton();
                    }
                    return instance;
                }
        }
    }
}

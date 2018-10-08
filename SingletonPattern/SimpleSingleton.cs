using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SimpleSingleton // not thread-safe
    {
        private static SimpleSingleton instance = null;

        private SimpleSingleton()
        {
        }

        public static SimpleSingleton GetInstance()
        {
                if (instance == null)
                {
                    instance = new SimpleSingleton();
                }
                return instance;
        }
    }
}

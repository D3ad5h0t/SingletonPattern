using System.Collections.Generic;

namespace Multiton
{
    public class Printer
    {
        private Printer()
        {
            
        }

        public static Printer Get(Subsystem ss)
        {
            if (_instances.ContainsKey(ss))
            {
                return _instances[ss];
            }
            
            var instance = new Printer();
            _instances[ss] = instance;

            return instance;
        }

        private static readonly Dictionary<Subsystem, Printer> _instances = new Dictionary<Subsystem, Printer>();
    }
}
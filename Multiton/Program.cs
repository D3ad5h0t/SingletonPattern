using System;
using System.Collections.Generic;

namespace Multiton
{
    class Program
    {
        static void Main(string[] args)
        {
            var primary = Printer.Get(Subsystem.Main);
            var backup = Printer.Get(Subsystem.Backup);

            var primary2 = Printer.Get(Subsystem.Main);
            Console.WriteLine(ReferenceEquals(primary, primary2));
        }
    }

    public enum Subsystem
    {
        Main,
        Backup
    }

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
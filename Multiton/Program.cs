using System;

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
}
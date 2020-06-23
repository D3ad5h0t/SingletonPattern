using System;

namespace Monostate
{
    class Program
    {
        static void Main(string[] args)
        {
            var ceo = new ChiefExecutiveOfficer();
            ceo.Name = "Adam Smith";
            ceo.Age = 55;
            
            var ceo2 = new ChiefExecutiveOfficer();
            ceo.Age = 66;

            Console.WriteLine(ceo);
            Console.WriteLine(ceo2);
        }
    }
}
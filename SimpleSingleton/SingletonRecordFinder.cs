using System.Collections.Generic;
using System.Linq;

namespace SimpleSingleton
{
    public class SingletonRecordFinder
    {
        public int TotalPopulation(IEnumerable<string> names)
        {
            return names.Sum(name => SingletonDatabase.Instance.GetPopulation(name));
        }
    }
}
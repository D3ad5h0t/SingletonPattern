using System.Collections.Generic;
using System.Linq;

namespace SimpleSingleton
{
    public class ConfigurableRecordFinder
    {
        private readonly IDatabase _database;

        public ConfigurableRecordFinder(IDatabase database)
        {
            _database = database;
        }
        
        public int TotalPopulation(IEnumerable<string> names)
        {
            return names.Sum(name => _database.GetPopulation(name));
        }
    }
}
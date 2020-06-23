using System.Collections.Generic;
using NUnit.Framework;
using SimpleSingleton;

namespace SingletonTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void IsSingletonTest()
        {
            var db = SingletonDatabase.Instance;
            var db2 = SingletonDatabase.Instance;

            Assert.That(db, Is.SameAs(db2));
            Assert.That(SingletonDatabase.Count, Is.EqualTo(1));
        }

        [Test]
        public void SingletonTotalPopulationTest()
        {
            var rf = new SingletonRecordFinder();
            var names = new[] {"Seoul", "Mexico City"};
            var tp = rf.TotalPopulation(names);

            Assert.That(tp, Is.EqualTo(17_500_000 + 17_400_000));
        }

        [Test]
        public void DependentTotalPopulationTest()
        {
            var db = new DummyDatabase();
            var rf = new ConfigurableRecordFinder(db);
            Assert.That(rf.TotalPopulation(
                new[] { "alpha", "gamma"}), 
                        Is.EqualTo(4));
        }
    }

    public class DummyDatabase : IDatabase
    {
        public int GetPopulation(string city)
        {
            return new Dictionary<string, int>
            {
                ["alpha"] = 1,
                ["beta"] = 2,
                ["gamma"] = 3
            }[city];
        }
    }
}
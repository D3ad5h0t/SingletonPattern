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
            int tp = rf.TotalPopulation(names);
            
            Assert.That(tp, Is.EqualTo(17_500_000 + 17_400_000));
        }
    }
}

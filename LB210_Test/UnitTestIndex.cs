
namespace LB210_Test
{
    [TestClass]
    public class UnitTestIndex
    {

        [TestMethod]
        public void TestId1()
        {
            IndexModel m = new IndexModel();
            int id = m.GetJokeId();
            Assert.IsTrue(id < Jokes.Count);

        }
        [TestMethod]
        public void TestId2()
        {
            IndexModel m = new IndexModel();
            int id = m.GetJokeId();
            Assert.IsTrue(id >= 0);

        }
    }
}

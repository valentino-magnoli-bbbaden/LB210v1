namespace LB210_Test
{
    [TestClass]
    public class UnitTestJokes
    {
        [TestMethod]
        public void TestCount()
        {
            Assert.IsTrue(Jokes.Count >= 12);
        }
        [TestMethod]
        public void TestJokesGet0()
        {
            Assert.IsTrue(Jokes.Get(0).Length > 20);
        }
        [TestMethod]
        public void TestJokesGet1()
        {
            Assert.IsTrue(Jokes.Get(1).Length > 20);
        }
        [TestMethod]
        public void TestJokesGet2()
        {
            Assert.IsTrue(Jokes.Get(2).Length > 20);
        }
        [TestMethod]
        public void TestJokesGet3()
        {
            Assert.IsTrue(Jokes.Get(3).Length > 20);
        }
        [TestMethod]
        public void TestJokesGet4()
        {
            Assert.IsTrue(Jokes.Get(4).Length > 20);
        }
        [TestMethod]
        public void TestJokesGet5()
        {
            Assert.IsTrue(Jokes.Get(5).Length > 20);
        }
        [TestMethod]
        public void TestJokesGet6()
        {
            Assert.IsTrue(Jokes.Get(6).Length > 20);
        }
        [TestMethod]
        public void TestJokesGet7()
        {
            Assert.IsTrue(Jokes.Get(7).Length > 20);
        }
        [TestMethod]
        public void TestJokesGet8()
        {
            Assert.IsTrue(Jokes.Get(8).Length > 20);
        }
        [TestMethod]
        public void TestJokesGet9()
        {
            Assert.IsTrue(Jokes.Get(9).Length > 20);
        }
        [TestMethod]
        public void TestJokesGet10()
        {
            Assert.IsTrue(Jokes.Get(10).Length > 20);
        }
        [TestMethod]
        public void TestJokesGet11()
        {
            Assert.IsTrue(Jokes.Get(11).Length > 20);
        }
        [TestMethod]
        public void TestJokesGet12()
        {
            Assert.IsTrue(Jokes.Get(12).Length > 20);
        }
    }
}
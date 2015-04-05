using AmazingApp;
using NUnit.Framework;

namespace AmazingTests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Msg_IsHelloWorld()
        {
            Assert.AreEqual("Hello World", Program.Msg);
        }

        [Test]
        public void Pass()
        {
            Assert.Pass();
        }

        [Test]
        public void Fail()
        {
            Assert.Fail();
        }

}
}
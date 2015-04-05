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
            Assert.AreEqual("Hello Prod TeamCity", Program.Msg);
        }

        [Test]
        public void Pass()
        {
            Assert.Pass();
        }
    }
}
using NUnit.Framework;

namespace Kata.BankOCR.Test
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void TestsCanBeRun()
        {
           Program.Main(new [] { " " });
           Assert.Pass();
        }
    }
}

using System.IO;
using NUnit.Framework;

namespace Kata.BankOCR.Test
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void TestsCanBeRun()
        {
           var pathToUseCase = Path.Combine(TestContext.CurrentContext.TestDirectory, "../../../ExampleFiles/UseCase1.txt");

           Program.Main(new [] { pathToUseCase });
           Assert.Pass();
        }
    }
}

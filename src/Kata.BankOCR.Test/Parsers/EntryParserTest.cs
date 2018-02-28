using System.IO;
using Kata.BankOCR.Parsers;
using NUnit.Framework;

namespace Kata.BankOCR.Test.Parsers
{
   [TestFixture]
   public class EntryParserTest
   {
      [Test]
      public void UseCaseOneShouldHave11Entries()
      {
         var pathToUseCase = Path.Combine(TestContext.CurrentContext.TestDirectory, "../../../ExampleFiles/UseCase1.txt");
         Assert.That(EntryParser.Parse(pathToUseCase, 3), Has.Count.EqualTo(11));
      }
   }
}

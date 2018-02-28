using Kata.BankOCR.Representations;
using NUnit.Framework;

namespace Kata.BankOCR.Test.Representations
{
   [TestFixture]
   public class CharacterParserTest
   {
      [Test]
      public void ZeroAsRawInputYieldsZero()
      {
         var rawEntry =
            " _ " +
            "| |" +
            "|_|";

         Assert.That(CharacterParser.ToCharacter(rawEntry), Is.EqualTo('0'));
      }
   }
}

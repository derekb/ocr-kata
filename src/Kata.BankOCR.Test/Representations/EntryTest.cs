using System;
using System.IO;
using Kata.BankOCR.Parsers;
using Kata.BankOCR.Representations;
using NUnit.Framework;

namespace Kata.BankOCR.Test.Representations
{
   [TestFixture]
   public class EntryTest
   {
      [Test]
      public void EntryShouldParseToCharacters()
      {
         var rawEntry =
            new[]
            {
               " _  _  _  _  _  _  _  _  _ ",
               "| || || || || || || || || |",
               "|_||_||_||_||_||_||_||_||_|",
               "\r\n"
            };

         var entry = Entry.FromLines(rawEntry, 3);

         Assert.That(entry.AsText(), Is.EqualTo("000000000"));
      }
   }
}

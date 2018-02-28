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

      [Test]
      public void ParsedCharacterCountShouldMatchEntry()
      {
         var charWidth = 3;
         var rawEntry =
            new[]
            {
               " _  _  _  _  _  _  _  _  _ ",
               "| || || || || || || || || |",
               "|_||_||_||_||_||_||_||_||_|",
               "\r\n"
            };

         var entry = Entry.FromLines(rawEntry, charWidth);

         Assert.That(entry.AsText().Length, Is.EqualTo(rawEntry[0].Length / charWidth));
      }

      [Test]
      public void EntryCanParseAllTenDigits()
      {
         var charWidth = 3;
         var rawEntry =
            new[]
            {
               "    _  _     _  _  _  _  _  _ ",
               "  | _| _||_||_ |_   ||_||_|| |",
               "  ||_  _|  | _||_|  ||_| _||_|",
               "\r\n"
            };

         var entry = Entry.FromLines(rawEntry, charWidth);

         Assert.That(entry.AsText(), Is.EqualTo("1234567890"));
      }

      [Test]
      public void HasValidChecksum()
      {
         var charWidth = 3;
         var rawEntry =
            new[]
            {
               " _  _  _  _  _  _  _  _  _ ",
               "| || || || || || || || || |",
               "|_||_||_||_||_||_||_||_||_|",
               "\r\n"
            };

         var entry = Entry.FromLines(rawEntry, charWidth);

         Assert.That(entry.IsValid(), Is.True);
      }
      [Test]
      public void HasInvalidChecksum()
      {
         var charWidth = 3;
         var rawEntry =
            new[]
            {
               " _  _  _  _  _  _  _  _    ",
               "| || || || || || || || |  |",
               "|_||_||_||_||_||_||_||_|  |",
               "\r\n"
            };

         var entry = Entry.FromLines(rawEntry, charWidth);

         Assert.That(entry.IsValid(), Is.False);
      }

      [Test]
      public void IllegibleCharactersPrintAsQuestionMarks()
      {
         var charWidth = 3;
         var rawEntry =
            new[]
            {
               "    _  _  _  _  _  _     _ ",
               "|_||_|| || ||_   |  |  | _ ",
               "  | _||_||_||_|  |  |  | _|",
               "\r\n"
            };

         var entry = Entry.FromLines(rawEntry, charWidth);

         Assert.That(entry.AsText(), Is.EqualTo("49006771?"));
      }
   }
}

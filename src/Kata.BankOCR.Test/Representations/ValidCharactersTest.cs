﻿using Kata.BankOCR.Representations;
using NUnit.Framework;

namespace Kata.BankOCR.Test.Representations
{
   [TestFixture]
   public class ValidCharactersTest
   {
      [Test]
      public void ZeroAsRawInputYieldsZero()
      {
         var rawEntry =
            " _ " +
            "| |" +
            "|_|";

         Assert.That(ValidCharacters.ToCharacter(rawEntry), Is.EqualTo('0'));
      }
   }
}

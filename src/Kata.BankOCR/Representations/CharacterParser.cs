using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.BankOCR.Representations
{
   public class CharacterParser
   {
      private static readonly Dictionary<string, char> validCharacters = 
         new Dictionary<string, char>
         {
            { "   " +
              "  |" +
              "  |", '1'},
            { " _ " +
              " _|" +
              "|_ ", '2'},
            { " _ " +
              " _|" +
              " _|", '3'},
            { "   " +
              "|_|" +
              "  |", '4'},
            { " _ " +
              "|_ " +
              " _|", '5'},
            { " _ " +
              "|_ " +
              "|_|", '6'},
            { " _ " +
              "  |" +
              "  |", '7'},
            { " _ " +
              "|_|" +
              "|_|", '8'},
            { " _ " +
              "|_|" +
              " _|", '9'},
            { " _ " +
              "| |" +
              "|_|", '0'},

         };
      private static bool IsValidCharacter(string input)
      {
         return validCharacters.ContainsKey(input);
      }
      public static char ToCharacter(string input)
      {
         if (!IsValidCharacter(input))
            return '?';
         return validCharacters[input];
      }
   }
}

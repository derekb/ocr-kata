using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.BankOCR.Representations
{
   public class ValidCharacters
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
      public static bool IsValidCharacter(string input)
      {
         return validCharacters.ContainsKey(input);
      }
      public static char ToCharacter(string input)
      {
         return validCharacters[input];
      }
   }
}

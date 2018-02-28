using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.BankOCR.Representations
{
    public class Entry
    {
       private string[] lines;
       private readonly int _charWidth;

       private Entry(string[] lines, int charWidth)
       {
          this.lines = lines;
          _charWidth = charWidth;
       }

       public static Entry FromLines(string[] lines, int charWidth) => new Entry(lines, charWidth);

       public string AsText()
       {
          return new string(GetCharacters().ToArray());
       }

       public bool IsValid()
       {
          var chars = 
             this
                .AsText()
                .ToCharArray()
                .Select(x => Int32.Parse(x.ToString()))
                .ToArray();

          var checksum = 0;

          for (int i = 0; i < chars.Length; i++)
          {
             checksum += chars[i] * (chars.Length - i);
          }

          return checksum % 11 == 0;
       }

       private IEnumerable<char> GetCharacters()
       {
          for (int i = 0; i < lines[0].Length; i += _charWidth)
          {
             var rawCharacter = lines[0].Substring(i, _charWidth) +
                         lines[1].Substring(i, _charWidth) +
                         lines[2].Substring(i, _charWidth);
             if (!ValidCharacters.IsValidCharacter(rawCharacter))
             {
                yield return '?';
             }
             else
             {
                yield return ValidCharacters.ToCharacter(rawCharacter);
             }
          }
       }
    }
}

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

       private IEnumerable<char> GetCharacters()
       {
          for (int i = 0; i < lines[0].Length; i += _charWidth)
          {
             yield return
                ValidCharacters
                   .ToCharacter(
                      lines[0].Substring(i, _charWidth) +
                      lines[1].Substring(i, _charWidth) +
                      lines[2].Substring(i, _charWidth)
                      );
          }
       }
    }
}

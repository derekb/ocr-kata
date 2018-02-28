using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Kata.BankOCR.Representations;

namespace Kata.BankOCR.Parsers
{
    public class EntryParser
    {
       public static IList<Entry> Parse(string filePath, int charWidth)
       {
          return File
             .ReadAllLines(filePath)
             .Select((line, idx) => new { Line = line, Idx = idx })
             .GroupBy(item => item.Idx / 4)
             .Select(x => x.Select(y => y.Line).ToArray())
             .Select(x => Entry.FromLines(x, charWidth))
             .ToList();
      }
   }
}

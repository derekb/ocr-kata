using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kata.BankOCR
{
   public class Program
   {
      public static void Main(string[] args)
      {
         if (args.Length != 1)
            Console.WriteLine("Usage: ocr-kata </path/to/file>");

         var filePath = args.Single();

         var entries =
            File
               .ReadAllLines(filePath)
               .Select((line, idx) => new {Line = line, Idx = idx})
               .GroupBy(item => item.Idx / 4)
               .Select(x => x.Select(y => y.Line).ToArray());
      }
   }
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Kata.BankOCR.Parsers;
using Kata.BankOCR.Representations;

namespace Kata.BankOCR
{
   public class Program
   {
      public static void Main(string[] args)
      {
         if (args.Length != 1)
            Console.WriteLine("Usage: ocr-kata </path/to/file>");

         var filePath = args.Single();

         var entries = EntryParser.Parse(filePath, 3);

         foreach(var entry in entries)
            Console.WriteLine(PrintEntry(entry));
      }

      private static string PrintEntry(Entry entry)
      {
         var accountNumber = entry.AsText();
         var illegible = accountNumber.Contains("?") ? " ILL" : String.Empty;
         return $"{accountNumber}{illegible}";
      }
   }
}

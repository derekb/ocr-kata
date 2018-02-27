using System;

namespace Kata.BankOCR
{
   public class Program
   {
      public static void Main(string[] args)
      {
         if (args.Length != 1)
            Console.WriteLine("Usage: ocr-kata </path/to/file>");
      }
   }
}

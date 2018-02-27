namespace Kata.BankOCR.Representations
{
    public class Entry
    {
       private Entry () { }

       public static Entry FromLines(string[] lines) => new Entry();
    }
}

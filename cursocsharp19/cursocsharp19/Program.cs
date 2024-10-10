public delegate void PrintDelegate(string message);

class Printer
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main()
    {
        Printer printer = new Printer();
        PrintDelegate printDel = new PrintDelegate(printer.Print);

        printDel("Hello, using delegate!");  
    }
}

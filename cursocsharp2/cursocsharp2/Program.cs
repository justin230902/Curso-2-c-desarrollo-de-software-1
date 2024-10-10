using System;
class Program
{
    static void Main(string[] args)
    {
        int x=5; int y=5;
        Console.WriteLine(x+y);

        Console.WriteLine("cual es su nombre");
        Console.Write("escribe tu primer nombre");
        string minombre;
        minombre = Console.ReadLine();

        string apellido;
        Console.WriteLine("escriba su apellido");
        apellido = Console.ReadLine();
        Console.WriteLine("este es su nombre completo"+minombre+" "+apellido); 
    }
}
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("giveaway");
        Console.WriteLine("Elije un numero: 1, 2, 3");
        string rifa = Console.ReadLine();

        if (rifa == "1")
        {
            Console.WriteLine("Ganaste xd ");
        }
        else if (rifa == "2")
        {
            Console.WriteLine("Ganaste un carro");
        }
        else if (rifa == "3")
        {
            Console.WriteLine("Ganaste un barco");
        }
        else
        {
            Console.WriteLine("valor incorrecto");
        }
    }
}

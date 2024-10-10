using System;

    class program
{
    static void main(string[] args)
    {
        DateTime fecha = DateTime.Now;
       // Console.WriteLine(fecha.ToString());
        Console.WriteLine(fecha.ToShortDateString());
        Console.WriteLine(fecha.AddDays(3).ToLongDateString());
        DateTime fecha2 = new DateTime(23,9,2002);
        TimeSpan edad=DateTime.Now.Subtract(fecha2);
        Console.WriteLine(edad.TotalDays);
    }
}

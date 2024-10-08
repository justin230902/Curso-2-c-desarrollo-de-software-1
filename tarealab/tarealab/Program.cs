using System;
//PROGRAMAS (ENTRADA, PROCESO Y SALIDA)
class Program
{
    static void Main()
    {
        //PUNTO #1
        Console.WriteLine("-> 1. Muestre su nombre completo por pantalla<-\n");
        string nombre = "Justin Jimenez";

        Console.WriteLine("Mi nombre es: " + nombre);
        
        Console.WriteLine();
        //PUNTO #2
        Console.WriteLine("-> 2. Muestre por pantalla de manera separadas sus nombres y apellidos<-\n");
        string nombresolo = "Justin";
        Console.WriteLine();
        string apellidosolo = "Jimenez";

        Console.WriteLine("Nombre:" + nombresolo);
        Console.WriteLine("Apellido:" + apellidosolo);

        Console.WriteLine();
        //PUNTO #3
        Console.WriteLine("-> 3. Pregunte y capture su nombre y muestre por pantalla un saludo personalizado<-\n");
        Console.Write("Cual es su nombre? \n");
        string saludo=(Console.ReadLine());
        Console.WriteLine("Hola! " + saludo+ " Como estas?");

        Console.WriteLine();
        //punto #4
        Console.WriteLine("-> 4. Capture dos números y muestre por pantalla la multiplicación dichos números<-\n");
        Console.Write("Ingrese el primer numero:");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo numero:");
        int num2 = int.Parse(Console.ReadLine());
        int result= (num1*num2);
        Console.WriteLine();
        Console.WriteLine("la respuesta es: " + result);
        Console.WriteLine();
        //PUNTO #5
        Console.WriteLine("-> 5. Pida 3 números y muestre por pantalla el resultado de la suma del primero y el tercero divido entre el segundo<-\n");
        Console.WriteLine("Ingrese el primer numero: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        float numero2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer numero: ");
        int numero3 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("El resultado es= " + (numero1 + numero3) / numero2);
        
        Console.WriteLine();
        //PUNTO #6
        Console.WriteLine("-> 6. Pida 5 números muestre pantalla la sumatoria y el promedio<-\n");
        Console.WriteLine("Introduzca el numero 1: ");
        float nume1= float.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el numero 2: ");
        float nume2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el numero 3: ");
        float nume3 = float.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el numero 4: ");
        float nume4 = float.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el numero 5: ");
        float nume5 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("El resultado de la sumatoria es: "+ (nume1 + nume2 + nume3 + nume4 + nume5) );
        Console.WriteLine("El promedio de las sumatoria es: " + (nume1 + nume2 + nume3 + nume4 + nume5)/5);

        Console.WriteLine();
        //PUNTO #7
        Console.WriteLine("-> 7. Muestre por pantalla la tabla del 12 del 1 al 12.<-\n");

        int tabla = 12;
        for (int i = 1; i <= 12; i++)
        {
            int resultadotabla = tabla * i;
            Console.WriteLine(tabla + "x" + i + "= " + resultadotabla);
        }
        Console.ReadKey();
    }
    
}

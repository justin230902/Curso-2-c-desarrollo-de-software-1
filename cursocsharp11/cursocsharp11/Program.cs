class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Speak();  
        myDog.Bark();   
    }
}

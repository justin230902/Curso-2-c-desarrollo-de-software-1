interface IAnimal
{
    void Speak();
}

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program
{
    static void Main()
    {
        IAnimal dog = new Dog();
        IAnimal cat = new Cat();

        dog.Speak();  
        cat.Speak();  
    }
}

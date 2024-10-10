List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

var evenNumbers = from number in numbers
                  where number % 2 == 0
                  select number;

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);  
}

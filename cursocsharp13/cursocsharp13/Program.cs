try
{
    int number = int.Parse("abc");
}
catch (FormatException ex)
{
    Console.WriteLine("Invalid number format: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}

using System;

class Button
{
    public event Action OnClick;

    public void Click()
    {
        if (OnClick != null)
        {
            OnClick();
        }
    }
}

class Program
{
    static void Main()
    {
        Button button = new Button();
        button.OnClick += () => Console.WriteLine("Button clicked!");
        button.Click(); 
    }
}

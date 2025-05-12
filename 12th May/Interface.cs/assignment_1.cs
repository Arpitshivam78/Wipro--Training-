interface ICalculator
{
    void Calculate();
}

class Add : ICalculator
{
    public void Calculate()
    {
        Console.WriteLine("Addition");
    }
}

class Subtract : ICalculator
{
    public void Calculate()
    {
        Console.WriteLine("Subtraction");
    }
}

class Multiply : ICalculator
{
    public void Calculate()
    {
        Console.WriteLine("Multiplication");
    }
}

class Divide : ICalculator
{
    public void Calculate()
    {
        Console.WriteLine("Division");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICalculator calculator;

        calculator = new Add();
        calculator.Calculate();

        calculator = new Subtract();
        calculator.Calculate();

        calculator = new Multiply();
        calculator.Calculate();

        calculator = new Divide();
        calculator.Calculate();
    }
}
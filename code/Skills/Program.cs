// See https://aka.ms/new-console-template for more information
void Calculate()
{
    Console.WriteLine("Enter the first number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the operation");
    string? input = Console.ReadLine();
    string operation = input ?? string.Empty;
    if (operation == "+")
    {
        Console.WriteLine(num1 + num2);
    }
    else if (operation == "-")
    {
        Console.WriteLine(num1 - num2);
    }
    else if (operation == "*")
    {
        Console.WriteLine(num1 * num2);
    }
    else if (operation == "/")
    {
        Console.WriteLine(num1 / num2);
    }
    else
    {
        Console.WriteLine("Invalid operation");
    }
}

Calculate();
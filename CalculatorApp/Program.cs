using System;

class calculatorApp
{
    static void Main()
    {
        Console.WriteLine("-----------------");
        Console.WriteLine("Start Calculating");
        Console.WriteLine("-----------------");
        Console.WriteLine("Type 'c' as an operation to clear");
        Console.WriteLine("-----------------");

        double num1 = 0;
        double num2;
        double result = 0;
        int whileTrigger = 0;

        Console.Write("Enter first number: ");
        num1 = double.Parse(Console.ReadLine());
        string operatn = "";
        while (whileTrigger == 0)
        {

            Console.Write("Enter Operation: ");
            operatn = (Console.ReadLine());

            switch (operatn)
            {
                case "+":
                    Console.Write("Enter second Number: ");
                    num2 = double.Parse(Console.ReadLine());
                    result = num1 + num2;
                    Console.WriteLine($"{num1} {operatn} {num2} = {result}");
                    num1 = result;
                    break;

                case "-":
                    Console.Write("Enter second Number: ");
                    num2 = double.Parse(Console.ReadLine());
                    result = num1 - num2;
                    Console.WriteLine($"{num1} {operatn} {num2} = {result}");
                    num1 = result;
                    break;

                case "*":
                    Console.Write("Enter second Number: ");
                    num2 = double.Parse(Console.ReadLine());
                    result = num1 * num2;
                    Console.WriteLine($"{num1} {operatn} {num2} = {result}");
                    num1 = result;
                    break;

                case "/":
                    Console.Write("Enter second Number: ");
                    num2 = double.Parse(Console.ReadLine());
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1} {operatn} {num2} = {result}");
                        num1 = result;
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }    
                    break;

                case "c":

                    num1 = 0;
                    Console.WriteLine(num1);
                    Console.Write("Enter first number: ");
                    num1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter Operation: ");
                    operatn = (Console.ReadLine());

                    if (operatn == "+")
                    {
                        Console.Write("Enter second Number: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 + num2;
                        Console.WriteLine($"{num1} {operatn} {num2} = {result}");
                        num1 = result;
                    }
                    else if (operatn == "-")
                    {
                        Console.Write("Enter second Number: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 - num2;
                        Console.WriteLine($"{num1} {operatn} {num2} = {result}");
                        num1 = result;
                    }
                    else if (operatn == "*")
                    {
                        Console.Write("Enter second Number: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 * num2;
                        Console.WriteLine($"{num1} {operatn} {num2} = {result}");
                        num1 = result;
                    }
                    else if (operatn == "/")
                    {
                        Console.Write("Enter second Number: ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"{num1} {operatn} {num2} = {result}");
                            num1 = result;
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }

    }
}
using System;

namespace dars_case_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = a + b;
                    Console.WriteLine(result);
                    break;
                case "-" :
                    result = a - b;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = a * b;
                    Console.WriteLine(result);
                    break;
                case "/":
                    if (a >= 0 && b != 0)
                    {
                        result = a / b;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide {0} by zero", operation);
                    }
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
        }
    }
}
using System;
namespace Task1
{
    internal class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            int Add(int x, int y) => x + y;
            int Sub(int x, int y) => x - y;
            int Mul(int x, int y) => x * y;
            int Div(int x, int y) => y == 0 ? 0:x/y;

            Console.WriteLine("Введiть перше число: ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть друге число: ");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть дiю (+,-,*,/): ");
            string operation=Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Operation operation1 = Add;                    
                    Console.WriteLine($"Результат: {operation1(num1, num2)}");
                    break;
                case "-":
                    Operation operation2 = Sub;
                    Console.WriteLine($"Результат: {operation2(num1, num2)}");
                    break;
                case "*":
                    Operation operation3 = Mul;
                    Console.WriteLine($"Результат: {operation3(num1, num2)}");
                    break;
                case "/":
                    Operation operation4 = Div;
                    Console.WriteLine($"Результат: {operation4(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Помилка");
                    break;


            }
        }
    }
}
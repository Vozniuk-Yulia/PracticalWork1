using System;
namespace Task3
{
    internal class Program
    {
        delegate int Operation(int num1, int num2, int num3);
        static void Main(string[] args)
        {
            int count = 3;
            Operation operation = delegate (int num1, int num2, int num3)
            {
                return (num1 + num2 + num3) / count;
            };
            Console.WriteLine("Введiть перше число: ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть друге число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть третє число: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            double result = operation(num1, num2, num3);
            Console.WriteLine($"Результат: {result}");
        }
    }
}
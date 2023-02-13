using System;
namespace Task2
{
    internal class Program
    {
        delegate int Element();
        delegate double Array(Element[] elements);
        static int GetRandom()
        {
            Random random = new Random();
            int number=random.Next(1,50);
            Console.WriteLine(number);
            return number;
        }
        static void Main(string[] args)
        {
            
            Array array = delegate (Element[] elements)
            {
                int sum = 0;
                for (int i = 0; i < elements.Length; i++)
                {
                    sum += elements[i]();
                }
                return sum / elements.Length;
            };
            Console.WriteLine("Введiть кiлькiсть елементiв масива: ");
            int count=Convert.ToInt32(Console.ReadLine());
            Element[] elements = new Element[count];
            for(int i = 0;i < elements.Length;i++)
            {
                elements[i] = () => new Element(GetRandom)();
            }
            Console.WriteLine($"Середнє значення: {array(elements)}");
            
        }
    }
}
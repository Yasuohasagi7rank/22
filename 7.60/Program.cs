using System;

namespace _7._60
{
    class Program
    {
        static int Metod(string Name, int Min = int.MinValue, int Max = int.MaxValue)
        {
            Console.WriteLine($"Введите {Name}:");
            int Num;
            while (!(int.TryParse(Console.ReadLine(), out Num) && Num >= Min && Num <= Max)) Console.WriteLine($"Неверно {Name}:");
            return Num;
        }
        static void Main(string[] args)
        {
            Random R = new Random();
            int a = Metod("количество квартир ");
            int b = 0;
            int c = 0;
            for (int i = 1; i <= a; i++)
            {
                int temp = R.Next(1, 10);
                if (temp >= c) { c = temp; b = i; }
                Console.Write(temp + " ");
            }
            Console.WriteLine("\n" + b);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

﻿namespace SortSimples_1042
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);

            int d = a;
            int e = b;
            int f = c;

            if(d>e && d > f)
            {
                int aux = d;
                d = f;
                f = aux;
            }else if(e>d && e > f)
            {
                int aux = e;
                e = f;
                f = aux;
            }
            if (d > e)
            {
                int aux = d;    
                d = e;
                e = aux;
            }

            Console.WriteLine($"{d}\n{e}\n{f}\n\n{a}\n{b}\n{c}");

        }
    }
}
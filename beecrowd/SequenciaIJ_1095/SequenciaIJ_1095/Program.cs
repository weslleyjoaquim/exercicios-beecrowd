using System;

namespace SequenciaIJ_1095
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int j = 60;
            int x = 1;
            Console.WriteLine($"I={x} J={j}");
            for (int i = 0; i < 12; i++)
            {
                j = j-5;
                x = x + 3;
                Console.WriteLine($"I={x} J={j}");
            }
        }
    }
}
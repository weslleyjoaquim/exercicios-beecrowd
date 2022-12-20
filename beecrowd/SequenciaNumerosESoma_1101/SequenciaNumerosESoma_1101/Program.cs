using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace SequenciaNumerosESoma_1101
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Leia um conjunto não determinado de pares de valores M e N(parar quando algum dos valores for menor ou igual a zero).
            //Para cada par lido, mostre a sequência do menor até o maior e a soma dos inteiros consecutivos entre eles(incluindo o N e M).

            string[] valores = Console.ReadLine().Split(' ');
            int valorM = int.Parse(valores[0]);
            int valorN = int.Parse(valores[1]);
            int valorMaior, valorMenor,soma=0;

           if (valorM > valorN)
            {
                valorMaior = valorM;
                valorMenor = valorN;

            }
            else
            {
                valorMaior = valorN;
                valorMenor = valorM;
            }

            for(int i = valorMenor;i<=valorMaior;i++)
            {
                if(valorMenor == 0)
                {
                    break;
                }
               Console.Write($"{i} ");
               soma += i;
               
            }
            if (soma == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine($"Sum={soma}");
            }
            
            
        }
    }
}
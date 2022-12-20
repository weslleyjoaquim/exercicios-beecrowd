namespace MultiplosDe13_1132
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());


            if (start > end)
            {
                int aux = start;
                start = end;
                end = aux;
            }

            int soma = 0;

            for(int i = start; i <= end; i++) 
            {
                if (i % 13 != 0)        //Quando tenho apenas uma condição, não é necessário inserir {} no if.
                    soma += i;
            }

            Console.WriteLine(soma);




            /*int resto = start % 13;

            if(resto != 0)
            {
                int falta = 13 - resto;
                start += falta;
            }

            for(int i = start; i <= end; i+=13) 
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
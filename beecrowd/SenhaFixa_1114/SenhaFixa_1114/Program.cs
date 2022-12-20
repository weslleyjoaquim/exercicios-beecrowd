namespace SenhaFixa_1114
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string senha = Console.ReadLine();
            string senhaCorreta = "2002";

            while (senha != senhaCorreta)
            {
                Console.WriteLine("Senha Invalida");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
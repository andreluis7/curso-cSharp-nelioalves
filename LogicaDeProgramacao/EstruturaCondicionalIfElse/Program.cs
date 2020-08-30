using System;
using System.Security.Cryptography.X509Certificates;

namespace EstruturaCondicionalIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("É par");
            } else
            {
                Console.WriteLine("É impar");
            }

            Console.WriteLine("***********************");

            Console.WriteLine("Qual a hora atual: ");
            int hora = int.Parse(Console.ReadLine());

            if( hora < 12)
            {
                Console.WriteLine("Bom dia");
            } else if (hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }
        }
    }
}

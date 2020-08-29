using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom Dia!");
            Console.WriteLine("Boa Tarde!");
            Console.WriteLine("Boa Noite!");
            Console.WriteLine("**************************************");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);

            // duas casas apos a virgula
            Console.WriteLine(saldo.ToString("F2"));

            // quatro casas apos a virgula
            Console.WriteLine(saldo.ToString("F4"));

            //Sair com ponto em vez da virgula
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais.", nome, idade, saldo);

            // mesma frase porem com 2 casas apos a virgula
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);

            // mesma frase porem com passagem de parametros diferente
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");

            // mesma frase porem com passagem de parametros diferente
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais.");

            // mesma frase porem com ponto ao inves de virgula
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
        }
    }
}

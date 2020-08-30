using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura (na mesma linha): ");
            string[] vetor = Console.ReadLine().Split(' ');
            string ultimoNome = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2]);

            Console.WriteLine(" ******************** ");
            Console.WriteLine("Você digitou: ");
            Console.WriteLine("Nome completo: " + nome);
            Console.WriteLine("Quantidade de quartos: " + quartos);
            Console.WriteLine("Preço do produto: " + produto);
            Console.WriteLine("Último nome: " + ultimoNome + ", Idade: " + idade + ", Altura: " + altura);


        }
    }
}

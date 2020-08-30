using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"Produtos \n{produto1}, cujo o preço é ${preco1:F2}\n{produto2}, " +
                $"cujo o preço é ${preco2:F2}\n\nRegistro: {idade} de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine($"\nMedida com oito casas decimais: {medida:F8}");

            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");

            Console.WriteLine("Separator decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

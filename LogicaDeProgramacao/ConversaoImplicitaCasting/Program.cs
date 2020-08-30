using System;

namespace ConversaoImplicitaCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            float b;

            a = 5.1;

            b = (float) a;

            Console.WriteLine(b);

            Console.WriteLine("*************************");

            int num1 = 5;
            int num2 = 2;

            // nesse caso é necessário fazer o cast pois o compilador por ser divisao de 
            // dois numeros inteiros entende que o resultado e inteiro
            double resultado = (double) num1 / num2;

            Console.WriteLine(resultado);
        }
    }
}

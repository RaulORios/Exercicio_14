using System;

namespace Exercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*********     Exercicio 14     *********");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            int numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if (numero < 10)
            {
                Console.WriteLine($"O número {numero} é MENOR que 10.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é MAIOR que 10.");
            }

            Console.ReadKey();

        }
    }
}

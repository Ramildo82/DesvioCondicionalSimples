using System;

namespace IdadeJogador
{
    class Program
    {
        static void Main(string[] args)
        {
            byte idade;

            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToByte(Console.ReadLine());

            if (idade >= 12)
            {
                Console.WriteLine("Você pode jogar!");
            }

        }
    }
}

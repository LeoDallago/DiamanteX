﻿namespace DiamanteX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diamante X");

            Console.WriteLine("Por favor, Informe um numero");
            int numeroValor = Convert.ToInt32(Console.ReadLine());

            string valorX = "X ";
            int contador = 0;

            if (numeroValor % 2 == 0)
            {
                Console.WriteLine("Numero invalido, Por favor informe um numero IMPAR");
            }

            else
            {

                while (contador <= numeroValor)
                {

                    for (int i = contador; i < numeroValor - 1 / 2; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine(valorX);
                    valorX = valorX + "X X ";

                    contador = contador + 2;

                }

            }

            Console.ReadLine();
        }
    }
}

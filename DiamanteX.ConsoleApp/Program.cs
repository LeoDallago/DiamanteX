namespace DiamanteX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diamante X");

            Console.WriteLine("Por favor, Informe um numero");
            int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

            int quantidadeDeX = 1;
            int contador = 0;

            if (tamanhoDiamante % 2 == 0)
            {
                Console.WriteLine("Numero invalido, Por favor informe um numero IMPAR");
            }

            else
            {

                for (int linha = 0; linha < (tamanhoDiamante - 1) / 2; linha++)
                {
                    FazLinha(tamanhoDiamante, quantidadeDeX, contador);
                    contador++;
                    quantidadeDeX += 2;

                    Console.WriteLine();

                }

                for (int linha = 0; linha <= (tamanhoDiamante - 1) / 2; linha++)
                {
                    FazLinha(tamanhoDiamante, quantidadeDeX, contador);
                    contador--;
                    quantidadeDeX -= 2;

                    Console.WriteLine();
                }


            }

            Console.ReadLine();
        }

        private static void FazLinha(int tamanhoDiamante, int quantidadeDeX, int contador)
        {
            for (int espaco = contador; espaco < (tamanhoDiamante - 1) / 2; espaco++)
            {
                Console.Write(" ");
            }


            for (int X = 0; X < quantidadeDeX; X++)
            {
                Console.Write("X");
            }
        }
    }
}

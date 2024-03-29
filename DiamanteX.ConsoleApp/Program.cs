namespace DiamanteX.ConsoleApp
{
    internal class Program
    {
        static string alphabeto = "abcdefghijklmnopqrstuvwxyz";

        static char[] alphabetoArray = alphabeto.ToCharArray();

        static void Main(string[] args)
        {
            Console.WriteLine("Diamante X");


            Console.WriteLine("Por favor, Informe um numero");
            char tamanhoDiamante = Convert.ToChar(Console.ReadLine());

            int tamanhoNumerado = Array.IndexOf(alphabetoArray, tamanhoDiamante);
            /*  Console.WriteLine("Por favor, informe o estilo do diamante");
             string estilo = Console.ReadLine(); */

            int quantidadeDeX = 1;
            int contador = 0;


            for (int linha = 0; linha < tamanhoNumerado; linha++)
            {
                FazLinha(tamanhoNumerado, quantidadeDeX, contador);
                contador++;
                quantidadeDeX += 2;

                Console.WriteLine();

            }

            for (int linha = 0; linha <= tamanhoNumerado - 1; linha++)
            {
                FazLinha(tamanhoNumerado, quantidadeDeX, contador);
                contador--;
                quantidadeDeX -= 2;

                Console.WriteLine();
            }

            Console.ReadLine();

        }



        private static void FazLinha(int tamanhoNumerado, int quantidadeDeX, int contador)
        {
            for (int espaco = contador; espaco < tamanhoNumerado; espaco++)
            {
                Console.Write(" ");
            }



            for (int X = 0; X < quantidadeDeX; X++)
            {
                Console.Write(alphabetoArray[contador]);
            }


        }
    }
}

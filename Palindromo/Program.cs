using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##============================= É PALÍNDROMO? =============================## \n \n");
            Console.WriteLine("Palíndromo é toda palavra que pode ser lida de trás pra frente e que independente da direção, mantém o seu sentido.\nSequências numéricas também são válidas!\n \n");
            Console.WriteLine("Digite uma palavra ou sequência numérica (sem espaços):");

            string entrada = Console.ReadLine().ToLower();
            string substituicao = "";
            string pattern = @"[^0-9a-zA-Z]+";
            Regex rgx = new Regex(pattern);
            string entradas = rgx.Replace(entrada, substituicao);

            char[] reverso = entradas.ToCharArray();
            Array.Reverse(reverso);
            string entradaRevertida = new string(reverso);

            ConsoleColor foreground = Console.ForegroundColor;


            if (entrada != entradas || entrada == "")
            {
                Console.WriteLine("Não é permitido caracteres especiais ou campo vazio e espaços.");
            }
            else
            {
                if (entrada.Equals(entradaRevertida))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(entrada + " é palíndromo!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(entrada + " não é palíndromo.");
                }
            }
            Console.ResetColor();
            Console.WriteLine("\nAperte Enter 2x para sair.");
            Console.ReadKey();
        }
    }
}

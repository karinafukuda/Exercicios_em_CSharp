using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        //alterar o caminho do arquivo txt
        string[] lines = File.ReadAllLines(@"C:\arquivoLeitura.txt");

        System.Console.WriteLine("Lendo conteúdo e gravando retorno...");
        //criar um caminho para novo arquivo 
        StreamWriter sw = new StreamWriter(@"C:\frasesAnalisadas.txt");


        foreach (string line in lines)
        {
            
            char[] reverso = line.ToCharArray();
            Array.Reverse(reverso);
            string linhaReversa = new(reverso);

            string Frase;

            string NovaLinhaReversa = Regex.Replace(linhaReversa, @"\s", "");
            string NovaLinha = Regex.Replace(line, @"\s", "");

            if (NovaLinha.ToLower() != NovaLinhaReversa.ToLower())
            {
                Frase = ("Não é palíndromo : " + line);
                sw.WriteLine(Frase);
            }
            else
            {
                Frase = ("É palíndromo : " + line);
                sw.WriteLine(Frase);
            }

        }

        sw.Close();
    }
}
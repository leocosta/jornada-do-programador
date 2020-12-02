using System;

namespace ManipulandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // acessando um índice da string
            string frase = "Minha frase favorita";
            char letra = frase[1];
            Console.WriteLine("Letra: {0}", letra);
            
            // percorrendo o array de chars
            foreach (char l in frase) 
            {
                Console.WriteLine(l);
            }

            // total de caracteres da string
            Console.WriteLine("Total de caracteres: {0}", frase.Length);

            Console.Clear();

            // substituição de sequências de caracteres
            Console.WriteLine("Replace: {0}", frase.Replace("minha", "Nossa", StringComparison.InvariantCultureIgnoreCase));

            // maiúsculos e minúsculos
            Console.WriteLine("ToUpper: {0}", frase.ToUpper());
            Console.WriteLine("ToLower: {0}", frase.ToLower());

            // removendo espaços em branco
            string fraseComEspacos = "    frase com espaços       ";
            Console.WriteLine("Com espaços: |{0}|", fraseComEspacos);
            Console.WriteLine("Sem espaços: |{0}|", fraseComEspacos.Trim());

            // sequência contida
            Console.WriteLine("Contains: {0}", frase.Contains("MInhA", StringComparison.InvariantCultureIgnoreCase));

            // posição inicial de uma sequência de caracteres
            Console.WriteLine("IndexOf (encontrado): {0}", frase.IndexOf("frase"));
            Console.WriteLine("IndexOf (não encontrado): {0}", frase.IndexOf("meu"));

            // array delimitado por uma sequência de um ou mais caracteres
            string[] palavras = frase.Split(' ');
            for (int i = 0; i < palavras.Length; i++)
            {
                Console.WriteLine("Palavra {0}: {1}", i, palavras[i]);
            }

            // unindo uma sequência de um ou mais caracteres
            string palavrasUnidas = string.Join(" . ", palavras);
            Console.WriteLine("Palavras unidas: {0}", palavrasUnidas);

            string nome = "Leonardo";
            string sobrenome = "Costa";

            Console.WriteLine($"Meu nome é: { nome } { sobrenome }");
        }
    }
}

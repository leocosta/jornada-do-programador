using System;

namespace TrabalhandoComArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            // Parte1_Vetores();
            Parte2_Matrizes();
        }

        static void Parte1_Vetores()
        {
            Console.Write("Quantidade de pessoas? ");
            int.TryParse(Console.ReadLine(), out var totalPessoas);

            string[] pessoas = new string[totalPessoas];
            for (int i = 0; i < totalPessoas; i++)
            {
                Console.Write("{0}o. nome: ", i + 1);
                string nome = Console.ReadLine();

                pessoas[i] = nome;
            }

            Console.Clear();

            Console.WriteLine("Lista de Amigos");
            Console.WriteLine("===============");

            foreach(string pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    
        static void Parte2_Matrizes()
        {
            Console.Write("Quantidade de pessoas? ");
            int.TryParse(Console.ReadLine(), out var totalPessoas);

            string[,] pessoas = new string[totalPessoas, 2];
            for (int i = 0; i < totalPessoas; i++)
            {
                Console.Write("{0}o. nome: ", i + 1);
                string nome = Console.ReadLine();

                Console.Write("{0}o. e-mail: ", i + 1);
                string email = Console.ReadLine();

                pessoas[i,0] = nome;
                pessoas[i,1] = email;
            }

            Console.Clear();

            Console.WriteLine("Lista de amigos");
            Console.WriteLine("===============");

            for (int i = 0; i < pessoas.GetLength(0); i++)
            {
                for (int j = 0; j < pessoas.GetLength(1); j++)
                {
                    Console.WriteLine("({0},{1}) {2}", i, j, pessoas[i, j]);
                }
            }

            Console.WriteLine("Total de elementos: {0}", pessoas.GetLength(0));
            Console.WriteLine("Total de atributos: {0}", pessoas.GetLength(1));
        }
    }
}

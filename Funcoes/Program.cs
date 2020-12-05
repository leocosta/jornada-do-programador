using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 1, 8, 3, 6, 2, 5, 9, 13, 0, 2 };
            int valorMaximo = ValorMaximo(valores);

            Console.WriteLine($"O valor máximo do array é: { valorMaximo }");

            int[] valores2 = { 0, 2, 3, 4, 9, 25, 89, 4, 100 };
            int valorMaximo2 = ValorMaximo(valores2);

            Console.WriteLine($"O 2o. valor máximo do array é: { valorMaximo2 }");
        }

        static int ValorMaximo(int[] numeros)
        {
            int valorMaximo = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > valorMaximo)
                {
                    valorMaximo = numeros[i];
                }
            }

            return valorMaximo;
        }
    }
}

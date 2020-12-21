using System;
using System.Linq;

namespace Funcoes
{
    class Program
    {
        static int valor;
        
        static void Main(string[] args)
        {
            Console.Clear();
            
            // Parte1();
            Parte2();
        }

        static void Parte2()
        {
            // array de parâmetros
            int soma = SomaValores(1, 5, 2, 9, 8, 10, 20, 30);
            Console.WriteLine($"Soma dos Valores = { soma }");
            Separador();

            // parâmetro por valor
            int numero = 5;
            Console.WriteLine($"Número = { numero }");
            MostrarDobroPorValor(numero);
            Console.WriteLine($"Número = { numero }");
            Separador();

            // parâmetro por referência
            Console.WriteLine($"Número = { numero }");
            MostrarDobroPorReferencia(ref numero);
            Console.WriteLine($"Número = { numero }");
            Separador();

            // parâmetro out
            int[] valores = { 1, 2, 3, 5, 6, 9, 13, 20 };
            int valorMaximo = ValorMaximoComIndice(valores, out int indice);
            Console.WriteLine($"Valor máximo = { valorMaximo }, Índice = { indice }");
            Separador();

            // argumentos nomeados e opcionais
            double valorComDesconto = CalcularValorComDesconto(100);
            Console.WriteLine($"Valor com desconto = { valorComDesconto }");
            valorComDesconto = CalcularValorComDesconto(desconto: .2, valor: 100);
            Console.WriteLine($"Valor com desconto = { valorComDesconto }");
            Separador();

            // tuplas
            int[] numeros = { 1, 2, 4, 6, 9, 14 };
            var resultado = ObterMinMax(numeros);
            Console.WriteLine($"Valor máximo é { resultado.max }, valor mínimo é { resultado.min }");
            Separador();

            // escopo de variáveis
            valor = 10;
            Console.WriteLine($"Valor = { valor }");
            MostrarDobroVariavelCompartilhada();
            Console.WriteLine($"Valor = { valor }");
            Separador();
        }

        static void MostrarDobroVariavelCompartilhada()
        {
            valor *= 2;
            Console.WriteLine($"Dobro do valor = { valor }");
        }

        static (int max, int min) ObterMinMax(int[] numeros)
        {
            return (Enumerable.Max(numeros), Enumerable.Min(numeros));
        }

        static double CalcularValorComDesconto(double valor, double desconto = .1)
        {
            double valorComDesconto = valor * (1 - desconto);

            return valorComDesconto;
        }

        static int ValorMaximoComIndice(int[] valores, out int indice)
        {
            int valorMaximo = valores[0];
            indice = 0;
            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i] > valorMaximo)
                {
                    valorMaximo = valores[i];
                    indice = i;
                }
            }

            return valorMaximo;
        }

        static void MostrarDobroPorValor(int numero)
        {
            numero *= 2;
            Console.WriteLine($"Dobro do valor = { numero }");
        }

        static void MostrarDobroPorReferencia(ref int numero)
        {
            numero *= 2;
            Console.WriteLine($"Dobro do valor = { numero }");
        }

        static int SomaValores(params int[] valores)
        {
            int soma = 0;
            foreach (var valor in valores)
            {
                soma += valor;
            }

            return soma;
        }

        static void Separador()
        {
            Console.WriteLine(new String('-', 30));
        }

        static void Parte1()
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

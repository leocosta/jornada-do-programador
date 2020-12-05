using System;

namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            VariaveisETipos();
        }

        static void VariaveisETipos() {
            // declaração com tipo explícito
            string nome;

            string @namespace = "Algum valor";
            double _valorTotal = 200;
            
            nome = "Leonardo";

            string apelido = "Leo";

            // declaração com tipo implícito (inferência de tipo)
            var outroNome = "Maria"; 
            var numeroInt = 200;
            var numeroLong = 200L;
            var numeroDecimal = 200M;
            var numeroFloat = 200F;

            // não permitidos
            /*
            int 123var = 1;
            double $valor = 100;
            string nome da rua = "Rua Maria Augusta";
            string static  = 100;
            */

            /* Tipos */
            
            // bool

            bool souProgramador = true;
            Console.WriteLine("Sou programador? " + souProgramador);

            // a diferença é a capacidade de armazenamento

            // byte 

            byte idade = 30;
            
            Console.WriteLine("MinValue: " + byte.MinValue);
            Console.WriteLine("MaxValue: " + byte.MaxValue);

            sbyte temperatura = -7;

            Console.WriteLine("MinValue: " + sbyte.MinValue);
            Console.WriteLine("MaxValue: " + sbyte.MaxValue);

            // short

            short pontos = 100;
            
            Console.WriteLine("MinValue: " + short.MinValue);
            Console.WriteLine("MaxValue: " + short.MaxValue);

            // int

            int distancia = 5000;
            
            Console.WriteLine("MinValue: " + int.MinValue);
            Console.WriteLine("MaxValue: " + int.MaxValue);

            // ulong

            ulong habitantes = 8_000_000_000;
            
            Console.WriteLine("MinValue: " + ulong.MinValue);
            Console.WriteLine("MaxValue: " + ulong.MaxValue);

            // float

            float preco = 23.99F;
            
            Console.WriteLine("MinValue: " + float.MinValue);
            Console.WriteLine("MaxValue: " + float.MaxValue);

               // double

            double totalDoPedido = 23.99;
            
            Console.WriteLine("MinValue: " + double.MinValue);
            Console.WriteLine("MaxValue: " + double.MaxValue);

            // decimal

            decimal distanciaPlanetaria = 78_999_999_999_999_999_000_149_600_000.00m;
            decimal medidaSubatomico = 0.0000000000000000000000000000000000000000000000000000000000000000000000000000001m;
            
            Console.WriteLine("MinValue: " + decimal.MinValue);
            Console.WriteLine("MaxValue: " + decimal.MaxValue);

            /* Expressões */

            int valor1 = 10;
            int valor2 = 2;
            
            // Operadores matemáticos (binários)
            
            // Adição
            int adicao = valor1 + valor2;
            Console.WriteLine("O resultado da soma é: " + adicao);

            // Subtração
            int subtracao = valor1 - valor2;
            Console.WriteLine("O resultado da subtração é: " + subtracao);

            // Multiplicacao
            int multiplicacao = valor1 * valor2;
            Console.WriteLine("O resultado da multiplicação é: " + multiplicacao);

            // Divisão
            int divisao = valor1 / valor2;
            Console.WriteLine("O resultado da divisão é: " + divisao);

            // Resto da Divisão dividendo / divisor = quociente e resto
            int resto = valor1 % valor2;
            Console.WriteLine("O resto da divisão é: " + resto);

            // Misturando variáveis e valores literais
            int resultado =  6 * 10 / (valor1 + valor2);
            Console.WriteLine("O resultado da expressão é: " + resultado);

            // Operadores matemáticos (unários)

            resultado = +valor1;
            resultado = -valor1;
            resultado = ++valor1;
            resultado = --valor1;
            resultado = valor1++;
            resultado = valor1--;

            // Operadores de atribuição

            int total = 10;
            int valor = 5;

            total += valor;
            total -= valor;
            total *= valor;
            total /= valor;
            total %= valor;
        }
    }
}

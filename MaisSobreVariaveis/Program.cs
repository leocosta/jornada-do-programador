using System;

namespace MaisSobreVariaveis
{
    enum Orientacao : byte
    {
        Norte = 1,
        Sul = 2,
        Leste = 3,
        Oeste = 4
    }

    struct Rota 
    {
        public Orientacao Direcao;
        public double Distancia;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            // ConversaoDeTipos();
            // Enumeracoes();
            Estruturas();
        }

        static void Estruturas()
        {
            Rota rota;
            rota.Direcao = Orientacao.Norte;
            rota.Distancia = 10;

            Console.WriteLine("Minha rota é em direção ao {0} a uma distância de {1}km.", rota.Direcao, rota.Distancia);

            Rota[] rotas = new Rota[5];
            for (int i = 0; i < rotas.Length; i++)
            {
                Console.Write("Direção: ");
                Enum.TryParse(Console.ReadLine(), out Orientacao direcao);

                Console.Write("Distância: ");
                double.TryParse(Console.ReadLine(), out double distancia);

                rotas[i].Direcao = direcao;
                rotas[i].Distancia = distancia;
            }

            Console.Clear();
            Console.WriteLine("Rotas do trajeto");
            Console.WriteLine("================");

            for (int i = 0; i < rotas.Length; i++)
            {
                Console.WriteLine("Vá para {0} e dirija por {1}km.", rotas[i].Direcao, rotas[i].Distancia);
            }
        }

        static void Enumeracoes()
        {
            Orientacao orientacao = Orientacao.Norte;
            Console.WriteLine("Orientação: {0}", (byte)orientacao);

            Enum.TryParse("Leste", out Orientacao orientacaoConvertida);
            Console.WriteLine("Orientação convertida: {0}", (byte)orientacaoConvertida);
        }

        static void ConversaoDeTipos()
        {
            // conversão implícita
            int valor1 = 10;
            double valor2 = valor1;
            Console.WriteLine("valor2: {0}", valor2);

            byte valor3 = 200;
            long valor4 = valor3;
            Console.WriteLine("valor4: {0}", valor4);

            // conversão explícita
            double valor5 = 1.5d;
            float valor6 = (float)valor5;
            Console.WriteLine("valor6: {0}", valor6);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("notaTruncada: {0}", notaTruncada);

            // conversões explícitas usando comandos de conversão
            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();

            // int idadeInteiro = int.Parse(idadeString);
            // Console.WriteLine("idadeInteiro: {0}", idadeInteiro);

            // int idadeInteiro = Convert.ToInt32(idadeString);
            // Console.WriteLine("idadeInteiro: {0}", idadeInteiro);

            int.TryParse(idadeString, out var idadeInteiro);
            Console.WriteLine("idadeInteiro: {0}", idadeInteiro);
        }
    }
}

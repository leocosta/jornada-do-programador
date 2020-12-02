using System;

namespace ControleDeFluxo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // ControleDeFluxoParte1();
            
            // ControleDeFluxoParte2();

            ControleDeFluxoParte3();
        }

        static void ControleDeFluxoParte3() 
        {
            /*
            Console.Write("Qual é o saldo? ");
            double.TryParse(Console.ReadLine(), out var saldo);

            Console.Write("Taxa de juros anual (%)? ");
            double.TryParse(Console.ReadLine(), out var taxaDeJuros);

            Console.Write("Saldo desejado? ");
            double.TryParse(Console.ReadLine(), out var saldoDesejado);
            
            taxaDeJuros = 1 + taxaDeJuros/100.0;

            int totalDeAnos = 0;
            while (saldo < saldoDesejado)
            {
                saldo *= taxaDeJuros;
                totalDeAnos++;
            }

            Console.WriteLine("Em {0} anos você terá o saldo de {1:n2}.", totalDeAnos, saldo);
            if (totalDeAnos == 0) 
            {
                Console.WriteLine("Pra ser sincero você não precisa usar essa calculadora.");
            }
            */

            /*

            Console.Write("Total de pedidos: ");
            int.TryParse(Console.ReadLine(), out var totalPedidos);

            double valorTotalPedidos = 0;
            for (int i = 1; i <= totalPedidos; i++) 
            {
                Console.Write("Valor do {0}o. pedido? ", i);
                double.TryParse(Console.ReadLine(), out var valorPedido);

                valorTotalPedidos += valorPedido; 
            }
            
            double ticketMedio = valorTotalPedidos / totalPedidos;
            Console.WriteLine("O valor total de pedidos é {0}, com ticket médio de {1:n2}.", valorTotalPedidos, ticketMedio);

            */

            int contadorPedidos = 0;
            double valorTotalPedidos = 0;

            while (true)
            {
                Console.Write("Valor do pedido? (Digite 0 para sair): ");
                double.TryParse(Console.ReadLine(), out var valorPedido);

                if (valorPedido == 0) 
                {
                    break;
                }

                if (valorPedido < 0)
                {
                    Console.WriteLine("O valor do pedido não pode ser negativo.");
                    continue;
                }

                valorTotalPedidos += valorPedido;
                contadorPedidos++;
            }

            double ticketMedido = valorTotalPedidos / contadorPedidos;
            Console.WriteLine("O valor total de pedidos é {0}, com ticket médio {1:n2}.", valorTotalPedidos, ticketMedido);

            Console.WriteLine("Fim da execução.");
        }

        static void ControleDeFluxoParte2() 
        {
            /*
            
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            if (nome.ToLower() == "leonardo") 
            {
                Console.WriteLine("Acesso permitido!");
            } 
            else 
            {
                Console.WriteLine("Acesso negado.");
            }
            */

            // performance do vendedor

            double valorMinimo = 50_000;
            double valorDaMeta = 100_000;
            double totalDeVendas = 49_000;

            // Bom vendedor
            // Vendedor regular
            // Precisa de treinamento

            string situacao;
            if (totalDeVendas >= valorDaMeta) 
            {
                situacao = "Bom vendedor";
            }
            else if (totalDeVendas > valorMinimo && totalDeVendas < valorDaMeta) 
            {
                situacao = "Vendedor regular";
            }
            else {
                situacao = "Vendedor precisa de treinamento";
            }

            Console.WriteLine("Situação do vendedor: {0}", situacao);

            // avaliação do vendedor

            byte nota = 3;
            string avaliacao;
            
            switch (nota) 
            {
                case 1:
                    avaliacao = "Péssimo";
                    break;
                case 2: 
                    avaliacao = "Ruim";
                    break;
                case 3:
                    avaliacao = "Regular";
                    break;
                case 4: 
                    avaliacao = "Bom";
                    break;
                case 5: 
                    avaliacao = "Excelente";
                    break;
                default: 
                    avaliacao = "Nota inválida";
                    break;
            }

            Console.WriteLine("Avaliação do vendedor é: {0}", avaliacao);
            
            Console.WriteLine("Fim da execução!");
        }

        static void ControleDeFluxoParte1() 
        {
             // operadores relacionais
            
            double valorMinimo = 50_000;
            double valorDaMeta = 100_000;

            Console.Write("Digite o total de vendas: ");
            double.TryParse(Console.ReadLine(), out var totalDeVendas);

            Console.WriteLine("Total vendido é igual à meta? {0}", totalDeVendas == valorDaMeta);
            Console.WriteLine("Total vendido é diferente da meta? {0}", totalDeVendas != valorDaMeta);
            Console.WriteLine("Total vendido está abaixo da meta? {0}", totalDeVendas < valorDaMeta);
            Console.WriteLine("Total vendido está acima da meta? {0}", totalDeVendas > valorDaMeta);
            Console.WriteLine("Total vendido está muito abaixo da meta? {0}", totalDeVendas <= valorMinimo);
            Console.WriteLine("Total vendido dobrou a meta? {0}", totalDeVendas >= valorDaMeta * 2);

            // operadores lógicos

            double margemMedia = 35;
            double margemMinima = 20;
            double margemIdeal = 30;

            //                                                true            AND (E)       false
            Console.WriteLine("Vendedor regular? {0}", totalDeVendas > valorMinimo && margemMedia <= margemMinima);
            
            //                                                  false         OR (OU)          true            AND (E)        true     
            Console.WriteLine("Vendedor bom? {0}", totalDeVendas >= valorDaMeta || totalDeVendas >= valorMinimo && margemMedia >= margemIdeal);

            //                                                     NOT (NÃO) (TRUE)
            Console.WriteLine("Vendedor precisa ser treinado? {0}", !(totalDeVendas >= valorDaMeta || totalDeVendas >= valorMinimo && margemMedia >= margemIdeal));
       
        }
    }
}

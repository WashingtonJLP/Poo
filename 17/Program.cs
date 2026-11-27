using System;
using System.Collections.Generic;
using System.Globalization;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProdutoPerecivel> produtos = new List<ProdutoPerecivel>();

            int opcao;

            do
            {
                Console.WriteLine("\n===== CONTROLE DE ALIMENTOS =====");
                Console.WriteLine("1 - Cadastrar alimento");
                Console.WriteLine("2 - Listar alimentos");
                Console.WriteLine("3 - Mostrar produtos vencidos");
                Console.WriteLine("4 - Mostrar produtos próximos do vencimento");
                Console.WriteLine("5 - Relatório financeiro");
                Console.WriteLine("0 - Sair");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("\nCódigo: ");
                        string codigo = Console.ReadLine();

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Preço: ");
                        decimal preco = decimal.Parse(Console.ReadLine());

                        Console.Write("Quantidade: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        Console.Write("Data de validade (dd/MM/yyyy): ");
                        DateTime validade = DateTime.ParseExact(
                            Console.ReadLine(),
                            "dd/MM/yyyy",
                            CultureInfo.InvariantCulture
                        );

                        ProdutoPerecivel produto = new ProdutoPerecivel(
                            codigo, nome, preco, quantidade, validade
                        );

                        produtos.Add(produto);

                        Console.WriteLine("Produto cadastrado com sucesso!");
                        break;

                    case 2:
                        Console.WriteLine("\n===== LISTA DE ALIMENTOS =====");

                        foreach (ProdutoPerecivel p in produtos)
                        {
                            Console.WriteLine($"Nome: {p.NOME}");
                            Console.WriteLine($"Quantidade: {p.QUANTIDADE}");
                            Console.WriteLine($"Dias para vencer: {p.DiasParaVencer()}");
                            Console.WriteLine($"Preço final: {p.CalcularPrecoFinal():C2}");
                            Console.WriteLine("-------------------------");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\n===== PRODUTOS VENCIDOS =====");

                        foreach (ProdutoPerecivel p in produtos)
                        {
                            if (p.DiasParaVencer() < 0)
                            {
                                Console.WriteLine(
                                    $"{p.NOME} | Vencido há {-p.DiasParaVencer()} dias"
                                );
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("\n===== PRÓXIMOS DO VENCIMENTO =====");

                        foreach (ProdutoPerecivel p in produtos)
                        {
                            int dias = p.DiasParaVencer();

                            if (dias >= 0 && dias <= 7)
                            {
                                Console.WriteLine(
                                    $"{p.NOME} | Dias restantes: {dias}"
                                );
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("\n===== RELATÓRIO FINANCEIRO =====");

                        decimal totalSemDesconto = 0m;
                        decimal totalComDesconto = 0m;
                        decimal maiorValor = 0m;

                        string produtoMaiorValor = "Nenhum";

                        int unidadesVencidas = 0;
                        int produtosAcima30 = 0;
                        int produtosMais5Dias = 0;

                        foreach (ProdutoPerecivel p in produtos)
                        {
                            decimal valorOriginal = p.ValorEstoque();

                            decimal valorFinal =
                                p.CalcularPrecoFinal() * p.QUANTIDADE;

                            totalSemDesconto += valorOriginal;
                            totalComDesconto += valorFinal;

                            if (valorFinal > maiorValor)
                            {
                                maiorValor = valorFinal;
                                produtoMaiorValor = p.NOME;
                            }

                            if (p.DiasParaVencer() < 0)
                            {
                                unidadesVencidas += p.QUANTIDADE;
                            }

                            if (p.CalcularPrecoFinal() > 30m)
                            {
                                produtosAcima30++;
                            }

                            if (p.DiasParaVencer() > 5)
                            {
                                produtosMais5Dias++;
                            }
                        }

                        decimal prejuizo = totalSemDesconto - totalComDesconto;

                        decimal media = 0m;

                        if (produtos.Count > 0)
                        {
                            media = totalComDesconto / produtos.Count;
                        }

                        Console.WriteLine($"Total sem desconto: {totalSemDesconto:C2}");
                        Console.WriteLine($"Total com desconto: {totalComDesconto:C2}");
                        Console.WriteLine($"Prejuízo total: {prejuizo:C2}");

                        Console.WriteLine(
                            $"Produto com maior valor em estoque: {produtoMaiorValor}"
                        );

                        Console.WriteLine($"Maior valor: {maiorValor:C2}");
                        Console.WriteLine($"Unidades vencidas: {unidadesVencidas}");
                        Console.WriteLine($"Produtos com preço acima de R$ 30: {produtosAcima30}");
                        Console.WriteLine($"Produtos com mais de 5 dias até vencer: {produtosMais5Dias}");
                        Console.WriteLine($"Média do valor de estoque por produto: {media:C2}");
                        break;

                    case 0:
                        Console.WriteLine("Encerrando o sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);
        }
    }
}
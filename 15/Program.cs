using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            int opcao;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1-Cadastrar  2-Baixa  3-Listar  4-Alertas  0-Sair");
                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("Código: ");
                    string codigo = Console.ReadLine();

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine());

                    Console.Write("Quantidade: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    Console.Write("Produto perecível? (S/N): ");
                    string resposta = Console.ReadLine().ToUpper();

                    if (resposta == "S")
                    {
                        Console.Write("Data de validade (dd/MM/yyyy): ");
                        DateTime validade = DateTime.Parse(Console.ReadLine());

                        ProdutoPerecivel produto = new ProdutoPerecivel(
                            codigo, nome, preco, quantidade, validade);

                        produtos.Add(produto);
                    }
                    else
                    {
                        Produto produto = new Produto(
                            codigo, nome, preco, quantidade);

                        produtos.Add(produto);
                    }

                    Console.WriteLine("Produto cadastrado!");
                }

                else if (opcao == 2)
                {
                    Console.Write("Código do produto: ");
                    string codigo = Console.ReadLine();

                    Produto produtoEncontrado = null;

                    foreach (Produto produto in produtos)
                    {
                        if (produto.Codigo == codigo)
                        {
                            produtoEncontrado = produto;
                            break;
                        }
                    }

                    if (produtoEncontrado != null)
                    {
                        Console.Write("Quantidade da baixa: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        if (produtoEncontrado.DarBaixa(quantidade))
                        {
                            Console.WriteLine("Baixa realizada!");
                        }
                        else
                        {
                            Console.WriteLine("Quantidade inválida ou estoque insuficiente.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado.");
                    }
                }

                else if (opcao == 3)
                {
                    produtos.Sort();

                    Console.WriteLine();
                    Console.WriteLine("PRODUTOS:");

                    foreach (Produto produto in produtos)
                    {
                        Console.WriteLine(produto);
                    }
                }

                else if (opcao == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("ALERTAS:");

                    foreach (Produto produto in produtos)
                    {
                        if (produto is ProdutoPerecivel)
                        {
                            ProdutoPerecivel perecivel =
                                (ProdutoPerecivel)produto;

                            if (perecivel.VenceEm(7))
                            {
                                Console.WriteLine(perecivel.Alerta());
                            }
                        }
                    }
                }

                else if (opcao != 0)
                {
                    Console.WriteLine("Opção inválida.");
                }

            } while (opcao != 0);

            Console.WriteLine("Programa encerrado.");
        }
    }
}
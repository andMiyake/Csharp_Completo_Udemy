﻿using System;
using System.Globalization;

namespace Course_Section5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 51. Construtores / 52 - Sobrecarga / 53 - Sintaxe alternativa para inicializar valores / 54. Palavra this
            //Console.WriteLine("Entre os dados do produto:");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();

            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Produto p = new Produto(nome, preco);

            //Produto p2 = new Produto();

            //Produto p3 = new Produto
            //{
            //    Nome = "TV",
            //    Preco = 500.00,
            //    Quantidade = 20
            //};

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);
            //Console.WriteLine();

            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);
            //Console.WriteLine();

            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);
            #endregion

            #region 55. Encapsulamento

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

            #endregion

        }
    }
}

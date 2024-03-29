﻿using System;
using System.Collections.Generic;
using System.Globalization;
using FunctionsThatReceiveFuncAsArgument.Entities;
using FunctionsThatReceiveFuncAsArgument.Services;

namespace FunctionsThatReceiveFuncAsArgument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            ProductService ps = new ProductService();

            double sum = ps.FilteredSumPred(list, p => p.Name[0] == 'T');
            double sum2 = ps.FilteredSum(list, p => p.Name[0] == 'T');
            Console.WriteLine("Sum = " + sum2.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

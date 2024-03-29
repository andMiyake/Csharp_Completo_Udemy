﻿using System;
using System.Collections.Generic;
using FunctionsThatReceiveFuncAsArgument.Entities;

namespace FunctionsThatReceiveFuncAsArgument.Services
{
    internal class ProductService
    {
        public double FilteredSum(List<Product> list, Func<Product, bool> criteria)
        {
            double sum = 0.0;
            foreach (Product p in list)
            {
                if (criteria.Invoke(p))
                {
                    sum += p.Price;
                }
            }
            return sum;
        }

        public double FilteredSumPred(List<Product> list, Predicate<Product> criteria)
        {
            double sum = 0.0;
            foreach (Product p in list)
            {
                if (criteria.Invoke(p))
                {
                    sum += p.Price;
                }
            }
            return sum;
        }
    }
}

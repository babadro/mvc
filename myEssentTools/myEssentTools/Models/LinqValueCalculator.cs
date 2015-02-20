﻿using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace myEssentTools.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }
    }
}
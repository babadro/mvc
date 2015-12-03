using System.Collections.Generic;

namespace myEssentialTools1.Models
{
    public class ShoppingCart
    {
        private LinqValueCalculator calc;

        public ShoppingCart(LinqValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace myEssentialTools1.Models
{
    public class LinqValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }
    }
}
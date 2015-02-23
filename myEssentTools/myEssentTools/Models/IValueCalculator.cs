using System.Collections.Generic;
using System.Collections;

namespace myEssentTools.Models
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> Products);
    }
}

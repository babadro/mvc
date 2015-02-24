using System.Collections.Generic;
using System.Linq;

namespace myEssentTools.Models
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}

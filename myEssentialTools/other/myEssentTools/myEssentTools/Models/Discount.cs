
namespace myEssentTools.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }

    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal DiscountSize;

        public DefaultDiscountHelper(decimal discountParam)
        {
            DiscountSize = discountParam;
        }
        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (DiscountSize / 100 * totalParam));
        }
    }
}
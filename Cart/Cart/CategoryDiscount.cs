namespace Cart
{
    public class CategoryDiscount : IDiscount
    {
        public int DiscountPercentage(ICartItem cartItem)
        {
            return (int)cartItem.product.category * cartItem.TotalCost() / 100;
        }
        
    }

}

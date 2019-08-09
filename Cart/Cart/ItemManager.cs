using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class ItemManager
    {
        public void AddProduct(List<ICartItem> cartItemList, IProduct product, int quantity)
        {
            
            bool cartItemFound = false;
            foreach (ICartItem item in cartItemList)
            {
                if (item.product.ProductID == product.ProductID)
                {
                    cartItemFound = true;
                    item.Quantity += quantity;
                }
            }

            if (!cartItemFound)
            {
                ICartItem cartItem = new CartItem(product, quantity);
                AddCartItem(cartItemList, cartItem);
            }
        }

        public void AddCartItem(List<ICartItem> cartItemList, ICartItem cartItem)
        {
            cartItemList.Add(cartItem);
        }

        public void RemoveCartItem(List<ICartItem> cartItemList, ICartItem cartItem)
        {
            cartItemList.Remove(cartItem);
        }

        public void DecreaseProductQuantityInCart(List<ICartItem> cartItemList, IProduct product, int quantity)
        {
            bool cartItemFound = false;
            foreach(ICartItem item in cartItemList)
            {
                if (item.product == product)
                {
                    cartItemFound = true;
                    item.Quantity -= quantity;
                    if (item.Quantity <= 0)
                    {
                        item.Quantity = 0;
                        RemoveCartItem(cartItemList, item);
                    }

                    break;
                }
            }

            if (!cartItemFound)
                throw new ItemNotFoundException("Item not found");
            
        }
    }
}

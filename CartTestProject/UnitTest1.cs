using System;
using Xunit;
using Cart;

namespace CartTestProject
{
    public class CartUnitTest
    {
        IProduct product1, product2;
        ItemManager itemManager;
        ShoppingCart shoppingCart;

        public CartUnitTest()
        {
            product1 = new Product("Shirt", 300, 008);
            product2 = new Product("Pen", 20, 003);
            itemManager = new ItemManager();
            shoppingCart = new ShoppingCart();
            itemManager.AddProduct(shoppingCart.cartItemList, product1, 5);
            itemManager.AddProduct(shoppingCart.cartItemList, product2, 9);

        }

        [Fact]
        public void TypeOfProduct_IsProduct_True()
        {
            Assert.Equal(typeof(Product), product1.GetType());
        }

        [Fact]
        public void TypeOfitemManager_IsItemManager_True()
        {
            Assert.Equal(typeof(ItemManager), itemManager.GetType());
        }

        [Fact]
        public void TypeOfShoppingCart_IsShoppingCart_True()
        {
            Assert.Equal(typeof(ShoppingCart), shoppingCart.GetType());
        }

        [Fact]
        public void GetTotalCost_1680()
        {
            Assert.Equal(1680, shoppingCart.GetTotalCost());
        }

        [Fact]
        public void GetCartItemListSize_2()
        {
            Assert.Equal(2, shoppingCart.cartItemList.Count);
        }

        [Fact]
        public void AddDifferentProduct_GetTotalCost_11680()
        {
            IProduct product = new Product("Refrigerator", 10000, 021);
            itemManager.AddProduct(shoppingCart.cartItemList, product, 1);
            Assert.Equal(11680, shoppingCart.GetTotalCost());
        }

        [Fact]
        public void AddDifferentProduct_GetCartItemListSize_3()
        {
            IProduct product = new Product("Refrigerator", 10000, 021);
            itemManager.AddProduct(shoppingCart.cartItemList, product, 1);
            Assert.Equal(3, shoppingCart.cartItemList.Count);
        }

        [Fact]
        public void AddSameProduct_GetTotalCost_1700()
        {
            itemManager.AddProduct(shoppingCart.cartItemList, product2, 1);
            Assert.Equal(1700, shoppingCart.GetTotalCost());
        }

        [Fact]
        public void AddSameProduct_GetCartItemListSize_2()
        {
            itemManager.AddProduct(shoppingCart.cartItemList, product2, 3);
            Assert.Equal(2, shoppingCart.cartItemList.Count);
        }

        [Fact]
        public void DecreaseItemQuantity_GetTotalCost_1640()
        {
            itemManager.DecreaseProductQuantityInCart(shoppingCart.cartItemList, product2, 2);
            Assert.Equal(1640, shoppingCart.GetTotalCost());
        }

        [Fact]
        public void DecreaseIemQuantityToZero_GetTotalCost_180()
        {
            itemManager.DecreaseProductQuantityInCart(shoppingCart.cartItemList, product1, 5);
            Assert.Equal(180, shoppingCart.GetTotalCost());
        }

        [Fact]
        public void DecreaseIemQuantityToZero_GetCartItemListSize_1()
        {
            itemManager.DecreaseProductQuantityInCart(shoppingCart.cartItemList, product1, 5);
            Assert.Single(shoppingCart.cartItemList);
        }

        [Fact]
        public void DecreaseQuantityOfItemWhichIsNotPresentInCart_ThrowsException()
        {
            IProduct product = new Product("Refrigerator", 10000, 021);
            Assert.Throws<ItemNotFoundException>(() => itemManager.DecreaseProductQuantityInCart(shoppingCart.cartItemList, product, 5));
        }

    }
}

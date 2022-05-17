using NUnit.Framework;
using Core;
using Core.Discounts;

namespace ShopTestProject
{
    public class ShoppingCartClass
    {
        private ShoppingCart _shoppingCart;
        [SetUp]
        public void Setup()
        {
            Product[] products =
            {
                new Product {ProductID = 10, Name = "Soup", Price = 200},
                new Product {ProductID = 20, Name = "Butter", Price = 400}
            };

            Discount_1 discount1 = new Discount_1();

            ValueCalculator calculator = new ValueCalculator();
            _shoppingCart = new ShoppingCart(discount1, calculator) { Products = products };
        }

        [Test]
        public void ValidCalculateTotal()
        {
           decimal result = _shoppingCart.CalculateTotal();
            Assert.Positive(result);
            Assert.AreEqual(result,594);
        }
    }
}
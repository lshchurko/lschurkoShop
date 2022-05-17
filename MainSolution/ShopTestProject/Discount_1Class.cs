using NUnit.Framework;
using Core;
using Core.Discounts;

namespace ShopTestProject
{
    public class Discount_1Class
    {
        Discount_1 discount11 = new Discount_1();
        private decimal val;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidPercentageValue()
        {
            val = 3;
            decimal result2 = discount11.PercentageValue(val);
            Assert.NotNull(result2);
            Assert.AreEqual(result2, 2.97);
        }
    }
}


using NUnit.Framework;
using Core;
using Core.Discounts;

namespace ShopTestProject
{
    public class Discount_5Class
    {
        Discount_5 discount51 = new Discount_5();
        private decimal val1;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidPercentageValue()
        {
            val1 = 3;
            decimal result3 = discount51.PercentageValue(val1);
            Assert.NotNull(result3);
            Assert.AreEqual(result3, 2.85);
        }
    }
}

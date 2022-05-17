using NUnit.Framework;
using Core;
using Core.Discounts;

namespace ShopTestProject
{
    public class ValueCalculatorClass
    {
        Product[] products1 =
            {
                new Product {ProductID = 101, Name = "Np12", Price = 2},
                new Product {ProductID = 100, Name = "Ng12", Price = 4}
            };
        ValueCalculator calculatorTest = new ValueCalculator();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidValidCalc()
        {
            decimal result1 = calculatorTest.ValueCalc(products1);
            Assert.Positive(result1);
            Assert.AreEqual(result1, 6);
        }
    }
}
using NUnit.Framework;
using Core;
using Core.Discounts;
using System;

namespace ShopTestProject
{
    public class ProductClass
    {
        Product mp1 = new Product { ProductID = 11, Name = "Goods1", Price = 200 };
        Product mp2 = new Product { ProductID = 10, Name = "Goods2", Price = 400 };
        Product mp3 = new Product { ProductID = 11, Name = "Goods1", Price = 200 };
        Product mp4 = new Product();
        object mp1object = new();
        object mp2object = new();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NotEqualProducs()
        {
            var resultv = mp1.Equals(mp2);
            Assert.IsFalse(resultv);
        }

        [Test]
        public void EqualProducs()
        {
            var resultv1 = mp1.Equals(mp3);
            Assert.IsTrue(resultv1);
        }

        [Test]
        public void NullProducs()
        {
            var resultv2 = mp1.Equals(mp4);
            Assert.IsFalse(resultv2);
        }
        [Test]
        public void NullObjectsProducs()
        {
            var resultv3 = mp2object.Equals(mp1object);
            Assert.IsFalse(resultv3);
        }
        [Test]
        public void HashCodeChecker()
        {
            var resultv4 = mp1.GetHashCode();
            Assert.NotNull(resultv4);
        }
    }
}

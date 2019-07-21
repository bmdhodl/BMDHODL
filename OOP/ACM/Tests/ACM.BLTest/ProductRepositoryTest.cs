using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveProductDisplayTest()
        {
            //arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers",
                CurrentPrice = 15.96M
            };

            //act
            var actual = productRepository.Retrieve(2);

            //assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            //arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers",
                CurrentPrice = 18M,
                HasChanges = true
            };

            //act
            var actual = productRepository.Save(updatedProduct);

            //assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers",
                CurrentPrice = null,
                HasChanges = true
            };

            //act
            var actual = productRepository.Save(updatedProduct);

            //assert
            Assert.AreEqual(false, actual);
        }
    }
}

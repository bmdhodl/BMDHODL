using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
                //-- Arrange
                Customer customer = new Customer();
                customer.FirstName = "Bilbo";
                customer.LastName = "Baggins";

                string expected = "Baggins, Bilbo";

                //-- Act
                string actual = customer.FullName;

                //-- Assert
                Assert.AreEqual(expected, actual);
         }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = true;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

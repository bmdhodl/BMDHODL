﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //act
            var actual = source.InsertSpaces();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //act
            var actual = source.InsertSpaces();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

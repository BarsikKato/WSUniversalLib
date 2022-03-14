using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace Module_Test
{
    [TestClass]
    public class WSLibTest
    {
        private Calculation calc = new Calculation();

        #region EasyTests
        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType_01()
        {
            int result = calc.GetQuantityForProduct(4, 1, 1, 1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType_01()
        {
            int result = calc.GetQuantityForProduct(1, 3, 1, 1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetQuantityForProduct_ImpossibleCount_01()
        {
            int result = calc.GetQuantityForProduct(1, 3, -1, 1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetQuantityForProduct_ImpossibleWidth_01()
        {
            int result = calc.GetQuantityForProduct(1, 3, 1, -1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetQuantityForProduct_ImpossibleLength_01()
        {
            int result = calc.GetQuantityForProduct(1, 3, 1, 1, -1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType_02()
        {
            int result = calc.GetQuantityForProduct(0, 1, 1, 1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType_02()
        {
            int result = calc.GetQuantityForProduct(1, 0, 1, 1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetQuantityForProduct_ImpossibleCount_02()
        {
            int result = calc.GetQuantityForProduct(1, 3, 0, 1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetQuantityForProduct_ImpossibleWidth_02()
        {
            int result = calc.GetQuantityForProduct(1, 3, 1, 0, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetQuantityForProduct_ImpossibleLength_02()
        {
            int result = calc.GetQuantityForProduct(1, 3, 1, 1, 0);
            Assert.AreEqual(-1, result);
        }
        #endregion

        #region HardTests
        [TestMethod]
        public void GetQuantityForProduct_Calculation_01()
        {
            int result = calc.GetQuantityForProduct(3, 1, 15, 20, 45);
            Assert.AreEqual(114146, result);
        }
        [TestMethod]
        public void GetQuantityForProduct_Calculation_02()
        {
            int result = calc.GetQuantityForProduct(1, 2, 843, 207.34f, 74.31f);
            Assert.AreEqual(14304459, result);
        }
        [TestMethod]
        public void GetQuantityForProduct_Calculation_03()
        {
            int result = calc.GetQuantityForProduct(2, 1, 453, 1425.14f, 15.003f);
            Assert.AreEqual(24287052, result);
        }
        [TestMethod]
        public void GetQuantityForProduct_Calculation_04()
        {
            int result = calc.GetQuantityForProduct(2, 2, 654, 31.433f,167.11f);
            Assert.AreEqual(8598583, result);
        }
        [TestMethod]
        public void GetQuantityForProduct_Calculation_05()
        {
            int result = calc.GetQuantityForProduct(1, 1, 133, 424.564f, 234.13f);
            Assert.AreEqual(14586312, result);
        }
        #endregion
    }
}

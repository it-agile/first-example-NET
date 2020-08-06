using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Examples
{
    [TestClass]
    public class DingMitDatumTest
    {
        DingMitDatum dingUnterTest = new DingMitDatum();

        [TestMethod]
        public void merktSichWannEsErstelltWurde()
        {
            Assert.AreEqual(DateTime.Now, dingUnterTest.ErstellungsDatum);
        }
    }
}

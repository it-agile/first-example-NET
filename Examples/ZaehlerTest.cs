using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Examples
{
    [TestClass]
    public class ZaehlerTest
    {
        [TestMethod]
        public void IstNullBeiStart()
        {
            Assert.AreEqual(0, Zaehler.Stand);
        }

        [TestMethod]
        public void KannErhoertWerden()
        {
            Zaehler.Erhoehe();
            Assert.AreEqual(1, Zaehler.Stand);
        }

        [TestMethod]
        public void KannNochmalErhoertWerden()
        {
            Zaehler.Erhoehe();
            Assert.AreEqual(2, Zaehler.Stand);
        }
    }
}

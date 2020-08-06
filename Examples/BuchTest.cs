using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Examples
{
    [TestClass]
    public class BuchTest
    {
        [TestMethod]
        public void KannAusgeliehenUndZurueckGegebenWerden()
        {
            Buch buchUnterTest = new Buch();
            Assert.IsTrue(buchUnterTest.IstAusleihbar);
            buchUnterTest.LeiheAus();
            Assert.IsFalse(buchUnterTest.IstAusleihbar);
            buchUnterTest.GibZurueck();
            Assert.IsTrue(buchUnterTest.IstAusleihbar);
            buchUnterTest.GibZurueck();
            Assert.IsTrue(buchUnterTest.IstAusleihbar);
            buchUnterTest.LeiheAus();
            Assert.IsFalse(buchUnterTest.IstAusleihbar);
        }
    }
}

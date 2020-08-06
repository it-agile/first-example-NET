using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Examples
{
    [TestClass]
    public class VorlagenVerwalterTest
    {
        [TestMethod]
        public void ErsetzePlatzhalterMitRichtigenWerten()
        {
            VorlagenVerwalter vorlagen = new VorlagenVerwalter();
            vorlagen.definiere("foo", "foo {bar}");
            var werte = new Dictionary<string, object>();
            werte.Add("bar", "baz");
            var result = vorlagen.FuelleAus("foo", werte);
            Assert.AreEqual("foo baz", result);
        }
    }
}

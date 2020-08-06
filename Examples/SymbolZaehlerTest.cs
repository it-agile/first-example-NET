using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;

namespace Examples
{
    [TestClass]
    public class SymbolZaehlerTest
    {
        [TestMethod]
        public void ZaehltSymbole()
        {
            WebClient client = new WebClient();
            string data = client.DownloadString("http://agileinaflash.blogspot.com/feeds/posts/default");
            TextReader datenStream = new StringReader(data);

            SymbolZaehler zaehlerUnterTest = new SymbolZaehler();
            Assert.AreEqual(475, zaehlerUnterTest.ErmittleFragmente(datenStream));
        }

        [TestMethod]
        public void ZaehltSymboleVonVielenZeilen()
        {
            WebClient client = new WebClient();
            string data = client.DownloadString("https://www.it-agile.de/impressum/");
            TextReader datenStream = new StringReader(data);

            SymbolZaehler zaehlerUnterTest = new SymbolZaehler();
            Assert.AreEqual(9, zaehlerUnterTest.ErmittleFragmente(datenStream));
        }
    }
}

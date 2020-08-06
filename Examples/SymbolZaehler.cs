using System;
using System.IO;

namespace Examples
{
    class SymbolZaehler
    {
        public int ErmittleFragmente(TextReader datenStream)
        {
            var anzahl = 0;
            var zeile = "";
            while((zeile = datenStream.ReadLine()) != null)
            {
                string[] fragments = zeile.Split(new string [] { "/>" }, StringSplitOptions.RemoveEmptyEntries);
                if(fragments.Length > 1)
                {
                    anzahl += fragments.Length - 1;
                }
            }
            datenStream.Close();
            return anzahl;
        }
    }
}
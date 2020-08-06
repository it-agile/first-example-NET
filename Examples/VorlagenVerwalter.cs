using System;
using System.Collections.Generic;

namespace Examples
{
    internal class VorlagenVerwalter
    {
        private Dictionary<string, string> _vorlagen;

        public VorlagenVerwalter()
        {
            _vorlagen = new Dictionary<string, string>();
        }

        internal void definiere(string n, string t)
        {
            _vorlagen.Add(n, t);
        }

        internal object FuelleAus(string n, Dictionary<string, object> werte)
        {
            var template = _vorlagen[n];
            var result = template;

            foreach (var item in werte)
            {
                result = result.Replace("{" + item.Key + "}", item.Value.ToString());
            }

            return result;
        }
    }
}
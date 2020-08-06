using System;

namespace Examples
{
    class Buch
    {
        public bool _IstAusleihbar;

        public Buch ()
        {
            _IstAusleihbar = true;
        }

        public void LeiheAus()
        {
            _IstAusleihbar = false;
        }

        public bool IstAusleihbar
        {
            get => _IstAusleihbar;
        }

        internal void GibZurueck()
        {
            _IstAusleihbar = true;
        }
    }
}
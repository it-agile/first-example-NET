using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Zaehler
    {
        public static int Stand { get; internal set; }

        public static void Erhoehe()
        {
            Stand++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaiciuokles
{
    public static class Skaiciuokles
    {
        public static int Suma(int sk1, int sk2)
        {
            return sk1 + sk2;
        }

        public static int Atimtis(int sk1, int sk2)
        {
            return sk1 - sk2;
        }
        public static int Sandauga(int sk1, int sk2)
        {
            return sk1 * sk2;
        }
        public static double Dalyba(int sk1, int sk2)
        {
            return (double)sk1 / sk2;
        }
    }
}

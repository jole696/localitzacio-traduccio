using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_calculadora
{
    internal class dades_conversor
    {

        public const decimal USD_TO_EUR = 0.85m;
        public const decimal GBP_TO_EUR = 1.13m;
        public const decimal JPY_TO_EUR = 0.0075m;

        public static decimal ConvertToEuro(decimal amount)
        {
            // determinar la moneda d'origen
            // i fer la conversio pel factor adient:
            return amount * USD_TO_EUR;
        }

    }
}

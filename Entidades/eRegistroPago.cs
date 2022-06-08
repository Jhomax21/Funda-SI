using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eRegistroPago
    {
        public string tipoTarjeta { get; set; }
        public string titular { get; set; }
        public int numTarjeta { get; set; }
        public double Pagototal { get; set; }

    }
}

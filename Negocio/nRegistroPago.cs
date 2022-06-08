using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
namespace Negocio
{
    public class nRegistroPago
    {
        Datos.dRegistroPago obj = new Datos.dRegistroPago();
        public void N_llenarFactura(Entidades.eRegistroPago obje)
        {

            obj.D_llenarFactura(obje);
        }
        public void N_llenarPagoFactura(double pago)
        {
            obj.D_llenarPagoFactura(pago);
        }
        public DataTable N_Listar_compras()
        {
            
            return obj.D_Listar_compras();
        }
    }
}

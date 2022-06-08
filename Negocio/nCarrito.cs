using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
namespace Negocio
{
    public class nCarrito
    {
        Datos.dCarrito obj = new Datos.dCarrito();

        public void N_Insertar_al_carrito(Entidades.eCarrito obje)
        {
            obj.D_Insertar_al_carrito(obje);
        }
       
        public DataTable N_ListarelCarrito()
        {
            return obj.D_ListarelCarrito();
        }
        public void N_Borrar_el_carrito()
        {
            obj.D_Borrar_el_carrito();
        }
        public void N_EliminarSeleccionado_carrito(int obje)
        {
            obj.D_EliminarSeleccionado_carrito(obje);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class nUsuario
    {
        Datos.dUsuario obj = new Datos.dUsuario();
        public DataTable N_login(Entidades.eUsuario obje)
        {
            return obj.D_Login(obje);
        }
        public DataTable N_Loginadmin(Entidades.eUsuario obje)
        {
            return obj.D_Loginadmin(obje);
        }
        public void N_Registrar(Entidades.eUsuario obje)
        {
            obj.D_Registrar(obje);
        }
        public bool N_VerificarUser(Entidades.eUsuario obje)
        {
            return obj.D_VerificarUser(obje);
        }
    }
}

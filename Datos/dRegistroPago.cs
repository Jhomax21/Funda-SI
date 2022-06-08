using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Entidades;
namespace Datos
{
    public class dRegistroPago
    {
        Database db = new Database();
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public void D_llenarFactura(Entidades.eRegistroPago obje)
        {

            SqlCommand cmd = new SqlCommand("llenarfactura", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TTarjeta", obje.tipoTarjeta);
            cmd.Parameters.AddWithValue("@Tlr", obje.titular);
            cmd.Parameters.AddWithValue("@NumTarjeta", obje.numTarjeta);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void D_llenarPagoFactura(double pago)
        {
            SqlCommand cmd = new SqlCommand("llenarpago", cn);
            cn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pagototal", pago);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public DataTable D_Listar_compras()
        {
            SqlDataReader leerfilas;
            DataTable Tabla = new DataTable();
            cn.Open();
            SqlCommand cmd = new SqlCommand("listarcompras", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            leerfilas = cmd.ExecuteReader();
            Tabla.Load(leerfilas);
            leerfilas.Close();
            cn.Close();
            return Tabla;
        }
    }
}

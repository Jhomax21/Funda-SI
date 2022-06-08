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
    public class dCarrito
    {
        Database db = new Database();
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
       
        public void D_Insertar_al_carrito(Entidades.eCarrito obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("InsertarCarrito", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tipoid", obj.TIPO_ID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Close();
        }
       
        public DataTable D_ListarelCarrito()
        {
            SqlDataReader leerfilas;
            DataTable Tabla = new DataTable();
            cn.Open();
            SqlCommand cmd = new SqlCommand("Listar_en_el_Carrito", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            leerfilas = cmd.ExecuteReader();
            Tabla.Load(leerfilas);
            leerfilas.Close();
            cn.Close();
            return Tabla;
        }
        public void D_Borrar_el_carrito()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("BorrarelCarrito", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Close();
        }
        public void D_EliminarSeleccionado_carrito(int obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Elminar_seleccionado_carrito", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", obj);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Close();
        }
        
    }
}

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
    public class dUsuario
    {
        Database db = new Database();
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public bool D_VerificarUser(Entidades.eUsuario obje)
        {
            int vof = 0;
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_buscarUser", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usu", obje.user);
            
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
                vof = 1;
            }
            registro.Close();
            cn.Close();
            if (vof == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
     
        public DataTable D_Login(Entidades.eUsuario obje)
        {
            //SqlConnection cn = db.ConectaDb();
            SqlCommand cmd = new SqlCommand("sp_login", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usu", obje.user);
            cmd.Parameters.AddWithValue("@pass", obje.password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable usuario = new DataTable();
            da.Fill(usuario);
            return usuario;
        }
        public void D_Registrar(Entidades.eUsuario obje)
        {
          
            SqlCommand cmd = new SqlCommand("sp_rUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usu", obje.user);
            cmd.Parameters.AddWithValue("@pass", obje.password);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public DataTable D_Loginadmin(Entidades.eUsuario obje)
        {
            //SqlConnection cn = db.ConectaDb();
            SqlCommand cmd = new SqlCommand("logadmin", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@admin", obje.admin);
            cmd.Parameters.AddWithValue("@pasword", obje.password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable usuario = new DataTable();
            da.Fill(usuario);
            return usuario;
        }

    }
}

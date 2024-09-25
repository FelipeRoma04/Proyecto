using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias para trabajar con SQL
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Model
{
    internal class conexionModel
    {
        private string cadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbProyecto;Data Source=FELIPE_BELLO\\SQLEXPRESS";
        SqlConnection conexion;
        public SqlConnection establecerConexion() {

            this.conexion = new SqlConnection(this.cadenaConexion);
            return this.conexion;
        }
        public bool ejecutarSinRetornoDatos(string strComando)
        {
            try
            {
                SqlCommand comando = new SqlCommand();

                comando.CommandText = strComando;
                comando.Connection = this.establecerConexion();
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();

                return true;

            }
            catch 
            {
                return false;   
            }
        }
    }
}
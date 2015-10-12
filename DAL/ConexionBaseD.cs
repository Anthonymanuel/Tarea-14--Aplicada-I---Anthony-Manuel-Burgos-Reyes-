using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace DAL
{   /// <summary>
    /// Clase conexion
    /// </summary>
    public class ConexionBaseD
    {

        private SqlConnection con;
        private SqlCommand cmd;
       
       

        public ConexionBaseD()
        {
            con = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = Pelicula; Integrated Security = True");
            cmd = new SqlCommand();
          
            
        }
        /// <summary>
        /// Ejecuta  comandos de  la base de datos
        /// </summary>
        /// <param name="comando">El comando  sql que se desea ejecutar</param>
        /// <returns>Verdadero o Falso dependiendo de si ejecuto correctamente o no</returns>
        public bool Ejecutar(String comando)
        {
            bool retor = false;

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                retor = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return retor;
        }
        /// <summary>
        /// Para obtener datos de la tabla de la base de datos
        /// </summary>
        /// <param name="comando">El comando  sql que se desea ejecutar</param>
        /// <returns>retorna la tabla de la base de datos</returns> 
        public DataTable getDatos(String comando)
        {
            SqlDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = comando;

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }

            return dt;
        }
    }
}

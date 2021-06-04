using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Datos
{
    public class Usuario
    {
        private SqlConnection conn;
        private SqlDataReader Reader;

        public bool ValidarUsuario(string usuario, string clave)
        {
            bool existe = false;
            int i = 0;

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Prj_Presentacion.Properties.Settings.ConectarSQL"].ToString());
            //Prj_Presentacion.Properties.Settings.ConectarSQL
            using (SqlCommand cmd = new SqlCommand("Usp_ValidarUsuario", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@USUArio", usuario);
                    cmd.Parameters.AddWithValue("@CLAVE", clave);

                    Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        i++;
                    }

                    if (i >= 1) { existe = true; }
                    else { existe = false; }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Reader.Close();
                    cmd.Connection.Close();
                }
                return existe;
            }
        }
    }
}

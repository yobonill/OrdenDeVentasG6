using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Entidades;

namespace Prj_Datos
{
    public class PersonaDAL: Cls_Conexion
    {
        private SqlDataReader Reader;
        bool existe = false;
        public bool ValidarRecord(int RecImp)
        {
            SqlConnection cn = new SqlConnection(ConectarSql());
            SqlCommand ComandoSQL;
            //private SqlDataReader Reader;
            int i = 0;

            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = cn;
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_personaLoadByPrimaryKey";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@idpersona", RecImp);
                    cn.Open();
                    Reader = ComandoSQL.ExecuteReader();

                    while (Reader.Read())
                    {
                        i++;
                    }

                    if (i >= 1) { existe = true; }
                    else { existe = false; }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    Reader.Close();
                    cn.Close();
                }
                return existe;
            }
        }

        public DataSet Mostrar_Recordpersona(string parametro)
        {
            SqlCommand ComandoSQL = new SqlCommand();
            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter();
            DataTable dt = new DataTable();

            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = ConectarSql();

                DataSet ds = new DataSet();

                ComandoSQL = new SqlCommand(parametro, cn);
                ComandoSQL.CommandType = CommandType.Text;
                ComandoSQL.Parameters.AddWithValue("@parametro", parametro);

                AdaptadorSQL.SelectCommand = ComandoSQL;
                AdaptadorSQL.Fill(ds, "VerRecord");
                cn.Open();
                ComandoSQL.ExecuteNonQuery();
                cn.Close();

                return ds;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public DataSet BD_Mostrar_persona()
        {
            SqlConnection cn = new SqlConnection(ConectarSql());

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("proc_personaLoadAll", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dato = new DataSet();
                da.Fill(dato, "VerRecord");
                return dato;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Hay problemas: " + ex.Message, "Listar Todas los persona", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }

        public DataSet Buscar_Recordpersona(string parametro)
        {
            SqlCommand ComandoSQL = new SqlCommand();
            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter();
            DataTable dt = new DataTable();

            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = ConectarSql();

                DataSet ds = new DataSet();

                ComandoSQL = new SqlCommand(parametro, cn);
                ComandoSQL.CommandType = CommandType.Text;
                ComandoSQL.Parameters.AddWithValue("@parametro", parametro);

                AdaptadorSQL.SelectCommand = ComandoSQL;
                AdaptadorSQL.Fill(ds, "VerRecord");
                cn.Open();
                ComandoSQL.ExecuteNonQuery();
                cn.Close();

                return ds;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public DataTable BD_Buscar_personaxNopersonaNo(string valor)
        {
            SqlConnection cn = new SqlConnection(ConectarSql());

            try
            {

                SqlDataAdapter da = new SqlDataAdapter("proc_personaLoadByPrimaryKey", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Idpersona", valor);
                DataTable dato = new DataTable();
                da.Fill(dato);
                return dato;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Hay problemas: " + ex.Message, "Listar persona", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }
        public void BD_Registrar_persona(EN_Persona per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_personaInsert", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Idpersona", per.Idpersona);
                cmd.Parameters.AddWithValue("@TipoPersona", per.Tipo_persona);
                cmd.Parameters.AddWithValue("@Nombre", per.Nombre);
                cmd.Parameters.AddWithValue("@TipoDocumento", per.Tipo_documento);
                cmd.Parameters.AddWithValue("@NumDocumento", per.Num_documento);
                cmd.Parameters.AddWithValue("@Direccion", per.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", per.Telefono);
                cmd.Parameters.AddWithValue("@Email", per.Email);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo Escribir " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Actualizar_persona(EN_Persona per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_personaUpdate", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Idpersona", per.Idpersona);
                cmd.Parameters.AddWithValue("@TipoPersona", per.Tipo_persona);
                cmd.Parameters.AddWithValue("@Nombre", per.Nombre);
                cmd.Parameters.AddWithValue("@TipoDocumento", per.Tipo_documento);
                cmd.Parameters.AddWithValue("@NumDocumento", per.Num_documento);
                cmd.Parameters.AddWithValue("@Direccion", per.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", per.Telefono);
                cmd.Parameters.AddWithValue("@Email", per.Email);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo Escribir " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static bool sequito;
        public void BD_Eliminar_persona(EN_Persona per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_personaDelete", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Idpersona", per.Idpersona);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                sequito = true;
            }
            catch (Exception ex)
            {
                sequito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo Escribir " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void BD_Inhabilitar_persona(EN_Persona per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_InhabilitarpersonaUpdate", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Idpersona", per.Idpersona);
                cmd.Parameters.AddWithValue("@Estado", false);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo Escribir " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}

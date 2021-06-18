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
    public class UsuarioDAL: Cls_Conexion
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
                ComandoSQL.CommandText = "proc_usuarioLoadByPrimaryKey";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@idusuario", RecImp);
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

        public DataSet Mostrar_RecordUsuario(string parametro)
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

        public DataSet BD_Mostrar_Usuario()
        {
            SqlConnection cn = new SqlConnection(ConectarSql());

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("proc_UsuarioLoadAll", cn);
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
                MessageBox.Show("Hay problemas: " + ex.Message, "Listar Todos los usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }

        public DataSet Buscar_RecordUsuario(string parametro)
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

        public DataTable BD_Buscar_UsuarioxNoUsuarioNo(string valor)
        {
            SqlConnection cn = new SqlConnection(ConectarSql());

            try
            {

                SqlDataAdapter da = new SqlDataAdapter("proc_UsuarioLoadByPrimaryKey", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@IdUsuario", valor);
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
                MessageBox.Show("Hay problemas: " + ex.Message, "Listar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }
        public void BD_Registrar_usuario(EN_Usuario per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_usuarioInsert", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idusuario", per.Idusuario1);
                cmd.Parameters.AddWithValue("@idrol", per.Idrol1);
                cmd.Parameters.AddWithValue("@usuario", per.Usuario1);
                cmd.Parameters.AddWithValue("@password", per.Password1);
                cmd.Parameters.AddWithValue("@NumDocumento", per.Num_documento1);
                cmd.Parameters.AddWithValue("@direccion", per.Direccion1);
                cmd.Parameters.AddWithValue("@telefono", per.Telefono1);
                cmd.Parameters.AddWithValue("@email", per.Email1);
                cmd.Parameters.AddWithValue("@Estado", per.Estado1);
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

        public void BD_Actualizar_usuario(EN_Usuario per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_UsuarioUpdate", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idusuario", per.Idusuario1);
                cmd.Parameters.AddWithValue("@idrol", per.Idrol1);
                cmd.Parameters.AddWithValue("@usuario", per.Usuario1);
                cmd.Parameters.AddWithValue("@password", per.Password1);
                cmd.Parameters.AddWithValue("@NumDocumento", per.Num_documento1);
                cmd.Parameters.AddWithValue("@direccion", per.Direccion1);
                cmd.Parameters.AddWithValue("@telefono", per.Telefono1);
                cmd.Parameters.AddWithValue("@email", per.Email1);
                cmd.Parameters.AddWithValue("@Estado", per.Estado1);
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
        public void BD_Eliminar_usuario(EN_Usuario per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_usuarioDelete", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Idusuario", per.Idusuario1);
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
        public void BD_Inhabilitar_Usuario(EN_Usuario per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_InhabilitarusuarioUpdate", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Idusuario", per.Idusuario1);
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

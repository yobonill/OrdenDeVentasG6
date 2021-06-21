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
    public class categoriaDAL : Cls_Conexion
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
                ComandoSQL.CommandText = "proc_categoriaLoadByPrimaryKey";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@idcategoria", RecImp);
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

        public DataSet Mostrar_Recordcategoria(string parametro)
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

        public DataSet BD_Mostrar_categoria()
        {
            SqlConnection cn = new SqlConnection(ConectarSql());

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("proc_categoriaLoadAll", cn);
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
                MessageBox.Show("Hay problemas: " + ex.Message, "Listar Todas los categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }

        public DataSet Buscar_Recordcategoria(string parametro)
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

        public DataTable BD_Buscar_categoriaxNocategoriaNo(string valor)
        {
            SqlConnection cn = new SqlConnection(ConectarSql());

            try
            {

                SqlDataAdapter da = new SqlDataAdapter("proc_categoriaLoadByPrimaryKey", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Idcategoria", valor);
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
                MessageBox.Show("Hay problemas: " + ex.Message, "Listar categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }
        public void BD_Registrar_categoria(EN_categoria per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_categoriaInsert", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idcategoria", per.Idcategoria);
                cmd.Parameters.AddWithValue("@Nombre", per.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", per.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", per.Estado);


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

        public void BD_Actualizar_categoria(EN_categoria per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_categoriaUpdate", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;


              
                  cmd.Parameters.AddWithValue("@idcategoria", per.Idcategoria);
                cmd.Parameters.AddWithValue("@Nombre", per.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", per.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", per.Estado);




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
        public void BD_Eliminar_categoria(EN_categoria per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_categoriaDelete", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Idcategoria", per.Idcategoria);
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
        public void BD_Inhabilitar_categoria(EN_categoria per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_InhabilitarcategoriaUpdate", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Idcategoria", per.Idcategoria);
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

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
    public class articuloDAL : Cls_Conexion
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
                ComandoSQL.CommandText = "proc_articuloLoadByPrimaryKey";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@idarticulo", RecImp);
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

        public DataSet Mostrar_Recordarticulo(string parametro)
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

        public DataSet BD_Mostrar_articulo()
        {
            SqlConnection cn = new SqlConnection(ConectarSql());

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("proc_articuloLoadAll", cn);
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
                MessageBox.Show("Hay problemas: " + ex.Message, "Listar Todas los articulo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }

        public DataSet Buscar_Recordarticulo(string parametro)
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

        public DataTable BD_Buscar_articuloxNoarticuloNo(string valor)
        {
            SqlConnection cn = new SqlConnection(ConectarSql());

            try
            {

                SqlDataAdapter da = new SqlDataAdapter("proc_articuloLoadByPrimaryKey", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Idarticulo", valor);
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
                MessageBox.Show("Hay problemas: " + ex.Message, "Listar articulos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }
        public void BD_Registrar_articulo(EN_articulo per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_articuloInsert", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Idarticulo", per.Idarticulo);
                cmd.Parameters.AddWithValue("@idcategoria", per.Idcategoria);
                cmd.Parameters.AddWithValue("@Codigo", per.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", per.Nombre);
                cmd.Parameters.AddWithValue("@PrecioVenta", per.Precio_venta);
                cmd.Parameters.AddWithValue("@Stock", per.Stock);
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

        public void BD_Actualizar_articulo(EN_articulo per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_articuloUpdate", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;


              
                cmd.Parameters.AddWithValue("@Idarticulo", per.Idarticulo);
                cmd.Parameters.AddWithValue("@idcategoria", per.Idcategoria);
                cmd.Parameters.AddWithValue("@Codigo", per.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", per.Nombre);
                cmd.Parameters.AddWithValue("@PrecioVenta", per.Precio_venta);
                cmd.Parameters.AddWithValue("@Stock", per.Stock);
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
        public void BD_Eliminar_articulo(EN_articulo per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_articuloDelete", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Idarticulo", per.Idarticulo);
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
        public void BD_Inhabilitar_articulo(EN_articulo per)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = ConectarSql();

                SqlCommand cmd = new SqlCommand("proc_InhabilitararticuloUpdate", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Idarticulo", per.Idarticulo);
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

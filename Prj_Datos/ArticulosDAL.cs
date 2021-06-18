using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prj_Datos
{
    public class ArticulosDAL: Cls_Conexion
    {
        private SqlCommand ComandoSQL;
        SqlDataAdapter AdaptadorSQL = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private SqlDataAdapter Reader;
        bool existe = false;

        private Acceso AccesoDatos;

        //public ArticulosDal()
        //{
           //AccesoDatos = new Acceso();
        //}

        public DataSet BD_Mostrar_Articulos()
        {
            SqlConnection cn = new SqlConnection(ConectarSql());

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("proc_ARTICULOSLoadAll", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dato = new DataSet();
                da.Fill(dato, "VerRecord");
                return dato;
            }
            catch (Exception ex)
            {
                if(cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Hay Problemas: " + ex.Message, "Listar Todos los articulos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }
        public DataSet Buscar_RecordArticulo(string parametro)
        {
            SqlCommand ComandoSQL = new SqlCommand();
            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                Acceso AccesoDatos;
                AccesoDatos = new Acceso();

                DataSet ds = new DataSet();

                ComandoSQL = new SqlCommand(parametro, AccesoDatos.ObtenerConexion());
                ComandoSQL.CommandType = CommandType.Text;
                ComandoSQL.Parameters.AddWithValue("@parametro", parametro);

                AdaptadorSQL.SelectCommand = ComandoSQL;
                AdaptadorSQL.Fill(ds, "VerRecord");

                return ds;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void RebajarConceptos(EN_Articulos Rec)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {

                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_RebajarConceptosUpdate";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@Codigo", Rec.ID_ARTICULO);
                    ComandoSQL.Parameters.AddWithValue("@CantExist", Rec.Cant_Exist);

                    //Ejecutar Comando
                    ComandoSQL.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }
            }
        }
    }
}

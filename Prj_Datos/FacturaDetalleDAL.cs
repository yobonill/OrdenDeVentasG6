using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Prj_Entidades;

namespace Prj_Datos
{
    public class FacturaDetalleDAL
    {
        private SqlCommand ComandoSQL;
        SqlDataAdapter AdaptadorSQL = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private SqlDataReader Reader;
        bool existe = false;


        //Clase de Acceso a los datos
        private Acceso AccesoDatos;

        public FacturaDetalleDAL()
        {
            AccesoDatos = new Acceso();
        }

        public void InsertarRecord(EN_FacturaDetalle Rec)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {

                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_detalle_ventaInsert";
                try
                {


                    ComandoSQL.Parameters.AddWithValue("@idventa", Rec.IDVENTA1);
                    ComandoSQL.Parameters.AddWithValue("@idarticulo", Rec.IDARTICULO1);
                    ComandoSQL.Parameters.AddWithValue("@cantidad", Rec.CANTIDAD1);
                    ComandoSQL.Parameters.AddWithValue("@precio", Rec.PRECIO1);
                    ComandoSQL.Parameters.AddWithValue("@descuento", Rec.DESCUENTO1);


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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Prj_Entidades;
using System.Windows.Forms;

namespace Prj_Datos
{
    public class FacturaDAL : Cls_Conexion
    {

        private SqlCommand ComandoSQL;
        SqlDataAdapter AdaptadorSQL = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private SqlDataReader Reader;
        bool existe = false;


        private Acceso AccesoDatos;
        public FacturaDAL()
        {
            AccesoDatos = new Acceso();
        }
        public DataSet Ultima_Posicion()
        {
            try
            {
                AccesoDatos.ObtenerConexion().Open();

                SqlCommand Command = new SqlCommand();
                //Command.Connection = con;
                Command.Connection = AccesoDatos.ObtenerConexion();

                Command.CommandText = "[proc_UltFactura]";
                Command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter Adapter = new SqlDataAdapter(Command);

                SqlDataAdapter adap = new SqlDataAdapter(Command);
                adap.Fill(ds, "ultima_posicion");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void InsertarRecord(EN_Factura Rec)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {

                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_ventaInsert";
                try
                {

                    ComandoSQL.Parameters.AddWithValue("@idventa", Rec.IDVENTA1);
                    ComandoSQL.Parameters.AddWithValue("@idcliente", Rec.IDCLIENTE1);
                    ComandoSQL.Parameters.AddWithValue("@idusuario", Rec.IDUSUARIO1);
                    ComandoSQL.Parameters.AddWithValue("@TipoComprobante", Rec.TIPO_COMPROBANTE1);
                    ComandoSQL.Parameters.AddWithValue("@SerieComprobante", Rec.SERIE_COMPROBANTE1);
                    ComandoSQL.Parameters.AddWithValue("@NumComprobante", Rec.NUM_COMPROBANTE1);
                    ComandoSQL.Parameters.AddWithValue("@FechaHora", Rec.FECHA_HORA1);
                    ComandoSQL.Parameters.AddWithValue("@Impuesto", Rec.IMPUESTO1);
                    ComandoSQL.Parameters.AddWithValue("@Total", Rec.TOTAL1);
                    ComandoSQL.Parameters.AddWithValue("@Estado", Rec.ESTADO1);


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

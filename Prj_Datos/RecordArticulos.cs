using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prj_Datos
{
    public class RecordArticulos
    {
        public RecordArticulos() { }
        int cod = 0;
        int pid = 0;
        public RecordArticulos(int pIdRecord, int pid2) {cod = pIdRecord; pid = pid2; LoadRegistros(); }


        int ID_ARTICULO;
        int ID_CATEGORIA;
        string CODIGO;
        string NOMBRE;
        double PRECIO_VENTA;
        int STOCK;
        string DESCRIPCION;
        bool ESTADO;

        public int ID_ARTICULO1 {get => ID_ARTICULO; set => ID_ARTICULO = value;}
        public int ID_CATEGORIA1 { get => ID_ARTICULO; set => ID_ARTICULO = value; }
        public string CODIGO1 { get => CODIGO; set => CODIGO = value; }
        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        public double PRECIO_VENTA1 { get => PRECIO_VENTA; set => PRECIO_VENTA = value; }
        public int STOCK1 { get => STOCK; set => STOCK = value; }
        public string DESCRIPCION1 { get => DESCRIPCION; set => DESCRIPCION = value; }
        public bool ESTADO1 { get => ESTADO; set => ESTADO = value; }

        protected void LoadRegistros()
        {

            string Cadena = "" +
                    "Data Source=.\\;Initial Catalog=OrdenVentasDB;Integrated Security=True";


            SqlConnection cnn = new SqlConnection(Cadena);
            try
            {
                string varSQL = "SELECT * FROM articulo WHERE idarticulo=@ID_ARTICULO";
                
                cnn.Open();
                SqlCommand cmd = new SqlCommand(varSQL, cnn);
                cmd.CommandType = CommandType.Text;

                //Parámetros
                cmd.Parameters.Add("@ID_ARTICULO", SqlDbType.VarChar).Value = cod;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["idarticulo"] != DBNull.Value)
                    {
                        ID_ARTICULO1 = Convert.ToInt16(dr["idarticulo"]);
                    }
                    if (dr["idcategoria"] != DBNull.Value)
                    {
                        ID_CATEGORIA1 = Convert.ToInt16(dr["idcategoria"]);
                    }
                    if (dr["codigo"] != DBNull.Value)
                    {
                        CODIGO1 = dr["codigo"].ToString();
                    }
                    if (dr["nombre"] != DBNull.Value)
                    {
                        NOMBRE1 = dr["nombre"].ToString();
                    }
                    if (dr["precio_venta"] != DBNull.Value)
                    {
                        PRECIO_VENTA1 = Convert.ToDouble(dr["precio_venta"]);
                    }
                    if (dr["stock"] != DBNull.Value)
                    {
                        STOCK1 = Convert.ToInt16(dr["stock"]);
                    }
                    if (dr["descripcion"] != DBNull.Value)
                    {
                        DESCRIPCION1 = dr["descripcion"].ToString();
                    }
                    if (dr["estado"] != DBNull.Value)
                    {
                        ESTADO1 = Convert.ToBoolean(dr["estado"]);
                    }

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                cnn.Close();
            }
        }

    }
}

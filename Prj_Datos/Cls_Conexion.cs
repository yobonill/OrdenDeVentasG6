using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Datos
{
    public class Cls_Conexion
    {
        public SqlConnection cn { get; set; }
        public static string ConectarSql()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=OrdenVentasDB; Integrated Security=True";
        }

        public string cadena;

        //SqlConnection cn;
        public Cls_Conexion()
        {
            //Obtiene la cadena de conexion desde el archivo App.config correspondiente al Ejecutable (CapaPresentacion.exe.config).
            cadena = ConfigurationManager.ConnectionStrings["Prj_Presentacion.Properties.Settings.ConectarSQL"].ConnectionString;

            cn = new SqlConnection(cadena);
        }

        public SqlConnection Opencon()
        {
            cn.Open();
            return cn;
        }

        public SqlConnection Closecon()
        {
            cn.Close();
            return cn;
        }
    }
}

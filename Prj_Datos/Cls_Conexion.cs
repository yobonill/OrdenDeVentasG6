using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Datos
{
    // clase era provada imposible conectar con clases DAL cambiada a publica, Merge will be needed
    // Referencia video 3, tiempo: 01:05:00
    public class Cls_Conexion
    {
        public SqlConnection cn { get; set; }
        public static string ConectarSql()
        {
            return @"Data Source= DESKTOP-4U3JA7M; Initial Catalog=OrdenVentasDB; Integrated Security=True";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Prj_Datos
{
    class Acceso
    {
        // Clase de acceso a datos.

        #region "Variables (Clases) de Conexion"
        private SqlConnection Conexion;
        #endregion

        //Constructor
        public Acceso()
        {
            Conexion = new SqlConnection(CadenaConexion);
        }
        private string CadenaConexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Prj_Presentacion.Properties.Settings.ConectarSQL"].ToString();
            }

        }

        public SqlConnection ObtenerConexion()
        {
            return Conexion;
        }
    }
}

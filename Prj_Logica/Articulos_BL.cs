using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Datos;
using Prj_Entidades;

namespace Prj_Logica
{
    public class Articulos_BL
    {
        ArticulosDAL Obj = new ArticulosDAL();
        public DataSet MostrarTodosLosProdutos()
        {
            return Obj.BD_Mostrar_Articulos();
        }

        public void RebajarCantidadInventario(EN_Articulos entidad)
        {
            Obj.RebajarConceptos(entidad);
        }
    }
}

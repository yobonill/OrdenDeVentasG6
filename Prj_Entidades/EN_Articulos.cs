using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Entidades
{
    public class EN_Articulos
    {
        public int ID_ARTICULO { get; set; }
        public int ID_CATEGORIA { get; set; }
        public string CODIGO { get; set; }
        public string NOMBRE{ get; set; }
        public double PRECIO_VENTA { get; set; }
        public int STOCK { get; set; }
        public string DESCRIPCION{ get; set; }
        public bool ESTADO { get; set; }
        public int? Cant_Exist { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Entidades
{
    public class EN_articulo
    {
       
        int idarticulo;
        int idcategoria;
        string codigo;
        string nombre;
        decimal precio_venta;
        int stock;
        string descripcion;
        Boolean estado;//bit

        public int Idarticulo { get => idarticulo; set => idarticulo = value; }
        public int Idcategoria { get => idcategoria; set => idcategoria = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio_venta { get => precio_venta; set => precio_venta = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }




        //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings?redirectedfrom=MSDN


    }
}

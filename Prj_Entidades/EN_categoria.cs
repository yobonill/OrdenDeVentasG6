using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Entidades
{
    public class EN_categoria
    {
       
        
        int idcategoria;
        string nombre;
        string descripcion;
        Boolean estado;//bit

        public int Idcategoria { get => idcategoria; set => idcategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }





        //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings?redirectedfrom=MSDN


    }
}

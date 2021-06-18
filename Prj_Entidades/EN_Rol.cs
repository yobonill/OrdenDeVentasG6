using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Entidades
{
    public class EN_Rol
    { 
        int    idrol;        
        string nombre;    
        string descripcion;     
        Boolean estado; //bit

        public int Idrol { get => idrol; set => idrol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}

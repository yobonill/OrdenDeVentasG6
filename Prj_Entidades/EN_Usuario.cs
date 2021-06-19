using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Entidades
{
    public class EN_Usuario
    {
        int    idusuario;    
        int    idrol;        
        string usuario;
        string password; //varbinary
        string num_documento;   
        string direccion;    
        string telefono;     
        string email;
        Boolean estado; //bit

        //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings?redirectedfrom=MSDN

        public int    Idusuario1     { get => idusuario;     set => idusuario =     value; }
        public int    Idrol1         { get => idrol;         set => idrol =         value; }
        public string Usuario1       { get => usuario;       set => usuario =       value; }
        public string Password1      { get => password;      set => password =      value; }
        public string Num_documento1 { get => num_documento; set => num_documento = value; }
        public string Direccion1     { get => direccion;     set => direccion =     value; }
        public string Telefono1      { get => telefono;      set => telefono =      value; }
        public string Email1         { get => email;         set => email =         value; }
        public bool   Estado1        { get => estado;        set => estado =        value; }
    }
}

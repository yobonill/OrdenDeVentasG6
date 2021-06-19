using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Entidades
{
    public class EN_Persona
    {
        int idpersona;
        string tipo_persona;
        string nombre;
        string tipo_documento;
        string num_documento;
        string direccion;
        string telefono;
        string email;

        public int Idpersona { get => idpersona; set => idpersona = value; }
        public string Tipo_persona { get => tipo_persona; set => tipo_persona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo_documento { get => tipo_documento; set => tipo_documento = value; }
        public string Num_documento { get => num_documento; set => num_documento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}

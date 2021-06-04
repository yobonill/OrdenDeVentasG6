using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Datos;

namespace Prj_Logica
{
    public class NE_Usuario
    {
        public bool VerificarAutenticacion(string user, string pass)
        {
            Usuario Reg = new Usuario();
            return Reg.ValidarUsuario(user, pass);
        }
    }
}

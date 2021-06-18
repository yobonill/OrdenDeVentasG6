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
    public class NE_Usuario
    {
        public bool VerificarAutenticacion(string user, string pass)
        {
            Usuario Reg = new Usuario();
            return Reg.ValidarUsuario(user, pass);
        }

        //******JOEL***********************
        //******JOEL***********************
        //******JOEL***********************
        //******JOEL***********************

        UsuarioDAL Obj = new UsuarioDAL();

        public bool BusquedaRecord(int parametro)
        {
            return Obj.ValidarRecord(parametro);
        }
        public DataSet VerTodosLosUsuarios()
        {
            return Obj.BD_Mostrar_Usuario();
        }
        public DataSet RN_Buscar_RecordUsuario(string parametro)
        {
            return Obj.Mostrar_RecordUsuario(parametro);
        }
        public DataTable RN_Buscar_UsuarioxNoUsuario(string valor)
        {
            UsuarioDAL obj = new UsuarioDAL();
            return obj.BD_Buscar_UsuarioxNoUsuarioNo(valor);
        }
        //Insertar Registro
        public void RN_Registrar_Usuario(EN_Usuario per)
        {
            Obj.BD_Registrar_usuario(per);
        }
        //Actualizar Registro
        public void RN_Actualizar_Usuario(EN_Usuario per)
        {
            Obj.BD_Actualizar_usuario(per);
        }
        //Eliminar Registro
        public void RN_Eliminar_Usuario(EN_Usuario per)
        {
            Obj.BD_Eliminar_usuario(per);
        }
        //Inhabilitar Registro
        public void RN_Inhabilitar_Usuario(EN_Usuario per)
        {
            Obj.BD_Inhabilitar_Usuario(per);
        }

        public bool VerificarAutenticacion(string text)
        {
            throw new NotImplementedException();
        }
    }
}

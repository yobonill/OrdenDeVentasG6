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
    public class NE_Rol
    {

        //******JOEL***********************

        RolDAL Obj = new RolDAL();

        public bool BusquedaRecord(int parametro)
        {
            return Obj.ValidarRecord(parametro);
        }
        public DataSet VerTodosLosrol()
        {
            return Obj.BD_Mostrar_rol();
        }
        public DataSet RN_Buscar_Recordrol(string parametro)
        {
            return Obj.Mostrar_Recordrol(parametro);
        }
        public DataTable RN_Buscar_rolxNorol(string valor)
        {
            RolDAL obj = new RolDAL();
            return obj.BD_Buscar_rolxNorolNo(valor);
        }
        //Insertar Registro
        public void RN_Registrar_rol(EN_Rol per)
        {
            Obj.BD_Registrar_rol(per);
        }
        //Actualizar Registro
        public void RN_Actualizar_rol(EN_Rol per)
        {
            Obj.BD_Actualizar_rol(per);
        }
        //Eliminar Registro
        public void RN_Eliminar_rol(EN_Rol per)
        {
            Obj.BD_Eliminar_rol(per);
        }
        //Inhabilitar Registro
        public void RN_Inhabilitar_rol(EN_Rol per)
        {
            Obj.BD_Inhabilitar_rol(per);
        }

        public bool VerificarAutenticacion(string text)
        {
            throw new NotImplementedException();
        }
    }
}

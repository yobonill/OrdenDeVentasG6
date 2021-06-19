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
    public class NE_Persona
    {

        //******JOEL***********************

        PersonaDAL Obj = new PersonaDAL();

        public bool BusquedaRecord(int parametro)
        {
            return Obj.ValidarRecord(parametro);
        }
        public DataSet VerTodosLospersona()
        {
            return Obj.BD_Mostrar_persona();
        }
        public DataSet RN_Buscar_Recordpersona(string parametro)
        {
            return Obj.Mostrar_Recordpersona(parametro);
        }
        public DataTable RN_Buscar_personaxNopersona(string valor)
        {
            PersonaDAL obj = new PersonaDAL();
            return obj.BD_Buscar_personaxNopersonaNo(valor);
        }
        //Insertar Registro
        public void RN_Registrar_persona(EN_Persona per)
        {
            Obj.BD_Registrar_persona(per);
        }
        //Actualizar Registro
        public void RN_Actualizar_persona(EN_Persona per)
        {
            Obj.BD_Actualizar_persona(per);
        }
        //Eliminar Registro
        public void RN_Eliminar_persona(EN_Persona per)
        {
            Obj.BD_Eliminar_persona(per);
        }
        //Inhabilitar Registro
        public void RN_Inhabilitar_persona(EN_Persona per)
        {
            Obj.BD_Inhabilitar_persona(per);
        }

        public bool VerificarAutenticacion(string text)
        {
            throw new NotImplementedException();
        }
    }
}

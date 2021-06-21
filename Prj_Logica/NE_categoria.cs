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
    public class NE_categoria
    {

        //******JOEL***********************

        categoriaDAL Obj = new categoriaDAL();

        public bool BusquedaRecord(int parametro)
        {
            return Obj.ValidarRecord(parametro);
        }
        public DataSet VerTodosLoscategoria()
        {
            return Obj.BD_Mostrar_categoria();
        }
        public DataSet RN_Buscar_Recordcategoria(string parametro)
        {
            return Obj.Mostrar_Recordcategoria(parametro);
        }
        public DataTable RN_Buscar_categoriaxNocategoria(string valor)
        {
            categoriaDAL obj = new categoriaDAL();
            return obj.BD_Buscar_categoriaxNocategoriaNo(valor);
        }
        //Insertar Registro
        public void RN_Registrar_categoria(EN_categoria per)
        {
            Obj.BD_Registrar_categoria(per);
        }
        //Actualizar Registro
        public void RN_Actualizar_categoria(EN_categoria per)
        {
            Obj.BD_Actualizar_categoria(per);
        }
        //Eliminar Registro
        public void RN_Eliminar_categoria(EN_categoria per)
        {
            Obj.BD_Eliminar_categoria(per);
        }
        //Inhabilitar Registro
        public void RN_Inhabilitar_categoria(EN_categoria per)
        {
            Obj.BD_Inhabilitar_categoria(per);
        }

        public bool VerificarAutenticacion(string text)
        {
            throw new NotImplementedException();
        }
    }
}

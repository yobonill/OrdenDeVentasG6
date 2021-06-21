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
    public class NE_articulo
    {

        //******JOEL***********************

        articuloDAL Obj = new articuloDAL();

        public bool BusquedaRecord(int parametro)
        {
            return Obj.ValidarRecord(parametro);
        }
        public DataSet VerTodosLosarticulo()
        {
            return Obj.BD_Mostrar_articulo();
        }
        public DataSet RN_Buscar_Recordarticulo(string parametro)
        {
            return Obj.Mostrar_Recordarticulo(parametro);
        }
        public DataTable RN_Buscar_articuloxNoarticulo(string valor)
        {
            articuloDAL obj = new articuloDAL();
            return obj.BD_Buscar_articuloxNoarticuloNo(valor);
        }
        //Insertar Registro
        public void RN_Registrar_articulo(EN_articulo per)
        {
            Obj.BD_Registrar_articulo(per);
        }
        //Actualizar Registro
        public void RN_Actualizar_articulo(EN_articulo per)
        {
            Obj.BD_Actualizar_articulo(per);
        }
        //Eliminar Registro
        public void RN_Eliminar_articulo(EN_articulo per)
        {
            Obj.BD_Eliminar_articulo(per);
        }
        //Inhabilitar Registro
        public void RN_Inhabilitar_articulo(EN_articulo per)
        {
            Obj.BD_Inhabilitar_articulo(per);
        }

        public bool VerificarAutenticacion(string text)
        {
            throw new NotImplementedException();
        }
    }
}

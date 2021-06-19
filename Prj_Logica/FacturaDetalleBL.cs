using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Datos;
using Prj_Entidades;

namespace Prj_Logica
{
    public class FacturaDetalleBL
    {
        FacturaDetalleDAL Obj = new FacturaDetalleDAL();

        public void RegRecordImp(EN_FacturaDetalle entidad)
        {
            Obj.InsertarRecord(entidad);
        }
    }
}

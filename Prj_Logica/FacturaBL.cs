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
    public class FacturaBL
    {
        FacturaDAL Obj = new FacturaDAL();
        public void RegRecordImp(EN_Factura entidad)
        {
            Obj.InsertarRecord(entidad);
        }
        public DataSet LlenarFactura()
        {
            return Obj.Ultima_Posicion();
        }
    }
}

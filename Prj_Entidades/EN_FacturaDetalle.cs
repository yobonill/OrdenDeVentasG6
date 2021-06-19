using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Entidades
{
    public class EN_FacturaDetalle
    {
        int IDDETALLE_VENTA;
        int IDVENTA;
        int IDARTICULO;
        int CANTIDAD;
        double PRECIO;
        double DESCUENTO;

        public int IDDETALLE_VENTA1 { get => IDDETALLE_VENTA; set => IDDETALLE_VENTA = value; }
        public int IDVENTA1 { get => IDVENTA; set => IDVENTA = value; }
        public int IDARTICULO1 { get => IDARTICULO; set => IDARTICULO = value; }
        public int CANTIDAD1 { get => CANTIDAD; set => CANTIDAD = value; }
        public double PRECIO1 { get => PRECIO; set => PRECIO = value; }
        public double DESCUENTO1 { get => DESCUENTO; set => DESCUENTO = value; }
    }
}

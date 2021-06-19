using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Entidades
{
    public class EN_Factura
    {
        int IDVENTA;
        int IDCLIENTE;
        int IDUSUARIO;
        string TIPO_COMPROBANTE;
        string SERIE_COMPROBANTE;
        string NUM_COMPROBANTE;
        DateTime FECHA_HORA;
        decimal IMPUESTO;
        decimal TOTAL;
        string ESTADO;

        public int IDVENTA1 { get => IDVENTA; set => IDVENTA = value; }
        public int IDCLIENTE1 { get => IDCLIENTE; set => IDCLIENTE = value; }
        public int IDUSUARIO1 { get => IDUSUARIO; set => IDUSUARIO = value; }
        public string TIPO_COMPROBANTE1 { get => TIPO_COMPROBANTE; set => TIPO_COMPROBANTE = value; }
        public string SERIE_COMPROBANTE1 { get => SERIE_COMPROBANTE; set => SERIE_COMPROBANTE = value; }
        public string NUM_COMPROBANTE1 { get => NUM_COMPROBANTE; set => NUM_COMPROBANTE = value; }
        public DateTime FECHA_HORA1 { get => FECHA_HORA; set => FECHA_HORA = value; }
        public decimal IMPUESTO1 { get => IMPUESTO; set => IMPUESTO = value; }
        public decimal TOTAL1 { get => TOTAL; set => TOTAL = value; }
        public string ESTADO1 { get => ESTADO; set => ESTADO = value; }
    }
}

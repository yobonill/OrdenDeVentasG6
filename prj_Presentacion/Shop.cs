using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Prj_Logica;
using Prj_Datos;
using Prj_Entidades;

namespace prj_Presentacion
{
    public partial class Shop : Form
    {
        public string _Usuario;
        public int contador = 1;
        public double total, cctasa, totalNeto, subtotal, Tmp_precio, Tmp_Subtotal, Tmp_Itbis;
        public double totalGeneral = 0;
        public double itbisGeneral = 0;
        public double descuentoGeneral = 0;
        public int ultposicion, TmpCia;

        DatSistema ds = new DatSistema();
        DataSet dsq = new DataSet();
        DatSistemaTableAdapters.articuloTableAdapter consulta = new DatSistemaTableAdapters.articuloTableAdapter();
        public Shop(string loggedUser)
        {
            InitializeComponent();
            _Usuario = "test";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu cargar = new mainMenu(_Usuario);
            cargar.ShowDialog();
        }
        private int buscarNumeroPosicion()
        {
            FacturaBL consulta = new FacturaBL();
            dsq = consulta.LlenarFactura();

            if (Convert.ToInt16(dsq.Tables["ultima_posicion"].Rows[0]["valor"]) > 0)
            {
                ultposicion = Convert.ToInt16(dsq.Tables["ultima_posicion"].Rows[0]["valor"]) + 1;
            }
            else
            {
                ultposicion = 1;
            }

            dsq.Tables["ultima_posicion"].Clear();
            return ultposicion;
        }

        private void txbDescuento_Leave_1(object sender, EventArgs e)
        {
            if (txbDescuento.Text.Contains("%"))
            {
                string desc = txbDescuento.Text.Replace("%", "");
                int number;
                bool success = Int32.TryParse(desc, out number);
                if (!success)
                {
                    MessageBox.Show("Favor introducir un valor correcto");
                    txbDescuento.Text = "";
                    desc = "";
                }
                if (desc == "")
                {
                    descuentoGeneral = 0;
                    calculateAll();
                }
                else
                {
                    double calcdesc = (Convert.ToInt32(desc) * totalGeneral) / 100;
                    descuentoGeneral = calcdesc;
                    calculateAll();
                }
                //txbDescuento.Text = calcdesc.ToString();
                //totalNeto = totalGeneral -calcdesc;
                //txtTotalGeneral.Text = totalNeto.ToString();
            } 
            else
            {
                int number;
                bool success = Int32.TryParse(txbDescuento.Text, out number);
                if (!success)
                {
                    MessageBox.Show("Favor introducir un valor correcto");
                    txbDescuento.Text = "";
                }
                if (txbDescuento.Text == "")
                {
                    descuentoGeneral = 0;
                    calculateAll();
                }
                else
                {
                    descuentoGeneral = Convert.ToDouble(txbDescuento.Text);
                    calculateAll();
                }
                //totalNeto = totalGeneral - Convert.ToInt32(txbDescuento.Text);
                //txtTotalGeneral.Text = totalNeto.ToString();
            }
        }

        private void Ck_Itbis_CheckedChanged(object sender, EventArgs e)
        {
            if (Ck_Itbis.Checked == true)
            {
                itbisGeneral = totalGeneral * 0.18;
                calculateAll();
            } else
            {
                itbisGeneral = 0;
                calculateAll();
            }
        }

        private void calculateAll(string remove = "")
        {
            if(remove != "")
            {
                itbisGeneral = totalGeneral * 0.18;
            }
            if (Ck_Itbis.Checked == true)
            {
                itbisGeneral = totalGeneral * 0.18;
            }
            TxtItbis.Text = itbisGeneral.ToString();
            txbDescuento.Text = descuentoGeneral.ToString();
            if(descuentoGeneral > (totalGeneral+itbisGeneral)) {
                MessageBox.Show("Descuento no puede ser mayor al total de la compra");
                descuentoGeneral = 0;
                txbDescuento.Text = "";
                calculateAll();
            }
            txtTotalGeneral.Text = (totalGeneral+itbisGeneral-descuentoGeneral).ToString();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn cargar = new LogIn();
            cargar.ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings cargar = new Settings(_Usuario);
            cargar.ShowDialog();
        }

        private void Dg_Detalles_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
            
        }

        private void Dg_Detalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.Dg_Detalles.Rows.Count > 0)
                {

                    if (MessageBox.Show("¿Está seguro de quitar de la lista el producto con el codigo " + Dg_Detalles.Rows[Dg_Detalles.CurrentRow.Index].Cells[0].Value.ToString() + "?", "Quitar Producto de lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        totalGeneral = totalGeneral - Convert.ToDouble(Dg_Detalles.Rows[Dg_Detalles.CurrentRow.Index].Cells[4].Value);
                        Dg_Detalles.Rows.RemoveAt(Dg_Detalles.CurrentRow.Index);
                        calculateAll("edit");
                        if (this.Dg_Detalles.Rows.Count == 0)
                        {
                            BtnRegistrarFactura.Enabled = false;
                        }
                    }
                }
                else
                {
                    BtnRegistrarFactura.Enabled = false;
                    MessageBox.Show("No existen Productos registrados, para eliminar");
                    calculateAll();
                }
            }

            catch (Exception)
            {

                throw;
            }
        }
        private void BtnRegistrarFactura_Click(object sender, EventArgs e)
        {
            
                FacturaBL RecI = new FacturaBL();
                EN_Factura RecImp = new EN_Factura();

                //Verificar si existe el No. de Record

                //bool valida = false;

                //valida = RecI.BusquedaRecord(int.Parse(Txt_NumeroFactura.Text));

                //if (valida)
                //{
                //    if (validar())
                //    {

                //        RecImp.Cod_factura = Convert.ToInt16(Txt_NumeroFactura.Text);
                //        RecImp.ID_CLIENTE1 = Convert.ToInt16(TxtCodCli.Text);
                //        RecImp.Total = float.Parse(Txt_TotalFacturado.Text);
                //        RecImp.Fecha_fact = Convert.ToDateTime(Dt_Fecha.Value);
                //        RecImp.Estatus1 = char.Parse(Txt_est.Text);
                //        RecImp.IdTpago1 = RetenerIdTipoPago;
                //        RecImp.Itbis1 = Convert.ToDouble(TxtItbis.Text);
                //        RecImp.FormaPago1 = Mensaje; ; //RetenerIdtIpoPago;
                //        RecImp.ID_VENDEDOR1 = int.Parse(Txt_Vendedor.Text);


                //        RecI.UpdateRecordImp(RecImp);

                //        MessageBox.Show("Registro actualizado con exito.", "Actualizar", MessageBoxButtons.OK,
                //            MessageBoxIcon.Information);
                //        //Txt_NumeroFactura.Focus();

                //        BtNuevo.PerformClick();
                //    }
                //}
                //else
                //{
                //Si dicha factura no existe la va a crear

                //if (validar()) //Si los cmpos requeridos no estan llenos, no entra para insertar
                //{

                RecImp.IDVENTA1 = ultposicion;
                RecImp.IDCLIENTE1 = Convert.ToInt32(CbClientes.SelectedValue);

                RecImp.IDUSUARIO1 = 1;
                Random random = new Random();
                DateTime localDate = DateTime.Now;
                int NullValue = 00000;
                if (Ck_ncf.Checked)
                {
                    RecImp.TIPO_COMPROBANTE1 = "NCF";
                    RecImp.SERIE_COMPROBANTE1 = random.Next(9999999).ToString();
                    RecImp.NUM_COMPROBANTE1 = random.Next(999999999).ToString();
                } else
                {
                    RecImp.TIPO_COMPROBANTE1 = "SINCOMPROBANTE";
                    RecImp.SERIE_COMPROBANTE1 = NullValue.ToString();
                    RecImp.NUM_COMPROBANTE1 = NullValue.ToString();
                }
 
                RecImp.FECHA_HORA1 = Convert.ToDateTime(localDate);
                RecImp.IMPUESTO1 = Convert.ToDecimal(itbisGeneral);
                RecImp.TOTAL1 = Convert.ToDecimal(totalGeneral);
                RecImp.ESTADO1 = "Despachada";

                RecI.RegRecordImp(RecImp);
                //Grabar Detalles de factura
                //Se van a recorrer todas las filas que contiene el datagridview

            FacturaDetalleBL RecID = new FacturaDetalleBL();
                EN_FacturaDetalle RecImpD = new EN_FacturaDetalle();

                if (Dg_Detalles.Rows.Count > 0)
                {
                    for (int i = 0; i <= Dg_Detalles.Rows.Count - 1; i++)
                    {
                        Tmp_precio = Convert.ToInt32(Dg_Detalles.Rows[i].Cells[3].Value.ToString());

                        Tmp_Subtotal = Convert.ToDouble(Dg_Detalles.Rows[i].Cells[4].Value.ToString());

                        RecImpD.IDVENTA1 = Convert.ToInt32(ultposicion);
                        RecImpD.IDARTICULO1 = Convert.ToInt32(Dg_Detalles.Rows[i].Cells[0].Value.ToString());
                        RecImpD.CANTIDAD1 = Convert.ToInt32(Dg_Detalles.Rows[i].Cells[2].Value.ToString());
                        RecImpD.PRECIO1 = Convert.ToDouble(Tmp_precio);
                        
                        RecImpD.DESCUENTO1 = Convert.ToDouble(txbDescuento.Text);
    
                        RecID.RegRecordImp(RecImpD);  //Grabar Detatalles de Factura

                        //Rebajar Inventario de Conceptos

                        Articulos_BL RecIC = new Articulos_BL();
                        EN_Articulos RecImpC = new EN_Articulos();

                        RecImpC.ID_ARTICULO = Convert.ToInt32(CbArticulos.SelectedValue);
                        RecImpC.Cant_Exist = Convert.ToInt32(Dg_Detalles.Rows[i].Cells[2].Value.ToString());

                        RecIC.RebajarCantidadInventario(RecImpC);  //Rebajar la cantidad del Inventario
                    }

                    MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                //}
                //else
                //{
                //MessageBox.Show("Hay campos que son obligatorios que se encuentran vacios.", "Error de validación", MessageBoxButtons.OK,
                // MessageBoxIcon.Error);
                //}
                //}

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datSistema.persona' table. You can move, or remove it, as needed.
            this.personaTableAdapter.Fill(this.datSistema.persona);
            try
            {
                consulta.Fill(ds.articulo);
                CbArticulos.DataSource = ds.articulo;
                CbArticulos.DisplayMember = "nombre";
                CbArticulos.ValueMember = "idarticulo";
                CbArticulosChanged();

                // Bind the SelectedValueChanged event to our handler for it.
                CbArticulos.SelectedValueChanged +=
                    new EventHandler(CbArticulos_SelectedValueChanged);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            buscarNumeroPosicion();
        }

        private void CbArticulosChanged()
        {
            try
            {
                if (CbArticulos.SelectedIndex != -1)
                {
                    //txt_cantidad.Text = CbArticulos.SelectedValue.ToString();
                    //cantidad.Maximum = Convert.ToInt16(CbArticulos.SelectedValue);
                    BtnAgregar.Enabled = true;

                    RecordArticulos Rec2 = new RecordArticulos(Convert.ToInt16(CbArticulos.SelectedValue), 0);

                    txt_cantidad.Text = Rec2.STOCK1.ToString();
                    upDownCantidad.Maximum = Convert.ToInt16(Rec2.STOCK1);
                    // If we also wanted to get the displayed text we could use
                    // the SelectedItem item property:
                    // string s = ((USState)ListBox1.SelectedItem).LongName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CbArticulos_SelectedValueChanged(object sender, EventArgs e)
        {
            CbArticulosChanged();
        }
        private void SetupColumns()
        {

            Dg_Detalles.Columns.Clear();

            Dg_Detalles.ScrollBars = ScrollBars.Both;

            Dg_Detalles.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            // Set the background color for all rows and for alternating rows.  
            // The value for alternating rows overrides the value for all rows. 
            Dg_Detalles.RowsDefaultCellStyle.BackColor = Color.LightGray;
            Dg_Detalles.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

            // Set the row and column header styles.
            Dg_Detalles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Dg_Detalles.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            Dg_Detalles.RowHeadersDefaultCellStyle.BackColor = Color.Black;

            DataGridViewTextBoxColumn IdRecordColumn = new DataGridViewTextBoxColumn();
            IdRecordColumn.DataPropertyName = "ID_PRODUCTO";
            IdRecordColumn.Width = 100;
            IdRecordColumn.HeaderText = "Referencia#";
            IdRecordColumn.Frozen = true;
            IdRecordColumn.ValueType = typeof(string);
            Dg_Detalles.Columns.Add(IdRecordColumn);

            DataGridViewTextBoxColumn CheckinColumn = new DataGridViewTextBoxColumn();
            CheckinColumn.DataPropertyName = "DESC_PRODUCTO";
            CheckinColumn.Width = 500;
            CheckinColumn.HeaderText = "Producto";
            CheckinColumn.Frozen = true;
            CheckinColumn.ValueType = typeof(string);
            Dg_Detalles.Columns.Add(CheckinColumn);

            DataGridViewTextBoxColumn VueloColumn = new DataGridViewTextBoxColumn();
            VueloColumn.DataPropertyName = "CANTIDAD";
            VueloColumn.Width = 100;
            VueloColumn.HeaderText = "Cantidad";
            VueloColumn.Frozen = true;
            VueloColumn.ValueType = typeof(string);
            Dg_Detalles.Columns.Add(VueloColumn);

            DataGridViewTextBoxColumn TipoCargaColumn = new DataGridViewTextBoxColumn();
            TipoCargaColumn.DataPropertyName = "PRECIO";
            TipoCargaColumn.Width = 175;
            TipoCargaColumn.HeaderText = "Precio";
            TipoCargaColumn.Frozen = true;
            TipoCargaColumn.ValueType = typeof(string);
            Dg_Detalles.Columns.Add(TipoCargaColumn);

            DataGridViewTextBoxColumn PesoKgColumn = new DataGridViewTextBoxColumn();
            PesoKgColumn.DataPropertyName = "TOTALS";
            PesoKgColumn.Width = 200;
            PesoKgColumn.HeaderText = "Total";
            PesoKgColumn.Frozen = true;
            PesoKgColumn.ValueType = typeof(string);
            Dg_Detalles.Columns.Add(PesoKgColumn);

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(upDownCantidad.Value) > Convert.ToInt32(txt_cantidad.Text))
            {
                MessageBox.Show("Cantidad a Despachar es mayor que la existencia");
            }
            else
            {
                RecordArticulos Rec2 = new RecordArticulos(Convert.ToInt32(CbArticulos.SelectedValue), 0);

                total = (Convert.ToInt32(upDownCantidad.Value) * Convert.ToInt32(Rec2.PRECIO_VENTA1));
                totalGeneral = totalGeneral + total;
                calculateAll();
                BtnRegistrarFactura.Enabled = true;
                //txtTotalGeneral.Text = totalGeneral.ToString();
                FSP_unEvento(Rec2.CODIGO1, Rec2.DESCRIPCION1, upDownCantidad.Value.ToString(), Rec2.PRECIO_VENTA1.ToString(), total.ToString());
            }
        }
        void FSP_unEvento(String CodProducto, String Concepto, String Cant, String Prec, String total)
        {
            int go = 1;
            if (this.Dg_Detalles.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Dg_Detalles.Rows)
                {
                    if (row.Cells[0].Value.ToString() == CodProducto)
                    {
                        go = 0;
                        //MessageBox.Show("El articulo " + row.Cells[1].Value.ToString() + " ya esta agregado");
                        if (Convert.ToInt16(Convert.ToInt32(row.Cells[2].Value) + Convert.ToInt32(Cant)) > Convert.ToInt32(txt_cantidad.Text))
                        {
                            MessageBox.Show("Cantidad a Despachar es mayor que la existencia");
                        } else { 
                            row.Cells[2].Value = Convert.ToInt32(row.Cells[2].Value) + Convert.ToInt32(Cant);
                            row.Cells[4].Value = Convert.ToInt32(row.Cells[2].Value) * Convert.ToInt32(row.Cells[3].Value);
                        }
                    }
                }
            }
            if (go == 1)
            {
                Dg_Detalles.Rows.Add();
                int actrow = this.Dg_Detalles.Rows.Count - 1;
                Dg_Detalles.Rows[actrow].Cells[0].Value = CodProducto;
                Dg_Detalles.Rows[actrow].Cells[1].Value = Concepto;
                Dg_Detalles.Rows[actrow].Cells[2].Value = Cant;
                Dg_Detalles.Rows[actrow].Cells[3].Value = Prec;
                Dg_Detalles.Rows[actrow].Cells[4].Value = total;

               // calc();
            }
        }
    }
}

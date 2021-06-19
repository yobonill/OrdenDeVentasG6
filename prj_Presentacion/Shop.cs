﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Logica;
using Prj_Datos;

namespace prj_Presentacion
{
    public partial class Shop : Form
    {
        public string _Usuario;
        public int contador = 1;
        public double total, cctasa, totalNeto, subtotal, Tmp_precio, Tmp_Subtotal;
        public double totalGeneral = 0;
        public double itbisGeneral = 0;
        public double descuentoGeneral = 0;
        DatSistema ds = new DatSistema();
        DatSistemaTableAdapters.articuloTableAdapter consulta = new DatSistemaTableAdapters.articuloTableAdapter();
        public Shop(string loggedUser)
        {
            InitializeComponent();
            _Usuario = loggedUser;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu cargar = new mainMenu(_Usuario);
            cargar.ShowDialog();
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

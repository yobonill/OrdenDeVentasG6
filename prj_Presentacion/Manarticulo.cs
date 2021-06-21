using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Logica;
using Prj_Entidades;
using Validador;


namespace prj_Presentacion
{
    public partial class Manarticulo : Form
    {
        public bool valor = false;
        public string _Codigo, _Mensaje;
        public Manarticulo()
        {
            InitializeComponent();
        }
        public Manarticulo(string codi, string mensa)
        {
            InitializeComponent();
            _Codigo = codi;
            _Mensaje = mensa;
        }


        private void Manarticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datUsuario.articulo' Puede moverla o quitarla según sea necesario.
            // this.articuloTableAdapter.Fill(this.datUsuario.articulo);

        }

        private void articuloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //  this.Validate();
            // this.articuloBindingSource.EndEdit();
            // this.tableAdapterManager.UpdateAll(this.datUsuario);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                NE_Persona RecI = new NE_Persona();
                EN_Persona RecImp = new EN_Persona();

                //Verificar si existe el No. de Record

                bool valida = false;

                if (idarticuloTextBox.Text == "")
                {
                    idarticuloTextBox.Text = "0";
                }
                valida = RecI.BusquedaRecord(int.Parse(idarticuloTextBox.Text));

                if (valida)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar de la lista de articulo a " +
                        idarticuloTextBox.Text + " " + nombreTextBox.Text + " ? ",
                        "Eliminar articulo de lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        RecImp.Idpersona = int.Parse(idarticuloTextBox.Text);
                        RecI.RN_Eliminar_persona(RecImp);

                        MessageBox.Show("Registro eliminado con exito.", "Eliminar",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        BTNLimpiar.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Persona # " + idarticuloTextBox.Text + " No existe", "Eliminar", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    BTNLimpiar.PerformClick();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void ClearErrors()
        {
            this.errorProvider1.SetError(this.nombreTextBox, null);
        }

        public bool validar()
        {
            ClearErrors();
            if (string.IsNullOrEmpty(this.nombreTextBox.Text))
            {
                this.errorProvider1.SetError(this.nombreTextBox, ValidatorMessagesR.FIELD_REQUIRED);
                valor = false;
            }
            else
            {
                ClearErrors();
                valor = true;
            }
            return valor;
        }


        private void BTNGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                NE_articulo RecI = new NE_articulo();
                EN_articulo RecImp = new EN_articulo();

                //Verificar si existe el No. de Record
                bool valida = false;

                if (idarticuloTextBox.Text == "")
                {
                    idarticuloTextBox.Text = "0";
                }
                //OJO!!! campo de texto
                valida = RecI.BusquedaRecord(int.Parse(idarticuloTextBox.Text));

                if (valida)
               {
                    if (validar())
                    {

                        RecImp.Idarticulo = int.Parse(idarticuloTextBox.Text);
                        RecImp.Idcategoria = int.Parse(idcategoriaTextBox.Text);
                        RecImp.Codigo = codigoTextBox.Text;
                        RecImp.Nombre = nombreTextBox.Text;
                        RecImp.Precio_venta = decimal.Parse(precio_ventaTextBox.Text);
                        RecImp.Stock = int.Parse(stockTextBox.Text);
                        RecImp.Descripcion = descripcionTextBox.Text;
                       
                       


                        if (estadoCheckBox.Checked == true)
                        {
                           RecImp.Estado = true;
                        }
                        else
                        {
                           RecImp.Estado = false;
                        }

                        RecI.RN_Actualizar_articulo(RecImp);

                        MessageBox.Show("Registro actualizado con exito.", "Actualizar", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        BTNLimpiar.PerformClick();
                    }
                }
                //insertar registro
                else
                {
                    if (validar())
                    {


                        RecImp.Idarticulo = int.Parse(idarticuloTextBox.Text);
                        RecImp.Idcategoria = int.Parse(idcategoriaTextBox.Text);
                        RecImp.Codigo = codigoTextBox.Text;
                        RecImp.Nombre = nombreTextBox.Text;
                        RecImp.Precio_venta = decimal.Parse(precio_ventaTextBox.Text);
                        RecImp.Stock = int.Parse(stockTextBox.Text);
                        RecImp.Descripcion = descripcionTextBox.Text;



                        if (idarticuloTextBox.Text == "")
                        {
                            idarticuloTextBox.Text = "0";
                        }
                        if (idcategoriaTextBox.Text == "")
                        {
                            idcategoriaTextBox.Text = "0";
                        }
                        if (precio_ventaTextBox.Text == "")
                        {
                            precio_ventaTextBox.Text = "0";
                        }
                        if (stockTextBox.Text == "")
                        {
                            stockTextBox.Text = "0";
                        }

                        //RecImp.Password1 = passwordTextBox.Text;
                        //RecImp.Num_documento1 = num_documentoTextBox.Text;
                        //RecImp.Direccion1 = direccionTextBox.Text;
                        //RecImp.Telefono1 = telefonoTextBox.Text;
                        //RecImp.Email1 = emailTextBox.Text;

                        if (estadoCheckBox.Checked == true)
                        {
                            RecImp.Estado = true;
                        }
                        else
                        {
                            RecImp.Estado = false;
                        }

                        RecI.RN_Registrar_articulo(RecImp);

                        MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        BTNLimpiar.PerformClick();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void idarticuloTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {

                e.Handled = true;
                //Validar si el codigo del cliente no esta en blanco

                NE_articulo obj = new NE_articulo();
                DataTable data = new DataTable();

                //hacer una busqueda en sql para filtrar el codigo del cliente que se 
                //esta buscando
                data = obj.RN_Buscar_articuloxNoarticulo(idarticuloTextBox.Text);

                //luego de buscar el codigo del cliente
                //valida si existe el codigo del cliente
                if (data.Rows.Count > 0)  //si es mayor que cero, significa que lo encontro
                {

                    idarticuloTextBox.Text = Convert.ToString(data.Rows[0]["idarticulo"]);
                    idcategoriaTextBox.Text = Convert.ToString(data.Rows[0]["idcategoria"]);
                    codigoTextBox.Text = Convert.ToString(data.Rows[0]["codigo"]);
                    nombreTextBox.Text = Convert.ToString(data.Rows[0]["nombre"]);
                    precio_ventaTextBox.Text = Convert.ToString(data.Rows[0]["precio_venta"]);
                    stockTextBox.Text = Convert.ToString(data.Rows[0]["stock"]);
                    descripcionTextBox.Text = Convert.ToString(data.Rows[0]["descripcion"]);
                    int RetenerEstado = Convert.ToInt16(data.Rows[0]["Estado"]);


                    if (RetenerEstado == 1)
                    {
                        estadoCheckBox.Checked = true;
                    }
                    else
                    {
                        estadoCheckBox.Checked = false;
                    }

                }
                //Muestra mensaje en caso de buscar este cliente y no exista
                else
                {
                    nombreTextBox.Clear();
                    precio_ventaTextBox.Text = "";

                    MessageBox.Show("articulo No. " + idarticuloTextBox.Text + " No existe");
                    idarticuloTextBox.Text = "";
                    nombreTextBox.Focus();

                }
            }

        }
        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();
            }
        }

        private void BTNAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:\Ayuda\Matenimiento_a_usuarios.pdf");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(idarticuloTextBox, idcategoriaTextBox, codigoTextBox, nombreTextBox, precio_ventaTextBox, stockTextBox, descripcionTextBox );
            idarticuloTextBox.Focus();

        }
    }
}

namespace Validador
{
    public class ValidatorMessagesA
    {
        public const string FIELD_REQUIRED = "Este campo es requerido";
    }
}

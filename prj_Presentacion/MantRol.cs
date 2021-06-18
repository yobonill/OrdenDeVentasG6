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

//using Prj_Presentacion.Reportes;


namespace prj_Presentacion
{
    public partial class MantRol : Form
    {
        public bool valor = false;
        public string _Codigo, _Mensaje;
        public MantRol()
        {
            InitializeComponent();
        }
        public MantRol(string codi, string mensa)
        {
            InitializeComponent();
            _Codigo = codi;
            _Mensaje = mensa;
        }

        private void rolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.usuarioBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.datUsuario);

        }

        private void MantRol_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datUsuario.usuario' table. You can move, or remove it, as needed.
            //this.usuarioTableAdapter.Fill(this.datUsuario.usuario);


            idrolTextBox.Text = _Codigo;
            LblMensaje.Text = _Mensaje;

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

        private void ClearErrors()
        {
           this.errorProvider1.SetError(this.nombreTextBox, null);
        }




        private void idrolTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {

                e.Handled = true;
                //Validar si el codigo del cliente no esta en blanco

                NE_Rol obj = new NE_Rol();
                DataTable data = new DataTable();

                //hacer una busqueda en sql para filtrar el codigo del cliente que se 
                //esta buscando
                data = obj.RN_Buscar_rolxNorol(idrolTextBox.Text);

                //luego de buscar el codigo del cliente
                //valida si existe el codigo del cliente
                if (data.Rows.Count > 0)  //si es mayor que cero, significa que lo encontro
                {
                    
                    idrolTextBox.Text = Convert.ToString(data.Rows[0]["idrol"]);
                    nombreTextBox.Text = Convert.ToString(data.Rows[0]["nombre"]);
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
                    descripcionTextBox.Text = "";                    

                    MessageBox.Show("Rol No. " + idrolTextBox.Text + " No existe");
                    idrolTextBox.Text = "";
                    nombreTextBox.Focus();

                }
            }
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                NE_Rol RecI = new NE_Rol();
                EN_Rol RecImp = new EN_Rol();

                //Verificar si existe el No. de Record
                bool valida = false;

                if (idrolTextBox.Text == "")
                {
                    idrolTextBox.Text = "0";
                }
                //OJO!!! campo de texto
                valida = RecI.BusquedaRecord(int.Parse(idrolTextBox.Text));

                if (valida)
                {
                    if (validar())
                    {
                        
                        RecImp.Idrol = int.Parse(idrolTextBox.Text);
                        RecImp.Nombre = nombreTextBox.Text;
                        RecImp.Descripcion = descripcionTextBox.Text;


                        if (estadoCheckBox.Checked == true)
                        {
                            RecImp.Estado = true;
                        }
                        else
                        {
                            RecImp.Estado = false;
                        }

                        RecI.RN_Actualizar_rol(RecImp);

                        MessageBox.Show("Registro actualizado con exito.", "Actualizar", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        BtnLimpiar.PerformClick();
                    }
                }
                //insertar registro
                else
                {
                    if (validar())
                    {

                        
                        RecImp.Idrol = int.Parse(idrolTextBox.Text);
                        RecImp.Nombre = nombreTextBox.Text;
                        RecImp.Descripcion = descripcionTextBox.Text;

                        //if (num_documentoTextBox.Text == "")
                        //{
                        //    num_documentoTextBox.Text = "0";
                        //}
                        //if (direccionTextBox.Text == "")
                        //{
                        //    direccionTextBox.Text = "0";
                        //}
                        //if (telefonoTextBox.Text == "")
                        //{
                        //    telefonoTextBox.Text = "0";
                        //}
                        //if (emailTextBox.Text == "")
                        //{
                        //    emailTextBox.Text = "0";
                        //}

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

                        RecI.RN_Registrar_rol(RecImp);

                        MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        BtnLimpiar.PerformClick();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar(idrolTextBox, nombreTextBox, descripcionTextBox);
            idrolTextBox.Focus();

            //Cargar los Registros de los Clientes
            //MostrarTodoslosRegistrosCargadosProductos();
        }

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                NE_Rol RecI = new NE_Rol();
                EN_Rol RecImp = new EN_Rol();

                //Verificar si existe el No. de Record

                bool valida = false;

                if (idrolTextBox.Text == "")
                {
                    idrolTextBox.Text = "0";
                }
                valida = RecI.BusquedaRecord(int.Parse(idrolTextBox.Text));

                if (valida)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar de la lista el Rol " +
                        idrolTextBox.Text + " " + nombreTextBox.Text + " ? ",
                        "Eliminar Rol de lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        RecImp.Idrol = int.Parse(idrolTextBox.Text);
                        RecI.RN_Eliminar_rol(RecImp);

                        MessageBox.Show("Registro eliminado con exito.", "Eliminar",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        BtnLimpiar.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Rol # " + idrolTextBox.Text + " No existe", "Eliminar", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    BtnLimpiar.PerformClick();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void BtnAyuda_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:\Ayuda\Matenimiento_a_usuarios.pdf");
        }

        private void BtnImprimir_Click_1(object sender, EventArgs e)
        {
        }


        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();
            }
        }
    }
}

namespace Validador
{
    public class ValidatorMessagesR
    {
        public const string FIELD_REQUIRED = "Este campo es requerido";
    }
}




//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace prj_Presentacion
//{
//    public partial class MantRol : Form
//    {
//        public MantRol()
//        {
//            InitializeComponent();
//        }

//        private void rolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
//        {
//            //this.Validate();
//            //this.rolBindingSource.EndEdit();
//            //this.tableAdapterManager.UpdateAll(this.datUsuario);

//        }

//        private void MantRol_Load(object sender, EventArgs e)
//        {
//            // TODO: This line of code loads data into the 'datUsuario.rol' table. You can move, or remove it, as needed.
//            //this.rolTableAdapter.Fill(this.datUsuario.rol);

//        }

//    }
//}

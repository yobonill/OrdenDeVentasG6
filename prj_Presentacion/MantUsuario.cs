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
    public partial class MantUsuario : Form
    {
        public bool valor = false;
        public string _Codigo, _Mensaje;
        public MantUsuario()
        {
            InitializeComponent();
        }
        public MantUsuario(string codi, string mensa)
        {
            InitializeComponent();
            _Codigo = codi;
            _Mensaje = mensa;
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.usuarioBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.datUsuario);

        }

        private void usuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            //this.Validate();
            //this.usuarioBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.datUsuario);

        }

        private void MantUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datUsuario.usuario' table. You can move, or remove it, as needed.
            //this.usuarioTableAdapter.Fill(this.datUsuario.usuario);


            idusuarioTextBox.Text = _Codigo;
            LblMensaje.Text = _Mensaje;

        }
        public bool validar()
        {
            ClearErrors();
            if (string.IsNullOrEmpty(this.idusuarioTextBox.Text))
            {
                this.errorProvider1.SetError(this.idusuarioTextBox, ValidatorMessages.FIELD_REQUIRED);
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
            this.errorProvider1.SetError(this.idusuarioTextBox, null);
        }


  

        private void idusuarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {

                e.Handled = true;
                //Validar si el codigo del cliente no esta en blanco

                NE_Usuario obj = new NE_Usuario();
                DataTable data = new DataTable();

                //hacer una busqueda en sql para filtrar el codigo del cliente que se 
                //esta buscando
                data = obj.RN_Buscar_UsuarioxNoUsuario(idusuarioTextBox.Text);

                //luego de buscar el codigo del cliente
                //valida si existe el codigo del cliente
                if (data.Rows.Count > 0)  //si es mayor que cero, significa que lo encontro
                {
                    idusuarioTextBox.Text = Convert.ToString(data.Rows[0]["idusuario"]);
                    idrolTextBox.Text = Convert.ToString(data.Rows[0]["idrol"]);
                    usuarioTextBox.Text = Convert.ToString(data.Rows[0]["usuario"]);
                    passwordTextBox.Text = Convert.ToString(data.Rows[0]["password"]);
                    num_documentoTextBox.Text = Convert.ToString(data.Rows[0]["num_documento"]);
                    direccionTextBox.Text = Convert.ToString(data.Rows[0]["direccion"]);
                    telefonoTextBox.Text = Convert.ToString(data.Rows[0]["telefono"]);
                    emailTextBox.Text = Convert.ToString(data.Rows[0]["email"]);
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
                    usuarioTextBox.Clear();
                    num_documentoTextBox.Text = "";
                    direccionTextBox.Text = "";

                    MessageBox.Show("Usuario No. " + idusuarioTextBox.Text + " No existe");
                    idusuarioTextBox.Text = "";
                    usuarioTextBox.Focus();

                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                NE_Usuario RecI = new NE_Usuario();
                EN_Usuario RecImp = new EN_Usuario();

                //Verificar si existe el No. de Record
                bool valida = false;

                if (idusuarioTextBox.Text == "")
                {
                    idusuarioTextBox.Text = "0";
                }
                //OJO!!! campo de texto
                valida = RecI.BusquedaRecord(int.Parse(idusuarioTextBox.Text));

                if (valida)
                {
                    if (validar())
                    {
                        RecImp.Idusuario1 = int.Parse(idusuarioTextBox.Text);
                        RecImp.Idrol1 = int.Parse(idrolTextBox.Text);
                        RecImp.Usuario1 = usuarioTextBox.Text;
                        RecImp.Password1 = passwordTextBox.Text;
                        RecImp.Num_documento1 = num_documentoTextBox.Text;
                        RecImp.Direccion1 = direccionTextBox.Text;
                        RecImp.Telefono1 = telefonoTextBox.Text;
                        RecImp.Email1 = emailTextBox.Text;


                        if (estadoCheckBox.Checked == true)
                        {
                            RecImp.Estado1 = true;
                        }
                        else
                        {
                            RecImp.Estado1 = false;
                        }

                        RecI.RN_Actualizar_Usuario(RecImp);

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

                        RecImp.Idusuario1 = int.Parse(idusuarioTextBox.Text);
                        RecImp.Idrol1 = int.Parse(idrolTextBox.Text);
                        RecImp.Usuario1 = usuarioTextBox.Text;

                        


                        if (passwordTextBox.Text == "")
                        {
                            passwordTextBox.Text = "0";
                        }
                        if (num_documentoTextBox.Text == "")
                        {
                            num_documentoTextBox.Text = "0";
                        }
                        if (direccionTextBox.Text == "")
                        {
                            direccionTextBox.Text = "0";
                        }
                        if (telefonoTextBox.Text == "")
                        {
                            telefonoTextBox.Text = "0";
                        }
                        if (emailTextBox.Text == "")
                        {
                            emailTextBox.Text = "0";
                        }

                        RecImp.Password1 = passwordTextBox.Text;
                        RecImp.Num_documento1 = num_documentoTextBox.Text;
                        RecImp.Direccion1 = direccionTextBox.Text;
                        RecImp.Telefono1 = telefonoTextBox.Text;
                        RecImp.Email1 = emailTextBox.Text;

                        if (estadoCheckBox.Checked == true)
                        {
                            RecImp.Estado1 = true;
                        }
                        else
                        {
                            RecImp.Estado1 = false;
                        }

                        RecI.RN_Registrar_Usuario(RecImp);

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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(idusuarioTextBox, idrolTextBox, usuarioTextBox, passwordTextBox, num_documentoTextBox,direccionTextBox, telefonoTextBox, emailTextBox);
            idusuarioTextBox.Focus();

            //Cargar los Registros de los Clientes
            //MostrarTodoslosRegistrosCargadosProductos();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                NE_Usuario RecI = new NE_Usuario();
                EN_Usuario RecImp = new EN_Usuario();

                //Verificar si existe el No. de Record

                bool valida = false;

                if (idusuarioTextBox.Text == "")
                {
                    idusuarioTextBox.Text = "0";
                }
                valida = RecI.BusquedaRecord(int.Parse(idusuarioTextBox.Text));

                if (valida)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar de la lista el Usuario " +
                        idusuarioTextBox.Text + " " + usuarioTextBox.Text + " ? ",
                        "Eliminar Usuario de lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        RecImp.Idusuario1 = int.Parse(idusuarioTextBox.Text);
                        RecI.RN_Eliminar_Usuario(RecImp);

                        MessageBox.Show("Registro eliminado con exito.", "Eliminar",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        BtnLimpiar.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario # " + idusuarioTextBox.Text + " No existe", "Eliminar", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    BtnLimpiar.PerformClick();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void idusuarioTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
          
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:\Ayuda\matenimiento a usuarios.Pdf");
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
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
    public class ValidatorMessages
    {
        public const string FIELD_REQUIRED = "Este campo es requerido";
    }
}
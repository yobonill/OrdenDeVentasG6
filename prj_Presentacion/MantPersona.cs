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
    public partial class MantPersona : Form
    {
        public bool valor = false;
        public string _Codigo, _Mensaje;
        public MantPersona()
        {
            InitializeComponent();
        }

        public MantPersona(string codi, string mensa)
        {
            InitializeComponent();
            _Codigo = codi;
            _Mensaje = mensa;
        }


        private void personaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.personaBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.datUsuario);

        }

        private void MantPersona_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datUsuario.persona' table. You can move, or remove it, as needed.
            //this.personaTableAdapter.Fill(this.datUsuario.persona);

            idpersonaTextBox.Text = _Codigo;
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

        private void idpersonaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {

                e.Handled = true;
                //Validar si el codigo del cliente no esta en blanco

                NE_Persona obj = new NE_Persona();
                DataTable data = new DataTable();

                //hacer una busqueda en sql para filtrar el codigo del cliente que se 
                //esta buscando
                data = obj.RN_Buscar_personaxNopersona(idpersonaTextBox.Text);

                //luego de buscar el codigo del cliente
                //valida si existe el codigo del cliente
                if (data.Rows.Count > 0)  //si es mayor que cero, significa que lo encontro
                {

                    idpersonaTextBox.Text = Convert.ToString(data.Rows[0]["idpersona"]);
                    tipo_personaTextBox.Text = Convert.ToString(data.Rows[0]["tipo_persona"]);
                    nombreTextBox.Text = Convert.ToString(data.Rows[0]["nombre"]);
                    tipo_documentoTextBox.Text = Convert.ToString(data.Rows[0]["tipo_documento"]);
                    num_documentoTextBox.Text = Convert.ToString(data.Rows[0]["num_documento"]);
                    direccionTextBox.Text = Convert.ToString(data.Rows[0]["direccion"]);
                    telefonoTextBox.Text = Convert.ToString(data.Rows[0]["telefono"]);
                    emailTextBox.Text = Convert.ToString(data.Rows[0]["email"]);
                    
                    //if (RetenerEstado == 1)
                    //{
                    //    estadoCheckBox.Checked = true;
                    //}
                    //else
                    //{
                    //    estadoCheckBox.Checked = false;
                    //}

                }
                //Muestra mensaje en caso de buscar este cliente y no exista
                else
                {
                    nombreTextBox.Clear();
                    tipo_documentoTextBox.Text = "";

                    MessageBox.Show("Persona No. " + idpersonaTextBox.Text + " No existe");
                    idpersonaTextBox.Text = "";
                    nombreTextBox.Focus();

                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                NE_Persona RecI = new NE_Persona();
                EN_Persona RecImp = new EN_Persona();

                //Verificar si existe el No. de Record
                bool valida = false;

                if (idpersonaTextBox.Text == "")
                {
                    idpersonaTextBox.Text = "0";
                }
                //OJO!!! campo de texto
                valida = RecI.BusquedaRecord(int.Parse(idpersonaTextBox.Text));

                if (valida)
                {
                    if (validar())
                    {

                        RecImp.Idpersona = int.Parse(idpersonaTextBox.Text);
                        RecImp.Tipo_persona = tipo_personaTextBox.Text;
                        RecImp.Nombre = nombreTextBox.Text;
                        RecImp.Tipo_documento = tipo_documentoTextBox.Text;
                        RecImp.Num_documento = num_documentoTextBox.Text;
                        RecImp.Direccion = direccionTextBox.Text;
                        RecImp.Telefono = telefonoTextBox.Text;
                        RecImp.Email = emailTextBox.Text;


                        //if (estadoCheckBox.Checked == true)
                        //{
                        //    RecImp.Estado = true;
                        //}
                        //else
                        //{
                        //    RecImp.Estado = false;
                        //}

                        RecI.RN_Actualizar_persona(RecImp);

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


                        RecImp.Idpersona = int.Parse(idpersonaTextBox.Text);
                        RecImp.Tipo_persona = tipo_personaTextBox.Text;
                        RecImp.Nombre = nombreTextBox.Text;
                        RecImp.Tipo_documento = tipo_documentoTextBox.Text;
                        RecImp.Num_documento = num_documentoTextBox.Text;
                        RecImp.Direccion = direccionTextBox.Text;
                        RecImp.Telefono = telefonoTextBox.Text;
                        RecImp.Email = emailTextBox.Text;


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

                        //if (estadoCheckBox.Checked == true)
                        //{
                        //    RecImp.Estado = true;
                        //}
                        //else
                        //{
                        //    RecImp.Estado = false;
                        //}

                        RecI.RN_Registrar_persona(RecImp);

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

            Limpiar(idpersonaTextBox, tipo_personaTextBox, nombreTextBox, tipo_documentoTextBox, num_documentoTextBox, direccionTextBox, telefonoTextBox, emailTextBox);
            idpersonaTextBox.Focus();
        }

        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                NE_Persona RecI = new NE_Persona();
                EN_Persona RecImp = new EN_Persona();

                //Verificar si existe el No. de Record

                bool valida = false;

                if (idpersonaTextBox.Text == "")
                {
                    idpersonaTextBox.Text = "0";
                }
                valida = RecI.BusquedaRecord(int.Parse(idpersonaTextBox.Text));

                if (valida)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar de la lista de personas a " +
                        idpersonaTextBox.Text + " " + nombreTextBox.Text + " ? ",
                        "Eliminar Persona de lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        RecImp.Idpersona = int.Parse(idpersonaTextBox.Text);
                        RecI.RN_Eliminar_persona(RecImp);

                        MessageBox.Show("Registro eliminado con exito.", "Eliminar",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        BtnLimpiar.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Persona # " + idpersonaTextBox.Text + " No existe", "Eliminar", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    BtnLimpiar.PerformClick();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:\Ayuda\Matenimiento_a_usuarios.pdf");
        }

        private void ClearErrors()
        {
            this.errorProvider1.SetError(this.nombreTextBox, null);
        }

    }


    namespace Validador
    {
        public class ValidatorMessagesR
        {
            public const string FIELD_REQUIRED = "Este campo es requerido";
        }
    }




}

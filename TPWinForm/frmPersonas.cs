using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm
{
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();
        }

        private List<Persona> listadoPersonas = new List<Persona>();
        private BindingList<Persona> listaBindeable;

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            lblEdad.Text = "Edad: " + EdadPersona(dtpNacimiento.Value);
            cboColor.Items.Add("Rojo");
            cboColor.Items.Add("Azul");
            cboColor.Items.Add("Amarillo");
            cboColor.Items.Add("Verde");
            cboColor.Items.Add("Violeta");
            listaBindeable = new BindingList<Persona>(listadoPersonas);
            dgvPersonas.DataSource = listaBindeable;
        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            lblEdad.Text = "Edad: " + EdadPersona(dtpNacimiento.Value);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //  No pregunto por el sexo porque tiene opcion por default, y no pregunto por el género
            //favorito porque puede no gustarle ninguno de los que está en las opciones.
            if (txtNombre.Text.Trim()=="" || txtApellido.Text.Trim()=="" || cboColor.SelectedIndex < 0)
            {
                MessageBox.Show("Complete todos los campos!");
                return;
            }
            Persona persona = new Persona();
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            if (rbtnMasculino.Checked) persona.Sexo = 'M';
            if (rbtnFemenino.Checked) persona.Sexo = 'F';
            if (rbtnOtro.Checked) persona.Sexo = 'O';
            persona.FechaNacimiento = dtpNacimiento.Value;
            persona.GenerosFavoritos[0] = chbClasica.Checked;
            persona.GenerosFavoritos[1] = chbRock.Checked;
            persona.GenerosFavoritos[2] = chbRap.Checked;
            persona.GenerosFavoritos[3] = chbJazz.Checked;
            persona.GenerosFavoritos[4] = chbCumbia.Checked;
            persona.GenerosFavoritos[5] = chbTango.Checked;
            persona.ColorFavorito = Color(cboColor.SelectedIndex);
            listadoPersonas.Add(persona);
            listaBindeable.ResetBindings();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            rbtnMasculino.Checked = true;
            dtpNacimiento.Value = DateTime.Now;
            chbClasica.Checked = false;
            chbCumbia.Checked = false;
            chbJazz.Checked = false;
            chbRap.Checked = false;
            chbRock.Checked = false;
            chbTango.Checked = false;
            cboColor.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Object seleccionado = dgvPersonas.CurrentRow.DataBoundItem;
            Persona personaSeleccionada = (Persona)seleccionado;
            listadoPersonas.Remove(personaSeleccionada);
            listaBindeable.ResetBindings();
        }

        //Métodos auxiliares
        private int EdadPersona(DateTime FechaNacimiento)
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now.Month < FechaNacimiento.Month)
            {
                edad--;
            }
            else if (DateTime.Now.Day < FechaNacimiento.Day)
            {
                edad--;
            }
            if (edad < 0)
                edad = 0;

            return edad;
        }

        private string Color(int index)
        {
            switch (index)
            {
                case 0: return "Rojo";
                case 1: return "Azul";
                case 2: return "Amarillo";
                case 3: return "Verde";
                case 4: return "Violeta";
                default: return "";
            }
        }

    }
}

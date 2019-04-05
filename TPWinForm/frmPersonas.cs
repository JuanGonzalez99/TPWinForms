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

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            cboColor.Items.Add("Rojo");
            cboColor.Items.Add("Azul");
            cboColor.Items.Add("Amarillo");
            cboColor.Items.Add("Verde");
            cboColor.Items.Add("Violeta");
        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            lblEdad.Text = "Edad: " + EdadPersona(dtpNacimiento.Value);
        }

        //Método auxiliar para calcular la edad
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
    }
}

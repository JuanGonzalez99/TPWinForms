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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmPersonas))
                {
                    form.Activate();
                    return;
                }
            }

            frmPersonas ventana = new frmPersonas();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void objetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmObjetos))
                {
                    form.Activate();
                    return;
                }
            }

            frmObjetos ventana = new frmObjetos();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}

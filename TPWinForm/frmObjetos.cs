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
    public partial class frmObjetos : Form
    {
        //Atributos para las listas
        private List<string> listaIzq = new List<string>();
        private BindingList<string> listaBindeableI;
        private List<string> listaDer = new List<string>();
        private BindingList<string> listaBindeableD;

        public frmObjetos()
        {
            InitializeComponent();
        }

        private void frmObjetos_Load(object sender, EventArgs e)
        {
            listaBindeableI = new BindingList<string>(listaIzq);
            ListaIzquierda.DataSource = listaBindeableI;
            listaBindeableD = new BindingList<string>(listaDer);
            ListaDerecha.DataSource = listaBindeableD;
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtObjeto.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre!", "Advertencia");
                return;
            }
            listaIzq.Add(txtObjeto.Text.Trim());
            refrescarListas();
        }

        private void btnMoverTodos_Click(object sender, EventArgs e)
        {
            if (listaIzq.Count < 1)
            {
                MessageBox.Show("No hay objetos en la lista para trasladar", "Advertencia");
                return;
            }
            if (hayRepeticion())
            {
                MessageBox.Show("Hay objetos repetidos", "Advertencia");
                return;
            }
            foreach (var objeto in listaIzq)
            {
                listaDer.Add(objeto);
            }
            listaIzq.RemoveRange(0, listaIzq.Count);
            refrescarListas();
        }

        private void btnMoverDerecha_Click(object sender, EventArgs e)
        {
            if (ListaIzquierda.SelectedIndex < 0)
            {
                MessageBox.Show("No ha seleccionado ningún objeto", "Advertencia");
                return;
            }
            if(hayRepeticion(listaIzq[ListaIzquierda.SelectedIndex]))
            {
                MessageBox.Show("Ese objeto ya se encuentra en la lista de la derecha", "Advertencia");
                return;
            }
            listaDer.Add(listaIzq[ListaIzquierda.SelectedIndex]);
            listaIzq.RemoveAt(ListaIzquierda.SelectedIndex);
            refrescarListas();
        }

        private void btnMoverIzquierda_Click(object sender, EventArgs e)
        {
            if (ListaDerecha.SelectedIndex < 0)
            {
                MessageBox.Show("No ha seleccionado ningún objeto", "Advertencia");
                return;
            }
            listaIzq.Add(listaDer[ListaDerecha.SelectedIndex]);
            listaDer.RemoveAt(ListaDerecha.SelectedIndex);
            refrescarListas();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (ListaDerecha.SelectedIndex < 0)
            {
                MessageBox.Show("No ha seleccionado ningún objeto", "Advertencia");
                return;
            }
            if(MessageBox.Show("Está seguro que desea borrar este objeto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            listaDer.RemoveAt(ListaDerecha.SelectedIndex);
            refrescarListas();
        }

        //Métodos auxiliares
        private bool hayRepeticion()
        {
            foreach (var objeto in listaIzq)
            {
                foreach (var item in listaDer)
                {
                    if (objeto == item)
                        return true;
                }
            }
            return false;
        }
        private bool hayRepeticion(string objeto)
        {
            foreach (var item in listaDer)
            {
                if (item == objeto)
                    return true;
            }
            return false;
        }

        private void refrescarListas()
        {
            listaBindeableI.ResetBindings();
            listaBindeableD.ResetBindings();
        }

    }
}

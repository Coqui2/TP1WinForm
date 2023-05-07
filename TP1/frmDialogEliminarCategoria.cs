using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class frmDialogEliminarCategoria : Form
    {
        private Categoria categoriaSeleccionada;
        public frmDialogEliminarCategoria(Categoria aux)
        {
            InitializeComponent();
            categoriaSeleccionada = aux;
            labelConfirmacionEliminar.Text = "¿Está seguro que desea eliminar la categoría " + aux.Nombre + "?";
        }
        private void eliminarCategoria()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            negocio.eliminar(categoriaSeleccionada.Codigo);
            MessageBox.Show("Categoría eliminada con éxito");
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDialogEliminarCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner.GetType() == typeof(Form2))
            {
                ((Form2)this.Owner).reload();
                return;
            }
            else if (this.Owner.GetType() == typeof(frmListadoCategorias)) { 
                ((frmListadoCategorias)this.Owner).reload();
                return;
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            eliminarCategoria();
        }

        private void frmDialogEliminarCategoria_Load(object sender, EventArgs e)
        {
            btnEliminarCategoria.Focus();
        }

        private void btnEliminarCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                eliminarCategoria();
                return;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}

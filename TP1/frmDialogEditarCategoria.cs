using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class frmDialogEditarCategoria : Form
    {
        private Categoria categoriaSeleccionada;

        private void modificar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            categoriaSeleccionada.Nombre = textBoxNombreCategoria.Text;
            negocio.modificar(categoriaSeleccionada);
            MessageBox.Show("Categoría modificada con exito");
            this.Close();
        }
        public frmDialogEditarCategoria(Categoria aux)
        {
            InitializeComponent();
            categoriaSeleccionada = aux;
            textBoxNombreCategoria.Text = categoriaSeleccionada.Nombre;
            this.Text = "Editar Categoría " + categoriaSeleccionada.Nombre + "";

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void textBoxNombreCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                modificar();
                return;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void frmDialogEditarCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmListadoCategorias)this.Owner).reload();
        }

    }
}

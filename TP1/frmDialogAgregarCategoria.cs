using Controlador;
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
    public partial class frmDialogAgregarCategoria : Form
    {
        public frmDialogAgregarCategoria()
        {
            InitializeComponent();
        }
        private void agregarCategoria()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            if (textBoxNombreCategoria.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre para la categoría");
                return;
            }
            negocio.agregar(textBoxNombreCategoria.Text);
            MessageBox.Show("Categoría agregada con exito");
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNombreCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                agregarCategoria();
                return;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void frmDialogAgregarCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                ((frmListadoCategorias)this.Owner).reload();
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            agregarCategoria();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;

namespace TP1
{
    public partial class frmDialogEliminarMarca : Form
    {
        Marca marca;
        public frmDialogEliminarMarca(Marca aux)
        {
            InitializeComponent();
            marca = aux;
            labelConfirmacionEliminar.Text = "¿Está seguro que desea eliminar la marca " + marca.Nombre + "?";
        }

        private void eliminarMarca()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            negocio.eliminar(marca.Codigo);
            MessageBox.Show("Marca eliminada con éxito");
            this.Close();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                eliminarMarca();
                return;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            eliminarMarca();
        }

        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmListadoMarcas)this.Owner).reload();
        }
    }
}

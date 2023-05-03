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
    public partial class frmDialogEliminarArticulo : Form
    {
        private Articulo artSeleccionado;
        public frmDialogEliminarArticulo(Articulo aux)
        {
            InitializeComponent();
            labelConfirmacionEliminar.Text = "¿Desea eliminar el artículo " + aux.Nombre + "?";
            artSeleccionado = aux;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            //ArticuloNegocio negocio = new ArticuloNegocio();
            //negocio.eliminar(artSeleccionado.Id);
            MessageBox.Show("Articulo eliminado con exito");
            this.Close();
        }
    }
}

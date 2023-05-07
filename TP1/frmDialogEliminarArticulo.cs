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
            this.Text = "Eliminar " + aux.Nombre;
            labelConfirmacionEliminar.Text = "¿Desea eliminar el artículo " + aux.Nombre + "?";
            artSeleccionado = aux;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
              negocio.eliminar(artSeleccionado.Id);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Articulo eliminado con exito");
            this.Close();
        }

        private void frmDialogEliminarArticulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner.GetType() == typeof(Form2))
            {
                ((Form2)this.Owner).reload();
                return;
            }
            else if (this.Owner.GetType() == typeof(frmListadoCategorias))
            {
                ((frmListadoCategorias)this.Owner).reload();
                return;
            }
            else if (this.Owner.GetType() == typeof(frmDialogVerArticulo))
            {
                ((frmDialogVerArticulo)this.Owner).Close();
            }
        }
    }
}

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
    public partial class frmDialogEditarMarca : Form
    {
        private Marca marcaSeleccionada;
        private void modificar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            marcaSeleccionada.Nombre = textBoxNombreMarca.Text;
            negocio.modificar(marcaSeleccionada);
            MessageBox.Show("Marca modificada con exito");
            this.Close();
        }
        public frmDialogEditarMarca(Marca aux)
        {
            InitializeComponent();
            marcaSeleccionada = aux;
            textBoxNombreMarca.Text = marcaSeleccionada.Nombre;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            modificar();
        }

        
        private void onTxtBoxKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                modificar();
                return;
            }
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmListadoMarcas)this.Owner).reload();
        }
    }
}

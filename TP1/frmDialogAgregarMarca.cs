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
    public partial class frmDialogAgregarMarca : Form
    {
        public frmDialogAgregarMarca()
        {
            InitializeComponent();
        }

        private void agregarMarca()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            if(textBoxNombreMarca.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de marca");
                return;
            }
            negocio.agregar(textBoxNombreMarca.Text);
            MessageBox.Show("Marca agregada con exito");
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                agregarMarca();
                return;
            }
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            agregarMarca();
        }

        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Owner != null)
            {
                ((frmListadoMarcas)this.Owner).reload();
            }
        }
    }
}

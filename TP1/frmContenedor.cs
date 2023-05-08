using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class ContenedorPrincipal : Form
    {
        public ContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }


        private void listarArticulosMenu_Click(object sender, EventArgs e)
        {
            foreach(Form form in Application.OpenForms)
            {
                if(form.GetType()==typeof(Form2))
                {
                    form.Focus();
                    return;
                }
            }


            Form2 form2 = new Form2();
            form2.MdiParent= this;
            form2.Show();
        }

        
        private void artículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDialogAgregarArticulo form = new frmDialogAgregarArticulo();
            form.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDialogAgregarMarca form = new frmDialogAgregarMarca();
            form.ShowDialog();
        }

        private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDialogAgregarCategoria form = new frmDialogAgregarCategoria();
            form.ShowDialog();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form2))
                {
                    form.Focus();
                    return;
                }
            }
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmListadoMarcas))
                {
                    form.Focus();
                    return;
                }
            }
            frmListadoMarcas form4 = new frmListadoMarcas();
            form4.MdiParent = this;
            form4.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmListadoCategorias))
                {
                    form.Focus();
                    return;
                }
            }
            frmListadoCategorias form5 = new frmListadoCategorias();
            form5.MdiParent = this;
            form5.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }
    }
}




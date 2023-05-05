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

        private void listarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void listarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void listarCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void porCódigoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmBuscarArticuloCod))
                {
                    form.Focus();
                    return;
                }
            }
            frmBuscarArticuloCod form6 = new frmBuscarArticuloCod();
            form6.MdiParent = this;
            form6.Show();

        }

        private void porNombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmBuscarArticuloNombre))
                {
                    form.Focus();
                    return;
                }
            }
            frmBuscarArticuloNombre form7 = new frmBuscarArticuloNombre();
            form7.MdiParent = this;
            form7.Show();

        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmBuscarMarca))
                {
                    form.Focus();
                    return;
                }
            }
            frmBuscarMarca form8 = new frmBuscarMarca();
            form8.MdiParent = this;
            form8.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmBuscarCategoria))
                {
                    form.Focus();
                    return;
                }
            }
            frmBuscarCategoria form9 = new frmBuscarCategoria();
            form9.MdiParent = this;
            form9.Show();

        }

        
        private void artículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDialogAgregarArticulo form = new frmDialogAgregarArticulo();
            form.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDialogAgregarMarca form= new frmDialogAgregarMarca();
            form.ShowDialog();
        }

        private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDialogAgregarCategoria form = new frmDialogAgregarCategoria();
            form.ShowDialog();
        }
    }
}




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

        private void articuloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmBuscarArticulo))
                {
                    form.Focus();
                    return;
                }
            }
            frmBuscarArticulo form10 = new frmBuscarArticulo();
            form10.MdiParent = this;
            form10.Show();
        }

        private void MarcasBuscarToolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void buscarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void AgregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmDialogAgregarArticulo form11 = new frmDialogAgregarArticulo();
            form11.ShowDialog();
        }

        private void marcaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            frmDialogAgregarMarca form12 = new frmDialogAgregarMarca();
            form12.ShowDialog();
        }

        private void agregarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDialogAgregarCategoria form13 = new frmDialogAgregarCategoria();
            form13.ShowDialog();
        }

        private void ModificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDialogEditarArticulo form14 = new frmDialogEditarArticulo();
            form14.ShowDialog();
        }

        private void categoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            frmDialogEditarMarca form = new frmDialogEditarMarca();
            form.ShowDialog();
        }

        private void editarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmDialogEditarCategoria form = new frmDialogEditarCategoria();
            form.ShowDialog();
        }

        private void eliminarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmDialogEliminarCategoria form = new frmDialogEliminarCategoria();
            form.ShowDialog();
        }

        private void eliminarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            frmDialogEliminarMarca form = new frmDialogEliminarMarca();
            form.ShowDialog();
        }

        private void VerDetallesArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmDialogVerArticulo form = new frmDialogVerArticulo();
            form.ShowDialog();
        }
    }
}




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

        }


        private void listarArticulosMenu_Click(object sender, EventArgs e)
        {
            foreach(Form form in Application.OpenForms)
            {
                if(form.GetType()==typeof(Form2))
                {
                    form.Focus();
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
                if (form.GetType() == typeof(Form2) || form.GetType() == typeof(frmListadoMarcas))
                {
                    form.Focus();
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
                }
            }
            frmBuscarCategoria form9 = new frmBuscarCategoria();
            form9.MdiParent = this;
            form9.Show();
        }

        private void AgregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmDialogAgregarArticulo))
                {
                    return;
                }
            }
            frmDialogAgregarArticulo form11 = new frmDialogAgregarArticulo();
            form11.ShowDialog();
        }

        private void marcaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmDialogAgregarMarca))
                {
                    return;
                }
            }
            frmDialogAgregarMarca form12 = new frmDialogAgregarMarca();
            form12.ShowDialog();
        }

        private void agregarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmDialogAgregarCategoria))
                {
                    return;
                }
            }
            frmDialogAgregarCategoria form13 = new frmDialogAgregarCategoria();
            form13.ShowDialog();
        }

        private void ModificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmDialogEditarArticulo))
                {
                    return;
                }
            }
            frmDialogEditarArticulo form14 = new frmDialogEditarArticulo();
            form14.ShowDialog();
        }

        private void categoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmDialogEditarMarca))
                {
                    return;
                }
            }
            frmDialogEditarMarca form = new frmDialogEditarMarca();
            form.ShowDialog();
        }

        private void editarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmDialogEditarCategoria))
                {
                    return;
                }
            }
            frmDialogEditarCategoria form = new frmDialogEditarCategoria();
            form.ShowDialog();
        }

        private void eliminarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmDialogEliminarCategoria))
                {
                    return;
                }
            }
            frmDialogEliminarCategoria form = new frmDialogEliminarCategoria();
            form.ShowDialog();
        }

        private void eliminarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmDialogEliminarMarca))
                {
                    return;
                }
            }
            frmDialogEliminarMarca form = new frmDialogEliminarMarca();
            form.ShowDialog();
        }

        private void VerDetallesArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmDialogVerArticulo))
                {
                    return;
                }
            }
            frmDialogVerArticulo form = new frmDialogVerArticulo();
            form.ShowDialog();
        }
    }
}




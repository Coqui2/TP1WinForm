using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;
using System.Data.SqlTypes;

namespace TP1
{
    public partial class frmListadoCategorias : Form
    {
        private List<Categoria> categorias;
        private List<Categoria> lista;

        private List<Articulo> listaArticulos;

        private void cargarLista()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            categorias = negocio.listar();
        }

        private void cargarListaArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar(getCategoriaSeleccionada());
                dataGridArticulosPorCategoria.DataSource = listaArticulos;
                dataGridArticulosPorCategoria.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            labelListadoArt.Text = "Listado de Artículos con Categoría " + getCategoriaSeleccionada().Nombre;

        }

        private Categoria getCategoriaSeleccionada()
        {
            return (Categoria)dataGrisCategorias.CurrentRow.DataBoundItem;
        }

        public frmListadoCategorias()
        {
            InitializeComponent();
            this.Controls.Add(dataGrisCategorias);
            this.Load += Form5_Load;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cargarLista();
            lista = categorias;
            dataGrisCategorias.DataSource = lista;

        }
        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            lista = categorias.FindAll(x => x.Nombre.ToUpper().Contains(textBoxFiltro.Text.ToUpper()));
            dataGrisCategorias.DataSource = lista;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmDialogAgregarCategoria form = new frmDialogAgregarCategoria();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            frmDialogEditarCategoria form = new frmDialogEditarCategoria(getCategoriaSeleccionada());
            form.Owner = this;
            form.ShowDialog();
        }

        public void reload()
        {
            cargarLista();
            if (textBoxFiltro.Text != "")
            {
                lista = categorias.FindAll(x => x.Nombre.ToUpper().Contains(textBoxFiltro.Text.ToUpper()));
                dataGrisCategorias.DataSource = lista;
            }
            else
            {
                dataGrisCategorias.DataSource = categorias;
            }

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            frmDialogEliminarCategoria form = new frmDialogEliminarCategoria(getCategoriaSeleccionada());
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            textBoxFiltro.Text = "";
            textBoxFiltro.Focus();

        }
        private void listaCategorias_SelectionChanged(object sender, EventArgs e)
        {
            cargarListaArticulos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}

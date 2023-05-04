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
    public partial class Form2 : Form
    {
        
        private List<Articulo> lista;
        private Articulo getArticuloActivo() { return (Articulo)listaArticulos.CurrentRow.DataBoundItem;}
        private void cargarLista()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            lista = negocio.listar();

        }
        public Form2()
        {
            InitializeComponent();
            this.Controls.Add(listaArticulos);
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cargarLista();
            listaArticulos.DataSource = lista;
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void onTxtChange(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txtBoxFiltro.Text.ToUpper()) || x.Codigo.ToUpper().Contains(txtBoxFiltro.Text.ToUpper()));
            listaArticulos.DataSource= listaFiltrada;
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmDialogAgregarArticulo form = new frmDialogAgregarArticulo();
            form.ShowDialog();
        }

        private void btnVerArticulo_Click(object sender, EventArgs e)
        {
            frmDialogVerArticulo form = new frmDialogVerArticulo();
            form.ShowDialog();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            frmDialogEditarArticulo form = new frmDialogEditarArticulo();
            form.ShowDialog();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            frmDialogEliminarArticulo form = new frmDialogEliminarArticulo(getArticuloActivo());
            form.ShowDialog();
        }

    }
}

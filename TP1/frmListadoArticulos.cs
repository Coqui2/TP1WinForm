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
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace TP1
{
    public partial class Form2 : Form
    {
        
        private List<Articulo> lista;
        private Articulo getArticuloActivo() { return (Articulo)dataGridArticulos.CurrentRow.DataBoundItem;}
        private void cargarLista()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                lista = negocio.listar();
                dataGridArticulos.DataSource = lista;
                dataGridArticulos.Columns["Id"].Visible = false;
                cargarPreview(getArticuloActivo());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Form2()
        {
            InitializeComponent();
            this.Controls.Add(dataGridArticulos);
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cargarLista();
            //Filtro avanzado
            comboBoxCampo.Items.Add("Código");
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Descripción");
            comboBoxCampo.Items.Add("Categoría");
            comboBoxCampo.Items.Add("Marca");
            comboBoxCampo.Items.Add("Precio");
        }
        public void reload()
        {
            cargarLista();
            if (textBoxFiltro.Text != "")
            {
                List<Articulo> listaFiltrada;
                listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(textBoxFiltro.Text.ToUpper()) || x.Codigo.ToUpper().Contains(textBoxFiltro.Text.ToUpper()));
                dataGridArticulos.DataSource = listaFiltrada;
            }
            else
            {
                dataGridArticulos.DataSource = lista;
            }

        }

        void cargarPreview(Articulo seleccionado)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            List<Imagen> imagenes = imagenNegocio.listarPorIdArticulo(seleccionado.Id);
            try
            {
                labelCodigoArticulo.Text = $"Código  {seleccionado.Codigo}";
                labelNombreArticulo.Text = seleccionado.Nombre;
                labelCategoria.Text = seleccionado.Categoria.Nombre;
                labelPrecioArticulo.Text = $"${seleccionado.Precio}";
                if (imagenes != null)
                {
                    pbxArticulo.Load(imagenes[0].url);
                } else
                {
                    pbxArticulo.Load("https://previews.123rf.com/images/freshwater/freshwater1711/freshwater171100021/89104479-p%C3%ADxel-404-p%C3%A1gina-de-error-p%C3%A1gina-no-encontrada.jpg");
                }
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://previews.123rf.com/images/freshwater/freshwater1711/freshwater171100021/89104479-p%C3%ADxel-404-p%C3%A1gina-de-error-p%C3%A1gina-no-encontrada.jpg");
                //MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void onTxtChange(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(textBoxFiltro.Text.ToUpper()) || x.Codigo.ToUpper().Contains(textBoxFiltro.Text.ToUpper()));
            dataGridArticulos.DataSource= listaFiltrada;
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmDialogAgregarArticulo form = new frmDialogAgregarArticulo();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnVerArticulo_Click(object sender, EventArgs e)
        {
            frmDialogVerArticulo form = new frmDialogVerArticulo(getArticuloActivo());
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            frmDialogAgregarArticulo form = new frmDialogAgregarArticulo(getArticuloActivo());
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            frmDialogEliminarArticulo form = new frmDialogEliminarArticulo(getArticuloActivo());
            form.Owner = this;
            form.ShowDialog();
        }


        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string op = comboBoxCampo.SelectedItem.ToString();
            if (op == "Precio")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor que");
                comboBoxCriterio.Items.Add("Menor que");
                comboBoxCriterio.Items.Add("Igual a");
            }
            else
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Empieza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }
            
        }
        public void busquedaFiltroAvanzado()
        {
            if (comboBoxCampo.SelectedItem is null)
            {
                MessageBox.Show("Selecciona un campo.");
                return;
            }
            if (comboBoxCriterio.SelectedItem is null)
            {
                MessageBox.Show("Selecciona un criterio.");
                return;
            }
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltroAvanzado.Text;
                if (campo == "Precio")
                {
                    if (filtro == "")
                    {
                        MessageBox.Show("Ingresa un valor.");
                        return;
                    }
                    if (!(filtro.All(char.IsNumber)))
                    {
                        MessageBox.Show("Ingresa un valor númerico");
                        return;
                    }
                }

                dataGridArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busquedaFiltroAvanzado();
       
        }

        private void textBoxFiltroAvanzado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                busquedaFiltroAvanzado();
                return;
            }
            if (e.KeyCode == Keys.Escape)
            {
                comboBoxCampo.Focus();
                return;
            }
        }

        private void dataGridArticulos_SelectionChanged(object sender, EventArgs e)
        {
            cargarPreview(getArticuloActivo());
        }

        private void dataGridArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDialogVerArticulo form = new frmDialogVerArticulo(getArticuloActivo());
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            textBoxFiltro.Text = "";
            textBoxFiltro.Focus();
        }
    }
}

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
    public partial class frmDialogAgregarArticulo : Form
    {
        Articulo articulo = null;
        List<Imagen> imagenes = new List<Imagen>();
        public frmDialogAgregarArticulo()
        {
            InitializeComponent();
        }
        public frmDialogAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            labelAgregarArt.Text = "Modificar articulo";
            Text = "Modificar Articulo";
        }
        private void frmDialogAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            try
            {
                comboBoxMarcasArt.DataSource = marcaNegocio.listarMarcas();
                comboBoxMarcasArt.DisplayMember = "Nombre";
                comboBoxMarcasArt.ValueMember = "Codigo";
                comboBoxCategoriaArt.DataSource = categoriaNegocio.listar();
                comboBoxCategoriaArt.DisplayMember = "Nombre";
                comboBoxCategoriaArt.ValueMember = "Codigo";
                if (articulo != null)
                {
                    imagenes = imagenNegocio.listarPorIdArticulo(articulo.Id);
                    List<string> urls = new List<string>();
                    foreach (Imagen imagen in imagenes)
                    {
                        urls.Add(imagen.url);
                    }
                    string urlsFormateadas = string.Join(";", urls);
                    textBoxCodigoArt.Text = articulo.Codigo;
                    textBoxNombreArt.Text = articulo.Nombre;
                    textBoxDescripcionArt.Text = articulo.Descripcion;
                    textBoxUrlImagenesArt.Text = urlsFormateadas;
                    comboBoxMarcasArt.SelectedValue = articulo.Marca.Codigo;
                    comboBoxCategoriaArt.SelectedValue = articulo.Categoria.Codigo;
                    textBoxPrecioArt.Text = Convert.ToString(articulo.Precio);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmDialogAgregarArticulo.ActiveForm.Close();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            if (checkNullity())
                try
                {
                    if (articulo == null)
                        articulo = new Articulo();
                    articulo.Codigo = textBoxCodigoArt.Text;
                    articulo.Nombre = textBoxNombreArt.Text;
                    articulo.Descripcion = textBoxDescripcionArt.Text;
                    articulo.Marca = (Marca)comboBoxMarcasArt.SelectedItem;
                    articulo.Categoria = (Categoria)comboBoxCategoriaArt.SelectedItem;
                    articulo.Precio = decimal.Parse(textBoxPrecioArt.Text);
                    articulo.Categoria.Codigo = Convert.ToInt32(comboBoxCategoriaArt.SelectedValue);
                    articulo.Marca.Codigo = Convert.ToInt32(comboBoxMarcasArt.SelectedValue);

                    if (articulo.Id == 0)
                    {
                    artNegocio.agregar(articulo);
                    MessageBox.Show("Se agrego correctamente");
                    }
                    else
                    {
                        artNegocio.modificar(articulo);
                        MessageBox.Show("Se modifico correctamente");
                    }
                    string urlImagenes = textBoxUrlImagenesArt.Text;
                    string[] url = urlImagenes.Split(';');
                    List<Imagen> imagenesNuevas = new List<Imagen>();
                    List<string> imagenesActuales = new List<string>();
                    foreach (Imagen imagen in imagenes)
                    {
                        imagenesActuales.Add(imagen.url);
                    }
                    foreach (string item in url)
                    {
                        if (!string.IsNullOrEmpty(item))
                        {
                            Imagen imagen = new Imagen(articulo.Id, item);
                            imagenesNuevas.Add(imagen);
                        }
                    }
                    foreach (Imagen aux in imagenesNuevas)
                    {
                        if (aux != null && !imagenesActuales.Contains(aux.url))
                        {
                            imagenNegocio.agregar(aux);
                        }
                    }
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
        private bool checkNullity()
        {
            if (string.IsNullOrEmpty(textBoxCodigoArt.Text) || string.IsNullOrEmpty(textBoxNombreArt.Text) || string.IsNullOrEmpty(comboBoxCategoriaArt.Text) || string.IsNullOrEmpty(comboBoxMarcasArt.Text))
            {
                MessageBox.Show("Por favor, completar los campos obligatorios", "Completar campos");
                return false;
            }
            else if (string.IsNullOrEmpty(textBoxPrecioArt.Text))
            {
                MessageBox.Show("Por favor indique un precio de venta", "Completar campos");
                return false;
            }
            return true;
        }

        private void textBoxCodigoArt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCodigoArt.Text))
            {
                textBoxCodigoArt.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                textBoxCodigoArt.BackColor = System.Drawing.Color.FromArgb(229, 239, 193);
            }
        }

        private void textBoxNombreArt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombreArt.Text))
            {
                textBoxNombreArt.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                textBoxNombreArt.BackColor = System.Drawing.Color.FromArgb(229, 239, 193);
            }
        }

        private void comboBoxMarcasArt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMarcasArt.Text))
            {
                comboBoxMarcasArt.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                comboBoxMarcasArt.BackColor = System.Drawing.Color.FromArgb(229, 239, 193);
            }
        }

        private void comboBoxCategoriaArt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCodigoArt.Text))
            {
                comboBoxCategoriaArt.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                comboBoxCategoriaArt.BackColor = System.Drawing.Color.FromArgb(229, 239, 193);
            }
        }

        private void textBoxPrecioArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59 || e.KeyChar == 46) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void frmDialogAgregarArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.Owner != null)
            {
                if (this.Owner.GetType() == typeof(Form2) )
                {
                    ((Form2)this.Owner).reload();
                    return;
                }

            }
        }
    }
}

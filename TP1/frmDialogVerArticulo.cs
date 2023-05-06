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
    public partial class frmDialogVerArticulo : Form
    {
        Articulo articulo = null;
        private List<Imagen> imagenes = new List<Imagen>();
        private int indiceImagenActual = 0;

        public frmDialogVerArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.Text = "Detalles de " + articulo.Nombre + "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmDialogVerArticulo.ActiveForm.Close();
        }

        private void frmDialogVerArticulo_Load(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            imagenes = imagenNegocio.listarPorIdArticulo(articulo.Id);
            try
            {
                labelTituloArt.Text = articulo.Nombre;
                textBoxCodigoArt.Text = articulo.Codigo;
                textBoxNombreArt.Text = articulo.Nombre;
                labelPrecioArt.Text = articulo.Precio.ToString();
                textBoxMarcaArt.Text = articulo.Marca.Nombre;
                textBoxCategoriaArt.Text = articulo.Categoria.Nombre;
                textBoxDescripcionArt.Text = articulo.Descripcion;
                pictureBoxImagenes.Load(imagenes[indiceImagenActual].url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            indiceImagenActual--;
            if (indiceImagenActual < 0)
            {
                indiceImagenActual = imagenes.Count - 1;
            }
            try
            {
                pictureBoxImagenes.Load(imagenes[indiceImagenActual].url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnProxImagen_Click(object sender, EventArgs e)
        {
            indiceImagenActual++;
            if (indiceImagenActual >= imagenes.Count)
            {
                indiceImagenActual = 0;
            }
            try
            {
                pictureBoxImagenes.Load(imagenes[indiceImagenActual].url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

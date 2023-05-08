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
                try
                {
                    pictureBoxImagenes.Load(imagenes[indiceImagenActual].url);
                }
                catch (Exception)
                {
                    pictureBoxImagenes.Load("https://previews.123rf.com/images/freshwater/freshwater1711/freshwater171100021/89104479-p%C3%ADxel-404-p%C3%A1gina-de-error-p%C3%A1gina-no-encontrada.jpg");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(imagenes.Count() == 0)
            {
                btnImagenAnterior.Enabled = false;
                btnProxImagen.Enabled = false;
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
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString());
                pictureBoxImagenes.Load("https://previews.123rf.com/images/freshwater/freshwater1711/freshwater171100021/89104479-p%C3%ADxel-404-p%C3%A1gina-de-error-p%C3%A1gina-no-encontrada.jpg");
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
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                pictureBoxImagenes.Load("https://previews.123rf.com/images/freshwater/freshwater1711/freshwater171100021/89104479-p%C3%ADxel-404-p%C3%A1gina-de-error-p%C3%A1gina-no-encontrada.jpg");
            }
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            frmDialogAgregarArticulo form = new frmDialogAgregarArticulo(articulo);
            form.Owner = this;
            form.ShowDialog();
        }

        private void frmDialogVerArticulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Owner != null)
            {
                if(this.Owner.GetType() == typeof(Form2))
                {
                    ((Form2)this.Owner).reload();
                }
                else if(this.Owner.GetType() == typeof(frmListadoMarcas))
                {
                    ((frmListadoMarcas)this.Owner).reload();
                }
                else if (this.Owner.GetType() == typeof(frmListadoCategorias))
                {
                    ((frmListadoCategorias)this.Owner).reload();
                }

            }
        }

        private void btnEliminarArticulo_Click_1(object sender, EventArgs e)
        {
            frmDialogEliminarArticulo form = new frmDialogEliminarArticulo(articulo);
            form.Owner = this;
            form.ShowDialog();
        }
    }
}

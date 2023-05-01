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
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();

            AccesoDatos accesoDatos = new AccesoDatos();
            accesoDatos.SetConsulta("SELECT C.Id, C.Descripcion FROM CATEGORIAS C");
            accesoDatos.EjecutarLectura();

            while (accesoDatos.Lector.Read())
            {
                Categoria aux = new Categoria();
                aux.Codigo = (int)accesoDatos.Lector["Id"];
                aux.Nombre = (string)accesoDatos.Lector["Descripcion"];

                lista.Add(aux);
            }
            accesoDatos.CerrarConexion();
            return lista;
        }
        public frmListadoCategorias()
        {
            InitializeComponent();
            this.Controls.Add(listaCategoria);
            listaCategoria.View= View.Details;
            this.Load += Form5_Load;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            listaCategoria.Columns.Add("Codigo", -2, HorizontalAlignment.Left);
            listaCategoria.Columns.Add("Nombre", -2, HorizontalAlignment.Left);
            List<Categoria> categorias = new List<Categoria>();
            categorias = listar();   
            


            foreach (Categoria categoria in categorias)
            {
                ListViewItem item;
                item = new ListViewItem(new[] { categoria.Codigo.ToString(), categoria.Nombre });
                listaCategoria.Items.Add(item);
            }

           

        }

        private void listaMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Categoria> categorias = new List<Categoria>();
            categorias = listar();
            if(listaCategoria.SelectedIndices.Count > 0)
            {
                int index = listaCategoria.FocusedItem.Index;

                int codigo = categorias[index].Codigo;
                labelCodigoCategoria.Text = "Código Categoría #" + codigo;

                string nombre = categorias[index].Nombre;
                labelNombreCategoria.Text = nombre;
            }
        }
    }
}

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
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            AccesoDatos accesoDatos = new AccesoDatos();
            accesoDatos.SetConsulta("SELECT A.Id, A.Codigo as Codigo, A.Nombre as Nombre, A.Descripcion as Descripcion, CAST(A.Precio AS float) as Precio, M.Descripcion as 'Marca', C.Descripcion AS 'Categorías'\r\nFROM ARTICULOS as A\r\nINNER JOIN MARCAS M on A.IdMarca = M.Id\r\nINNER JOIN CATEGORIAS C on A.IdCategoria = C.Id;");
            accesoDatos.EjecutarLectura();

            while (accesoDatos.Lector.Read())
            {
                Articulo aux = new Articulo();
                aux.Codigo = (string)accesoDatos.Lector["Codigo"];
                aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                //aux.Precio = (float)accesoDatos.Lector["Precio"];
                lista.Add(aux);
            }
            accesoDatos.CerrarConexion();
            return lista;
        }
        public Form2()
        {
            InitializeComponent();
            this.Controls.Add(listaArticulos);
            listaArticulos.View= View.Details;
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            listaArticulos.Columns.Add("Codigo", -2, HorizontalAlignment.Left);
            listaArticulos.Columns.Add("Nombre", -2, HorizontalAlignment.Left);
            listaArticulos.Columns.Add("Descripcion", -2, HorizontalAlignment.Left);
            listaArticulos.Columns.Add("Precio", -2, HorizontalAlignment.Left);

            // BaseDeDatos db = new BaseDeDatos();
            List<Articulo> articulos= new List<Articulo>();
            //articulos = db.listarArticulos();
            articulos = listar();   
            


            foreach (Articulo articulo in articulos)
            {
                ListViewItem item;
                item = new ListViewItem(new[] {articulo.Codigo, articulo.Nombre, articulo.Descripcion, articulo.Precio.ToString()});
                listaArticulos.Items.Add(item);
            }

           

        }

        private void listaArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Articulo> articulos = new List<Articulo>();
            articulos = listar();
            if(listaArticulos.SelectedIndices.Count > 0)
            {
                int index = listaArticulos.FocusedItem.Index;

                string codigo = articulos[index].Codigo;
                labelCodigoArticulo.Text = "Código " + codigo;

                string nombre = articulos[index].Nombre;
                labelNombreArticulo.Text = nombre;
            }
        }
    }
}

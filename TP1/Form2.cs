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

namespace TP1
{
    public partial class Form2 : Form
    {
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
            listaArticulos.Columns.Add("Nombre", -2, HorizontalAlignment.Left);
            listaArticulos.Columns.Add("Marca", -2, HorizontalAlignment.Left);
            listaArticulos.Columns.Add("Categoria", -2, HorizontalAlignment.Left);
            listaArticulos.Columns.Add("Precio", -2, HorizontalAlignment.Left);

            // BaseDeDatos db = new BaseDeDatos();
            List<Articulo> articulos= new List<Articulo>();
            //articulos = db.listarArticulos();
            
            Marca prueba = new Marca(1,"hola");
            Categoria prueba2 = new Categoria(1,"chau");
            Articulo art1 = new Articulo(1,"art1","desc1",prueba,prueba2,null,100);
            Articulo art2 = new Articulo(2, "art2", "desc2", prueba, prueba2, null, 200);
            Articulo art3 = new Articulo(3, "art3", "desc3", prueba, prueba2, null, 300);
            articulos.Add(art1);
            articulos.Add(art2);
            articulos.Add(art3);

            
            foreach (Articulo articulo in articulos)
            {
                ListViewItem item = new ListViewItem(new[] {articulo.Nombre,articulo.Marca.Nombre,articulo.Categoria.Nombre,articulo.Precio.ToString()});
                listaArticulos.Items.Add(item);
            }


        }
    }
}

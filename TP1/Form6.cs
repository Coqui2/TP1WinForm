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
    public partial class Form6 : Form
    {
       
        public Form6()
        {
            InitializeComponent();
            this.Controls.Add(listaCategoria);
            listaCategoria.View= View.Details;
            this.Load += Form6_Load;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            listaCategoria.Columns.Add("Codigo", -2, HorizontalAlignment.Left);
            listaCategoria.Columns.Add("Nombre", -2, HorizontalAlignment.Left);
            

            /*
            foreach (Categoria categoria in categorias)
            {
                ListViewItem item;
                item = new ListViewItem(new[] { categoria.Codigo.ToString(), categoria.Nombre });
                listaCategoria.Items.Add(item);
            }
            */
           

        }

    }
}

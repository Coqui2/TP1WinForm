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
    public partial class frmBuscarArticulo : Form
    {
       
        public frmBuscarArticulo()
        {
            InitializeComponent();
            this.Controls.Add(listaResultados);
            listaResultados.View= View.Details;
            this.Load += Form10_Load;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            listaResultados.Columns.Add("Codigo", -2, HorizontalAlignment.Left);
            listaResultados.Columns.Add("Nombre", -2, HorizontalAlignment.Left);
            

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

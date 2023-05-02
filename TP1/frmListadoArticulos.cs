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
            
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> articulos = negocio.listar();
            
            
            
            listaArticulos.DataSource= articulos;
            

            
           

        }
        /*
         * ESTE METODO QUEDÓ DESAFECTADO AL CAMBIAR DE LISTVIEW A DATAGRIDVIEW
         * 
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
        */
    }
}

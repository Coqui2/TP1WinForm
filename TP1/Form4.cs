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
    public partial class Form4 : Form
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();

            AccesoDatos accesoDatos = new AccesoDatos();
            accesoDatos.SetConsulta("SELECT M.Id AS IdMarca, M.Descripcion as NombreMarca\r\nFROM Marcas M");
            accesoDatos.EjecutarLectura();

            while (accesoDatos.Lector.Read())
            {
                Marca aux = new Marca();
                aux.Codigo = (int)accesoDatos.Lector["IdMarca"];
                aux.Nombre = (string)accesoDatos.Lector["NombreMarca"];

                lista.Add(aux);
            }
            accesoDatos.CerrarConexion();
            return lista;
        }
        public Form4()
        {
            InitializeComponent();
            this.Controls.Add(listaMarcas);
            listaMarcas.View= View.Details;
            this.Load += Form4_Load;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            listaMarcas.Columns.Add("Codigo", -2, HorizontalAlignment.Left);
            listaMarcas.Columns.Add("Nombre", -2, HorizontalAlignment.Left);
            List<Marca> marcas = new List<Marca>();
            marcas = listar();   
            


            foreach (Marca marca in marcas)
            {
                ListViewItem item;
                item = new ListViewItem(new[] { marca.Codigo.ToString(), marca.Nombre });
                listaMarcas.Items.Add(item);
            }

           

        }

        private void listaMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Marca> marcas = new List<Marca>();
            marcas = listar();
            if(listaMarcas.SelectedIndices.Count > 0)
            {
                int index = listaMarcas.FocusedItem.Index;

                int codigo = marcas[index].Codigo;
                labelCodigoMarca.Text = "Código Marca #" + codigo;

                string nombre = marcas[index].Nombre;
                labelNombreMarca.Text = nombre;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TP1
{
    internal class Articulo
    {
        private int codigo;
        private string nombre;
        private string descripcion;
        Marca marca;
        Categoria categoria;
        List<string> imagenes;
        private float precio;
    }
}


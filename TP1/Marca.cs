using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Marca
    {
        private int codigo;
        private string nombre;

        public Marca(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }
        public Marca() {}
    }
}

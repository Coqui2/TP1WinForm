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
    public partial class ContenedorPrincipal : Form
    {
        public ContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void listarArticulosMenu_Click(object sender, EventArgs e)
        {
            foreach(Form form in Application.OpenForms)
            {
                if(form.GetType()==typeof(Form2))
                {
                    return;
                }
            }
            Form2 form2 = new Form2();
            form2.MdiParent= this;
            form2.Show();
        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form2))
                {
                    return;
                }
            }
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void listarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form3))
                {
                    return;
                }
            }

            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }
    }
}




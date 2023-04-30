using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void listarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form2) || form.GetType() == typeof(Form4))
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
                if (form.GetType() == typeof(Form4))
                {
                    return;
                }
            }
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();
        }

        private void listarCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form5))
                {
                    return;
                }
            }
            Form5 form5 = new Form5();
            form5.MdiParent = this;
            form5.Show();
        }

        private void porCódigoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form6))
                {
                    return;
                }
            }
            Form6 form6 = new Form6();
            form6.MdiParent = this;
            form6.Show();

        }

        private void porNombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form7))
                {
                    return;
                }
            }
            Form7 form7 = new Form7();
            form7.MdiParent = this;
            form7.Show();

        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form8))
                {
                    return;
                }
            }
            Form8 form8 = new Form8();
            form8.MdiParent = this;
            form8.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form9))
                {
                    return;
                }
            }
            Form9 form9 = new Form9();
            form9.MdiParent = this;
            form9.Show();

        }
    }
}




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Cajero
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (rbOpcion1.Checked)
            {
                Form4 formulario3 = new Form4(0); // Reemplaza con el formulario que deseas mostrar.
                formulario3.Show();
                this.Hide(); // Opcional: Oculta el formulario actual.
            }
            else if (rbOpcion2.Checked)
            {
                Form4 formulario4 = new Form4(1); // Reemplaza con el formulario que deseas mostrar.
                formulario4.Show();
                this.Hide(); // Opcional: Oculta el formulario actual.
            }

        }
    }
}

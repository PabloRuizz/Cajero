using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Validar que el texto no esté vacío y que contenga solo letras
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && txtNombre.Text.All(char.IsLetter))
            {

                // Si es válido, abrir el siguiente formulario
                Form4 siguienteFormulario = new Form4(2, Name);
                siguienteFormulario.Show();

                // Opcionalmente, cerrar el formulario actual
                this.Hide();
            }
            else
            {
                // Mostrar un mensaje de error si el nombre no es válido
                MessageBox.Show("Por favor, introduce un nombre válido (solo letras y sin espacios vacíos).",
                                "Nombre Inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}

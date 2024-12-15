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
        string id;
        public Form3(string newId)
        {
            InitializeComponent();
            this.id = newId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnSiguiente_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            string url="https://localhost:7243/api/FileManager/nombre?nombre="+txtNombre.Text;
            var responseWithdraw = await client.GetAsync(url);
            if (responseWithdraw.IsSuccessStatusCode)
            {
                var result = await responseWithdraw.Content.ReadAsStringAsync();
                if (result != "")
                {
                    // Crea una instancia del segundo formulario
                    Form4 siguienteFormulario = new Form4(2, id, txtNombre.Text);
                    siguienteFormulario.Show();

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

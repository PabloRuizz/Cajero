using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.DataFormats;

namespace Cajero
{
    public partial class Form2 : Form
    {
        string id;
        public Form2(string newId)
        {
            InitializeComponent();
            id = newId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnContinuar_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            string url;
            if (rbOpcion1.Checked)
            {
                url = "https://localhost:7243/api/Cuenta/Comprobar dinero?id="+id;
                var responseWithdraw = await client.GetAsync(url);

                if (responseWithdraw.IsSuccessStatusCode)
                {
                    var result = await responseWithdraw.Content.ReadAsStringAsync();
                    var dialogResult = MessageBox.Show($"La cantidad actual en tu cuenta es de {result} euros",
                                                       "Confirmación",
                                                       MessageBoxButtons.OK,
                                                       MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error en la solicitud. No se pudo retirar el dinero.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                
                // formulario3.Show();
                //this.Hide(); // Opcional: Oculta el formulario actual.
            }
            else if (rbOpcion2.Checked)
            {
                Form4 formulario3 = new Form4(0, id); // Reemplaza con el formulario que deseas mostrar.
                formulario3.Show();
                this.Hide(); // Opcional: Oculta el formulario actual.
            }
            else if (rbOpcion3.Checked)
            {
                Form4 formulario4 = new Form4(1, id); // Reemplaza con el formulario que deseas mostrar.
                formulario4.Show();
                this.Hide(); // Opcional: Oculta el formulario actual.
            }
            else if (rbOpcion4.Checked)
            {
                Form3 formulario3 = new Form3(); // Reemplaza con el formulario que deseas mostrar.
                formulario3.Show();
                this.Hide(); // Opcional: Oculta el formulario actual.
            }

        }
    }
}

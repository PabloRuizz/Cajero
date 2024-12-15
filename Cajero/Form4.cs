using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Cajero
{
    public partial class Form4 : Form
    {
        string id;
        int opcion = 0;
        string nombre;
        public Form4(int i, string newId)
        {
            InitializeComponent();
            this.opcion = i;
            switch (i)
            {
                case 0:
                    label1.Text = "Introduzca la cantidad que desea retirar";
                    break;
                case 1:
                    label1.Text = "Introduzca el dinero que desea ingresar en la ranura";
                    break;
                case 2:
                    label1.Text = "Introduzca el dinero que desea transferir";
                    break;
            }
            this.id = newId;
            
        }

        public Form4(int i, string newId, string newNombre)
        {
            this.opcion = i;
            switch (i)
            {
                case 2:
                    label1.Text = "Introduzca el dinero que desea tranferir";
                    break;
            }
            this.nombre = newNombre;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnSiguiente_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            string url;

            
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                switch (opcion)
                {
                    case 0:
                        // Caso de retirar dinero
                        url = "https://localhost:7243/api/Cuenta/DineroRetirarId?id=" + id + "&cantidad=" + cantidad;

                        var responseWithdraw = await client.PutAsync(url, new StringContent("", Encoding.UTF8, "application/json"));

                        if (responseWithdraw.IsSuccessStatusCode)
                        {
                            var result = await responseWithdraw.Content.ReadAsStringAsync();
                            var dialogResult = MessageBox.Show($"Retirando {cantidad} euros. Puede recoger su dinero.\nRespuesta de la API: {result}",
                                                               "Confirmación",
                                                               MessageBoxButtons.OK,
                                                               MessageBoxIcon.Information);

                            if (dialogResult == DialogResult.OK)
                            {
                                Form1 form1 = new Form1();
                                form1.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error en la solicitud. No se pudo retirar el dinero.",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                        break;
                    case 1:


                        //EJEMPLO DE AÑADIR DINERO
                        //Enciendes en Swagger y pruebas el método que quieres usar. Te dará una url y la escribes en éste string.
                        url = "https://localhost:7243/api/Cuenta/DineroAñadirId?id=" + id + "&cantidad=" + txtCantidad.Text;

                        //usas el método de CuentaController adecuad. Siempre es la url y el new StringContent, si e que pide el segundo.
                        var response = await client.PutAsync(url, new StringContent("", Encoding.UTF8, "application/json"));// await client.PutAsJsonAsync(url);
                                                                                                                            //recuerda lo que cambiaste en controller.
                                                                                                                            //Si ha habido éxito, se continúa. El contenido de este ejemplo se debe cambiar.
                        if (response.IsSuccessStatusCode)
                        {
                            // Obtener el contenido JSON de la respuesta
                            var result = await response.Content.ReadAsStringAsync();

                            // Mostrar el resultado en la interfaz, por ejemplo, en un TextBox o MessageBox
                            var dialogResult= MessageBox.Show($"Respuesta de la API: {result}");

                            if (dialogResult == DialogResult.OK)
                            {
                                Form1 form1 = new Form1();
                                form1.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error en la solicitud");
                        }

                        break;


                    
                }
            }
            else
            {
                // Mostrar un mensaje de error si el texto no es válido o <= 0
                MessageBox.Show("Por favor, introduce una cantidad válida y positiva.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
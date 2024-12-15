using System.Security.Policy;
using System.Text;

namespace Cajero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text + "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            string url;
            url = "https://localhost:7243/api/FileManager/id?id="+txtID.Text;

            var responseWithdraw = await client.GetAsync(url);
            if (responseWithdraw.IsSuccessStatusCode)
            {
                var result = await responseWithdraw.Content.ReadAsStringAsync();
                if (result!="")
                {
                    // Crea una instancia del segundo formulario
                    Form2 formulario2 = new Form2(txtID.Text);

                    // Muestra el segundo formulario
                    formulario2.Show();
                    // Cierra el formulario actual
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Id equivocado, escriba otro",
                                "Id Inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Error",
                                "Nombre Inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }


            
        }

    }
}


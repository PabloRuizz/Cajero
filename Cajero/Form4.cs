﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Form4 : Form
    {
        int i=0;
        public Form4(int i)
        {
            InitializeComponent();
            this.i = i;
            switch (i)
            {
                case 0:
                    label1.Text = "Introduzca la cantidad que desea retirar";
                    break;
                case 1:
                    label1.Text = "Introduzca el dinero que desea ingresar en la ranura";
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            /*// Validar que el texto introducido sea un número válido
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                // Mostrar el mensaje emergente con la cantidad ingresada
                DialogResult result = MessageBox.Show(
                    $"Se han ingresado {cantidad} euros en su cuenta.",
                    "Confirmación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Si el usuario hace clic en Aceptar
                if (result == DialogResult.OK)
                {
                    // Abrir Form1
                    Form1 form1 = new Form1();
                    form1.Show();

                    // Cerrar el formulario actual
                    this.Close();
                }
            }
            else
            {
                // Mostrar un mensaje de error si el texto no es válido
                MessageBox.Show("Por favor, introduce una cantidad válida.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }*/

            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {


            }
            else
            {
                // Mostrar un mensaje de error si el texto no es válido
                MessageBox.Show("Por favor, introduce una cantidad válida.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}

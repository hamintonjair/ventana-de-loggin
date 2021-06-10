using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventana_de_loggin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "hames" && txtContraseña.Text == "123")
            {
                MessageBox.Show("Inicio se sesión!....");
            }
            else
            {
                MessageBox.Show("Error en el ID O contraseña... intenta de nuevo!...");

                txtID.Text = "";
                txtContraseña.Text = "";
                txtID.Focus();
            }            
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using Proyecto1.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("No puede quedar vacio el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            Saludo saludo = new Saludo();
            String nombre = txtNombre.Text;
            String mensaje = saludo.saludar(nombre);
            MessageBox.Show(mensaje, "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

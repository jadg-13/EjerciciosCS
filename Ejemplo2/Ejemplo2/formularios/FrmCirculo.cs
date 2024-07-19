using Ejemplo2.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2.formularios
{
    public partial class FrmCirculo : Form
    {
        public FrmCirculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo();

            double radio = Double.Parse(txtRadio.Text);
            double area = circulo.calcArea(radio);

            String msn = "El area es " + area;
            MessageBox.Show(msn);
        }
    }
}

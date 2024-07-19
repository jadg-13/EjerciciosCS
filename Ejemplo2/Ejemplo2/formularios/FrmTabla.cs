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
    public partial class FrmTabla : Form
    {
        public FrmTabla()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Tabla tabla = new Tabla();
            int num = int.Parse(txtNumero.Text);
            String tbl = tabla.obtTabla(num);
            MessageBox.Show(tbl, "Tabla de Multiplicar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

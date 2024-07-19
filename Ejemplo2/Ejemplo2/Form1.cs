using Ejemplo2.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTabla_Click(object sender, EventArgs e)
        {
            FrmTabla frm = new FrmTabla();
            frm.Show();
        }

        private void BtnAreaC_Click(object sender, EventArgs e)
        {
            FrmCirculo frm = new FrmCirculo();
            frm.Show();
        }

        private void BtnDatos_Click(object sender, EventArgs e)
        {
            FrmEmpleado frm = new FrmEmpleado();
            frm.Show();
        }
    }
}

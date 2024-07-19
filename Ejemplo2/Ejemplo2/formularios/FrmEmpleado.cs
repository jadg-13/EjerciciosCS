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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado(
                txtNombre.Text,
                cmbCargo.SelectedItem.ToString(),
                double.Parse(txtSalario.Text)
                );

            MessageBox.Show(emp.Nombre + " " + emp.Cargo + " " + emp.Salario.ToString("###,###.#0"), "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

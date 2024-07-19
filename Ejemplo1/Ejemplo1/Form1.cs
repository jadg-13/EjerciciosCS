using Ejemplo1.models;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {

            Student student = new Student
            {
                Cif = "123",
                BirthDay = DateTime.Now,
                Names = txtName.Text,
                Grades = 98
            };

            MessageBox.Show("Hola " + student.Names + " " + student.GetScholarShip(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

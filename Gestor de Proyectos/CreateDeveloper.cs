using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Proyectos
{
    public partial class CreateDeveloper : Form
    {
        public CreateDeveloper()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateDeveloper_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            bool valide = true; 
            String error = "Error:\n";
            if (textBoxNameDev.Text.Equals("")){
                error = error + "No existe nombre de desarrollador.\n";
                valide = false;
            }
            if (textBoxSurnameDev.Text.Equals(""))
            {
                error = error + "No existe apellido del desarrollador.\n";
                valide = false;
            }
            if (textBoxEmail.Text.Equals(""))
            {
                error = error + "No existe correo electronico del desarrollador.\n";
                valide = false;
            }
            if (textBoxPasswordDev.Text.Equals(""))
            {
                error = error + "No existe contraseña del desarrollador.\n";
                valide = false;
            }
            if (!valide)
            {
                MessageBox.Show(error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CreateProyect2 f = new CreateProyect2();
                f.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

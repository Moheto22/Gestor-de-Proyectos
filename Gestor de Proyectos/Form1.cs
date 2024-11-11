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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            
            
            if (textBoxUser.Text != "admin" || textBoxPassword.Text != "admin")
            {
                MessageBox.Show("Error: usuario o contraseña no existen", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Menu f = new Menu();
                f.Show();
                this.Hide();
            }
        }
    }
}

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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonCreateProyect_Click(object sender, EventArgs e)
        {
            CreateProyect f = new CreateProyect();
            f.Show();
            this.Hide();
        }
    }
}

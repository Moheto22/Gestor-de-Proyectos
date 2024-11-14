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
        private List<Proyecto> listProyects;

        public Menu()
        {
            List<Proyecto> listProyects = new List<Proyecto>();
            InitializeComponent();
        }
        public Menu(List<Proyecto> listProyects)
        {
            this.listProyects = listProyects;
            InitializeComponent();

        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonCreateProyect_Click(object sender, EventArgs e)
        {
            CreateProyect f = new CreateProyect(listProyects);
            f.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}

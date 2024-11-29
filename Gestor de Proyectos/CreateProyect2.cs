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
    public partial class CreateProyect2 : Form
    {
        private List<Proyect> listProyects = null;
        private List<Developer> listDev = null;
        public CreateProyect2(List<Proyect> listProyects)
        {
            this.listDev = new List<Developer>();
            this.listProyects = listProyects;
            InitializeComponent();
        }
        public CreateProyect2(List<Proyect> listProyects, List<Developer> listDev)
        {
            this.listDev = listDev;
            this.listProyects = listProyects;
            InitializeComponent();
        }

        private void labelNameUser_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDeveloper f = new CreateDeveloper(listDev,listProyects);
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteUser f = new DeleteUser(listDev,listProyects);
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listDev.Count != 0)
            {
                EditProyect f = new EditProyect(listProyects, listProyects.Count - 1);
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Error: No hay desarrolladores dentro del proyecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

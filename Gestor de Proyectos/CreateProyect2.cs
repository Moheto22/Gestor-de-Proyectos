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
        private List<Proyecto> listProyects = null;
        private List<Developer> listDev = null;
        public CreateProyect2(List<Proyecto> listProyects)
        {
            this.listDev = new List<Developer>();
            this.listProyects = listProyects;
            InitializeComponent();
        }
        public CreateProyect2(List<Proyecto> listProyects, List<Developer> listDev)
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
    }
}

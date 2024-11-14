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
    public partial class CreateProyect : Form
    {
        private List<Proyecto> listPoroyects = null;
        public CreateProyect(List<Proyecto> listProyects)
        {
            this.listPoroyects = listProyects;
            InitializeComponent();
        }

        private void buttonContinueCreateProyect_Click(object sender, EventArgs e)
        {
            CreateProyect2 f = new CreateProyect2(listPoroyects);
            this.Hide();
            f.Show();
        }
    }
}

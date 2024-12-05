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
    public partial class SelectProyect : Form
    {   
        List<Proyect> proyects;
        public SelectProyect(List<Proyect> proyects)
        {
            InitializeComponent();
            this.proyects = proyects;
            listBoxProyects.DataSource = proyects;
        }
        private void buttonSelectPro_Click(object sender, EventArgs e)
        {
            Proyect proyect = (Proyect)listBoxProyects.SelectedItems[0];
            int index = proyects.IndexOf(proyect);
            EditProyect f = new EditProyect(proyects, index);
            f.Show();
            this.Hide();
        }

        private void buttonLeaveSelectionPro_Click(object sender, EventArgs e)
        {
            Menu m = new Menu(proyects);
            m.Show();
            this.Hide();
        }

        private void SelectProyect_Load(object sender, EventArgs e)
        {

        }
    }
}

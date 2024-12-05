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
    public partial class DeleteProyect : Form
    {
        private List<Proyect> proyects;
        public DeleteProyect( List<Proyect> proyects)
        {
            InitializeComponent();
            this.proyects = proyects;
            listBoxProData.DataSource = proyects;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu m = new Menu(proyects);
            m.Show();
            this.Hide();
        }

        private void DeleteProyect_Load(object sender, EventArgs e)
        {
            foreach (var proyect in listBoxProData.SelectedItems)
            {
                proyects.Remove((Proyect)proyect);
            }
            listBoxProData.DataSource = null;
            listBoxProData.DataSource = proyects;
        }
    }
}

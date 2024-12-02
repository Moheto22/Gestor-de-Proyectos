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
    public partial class EditProyect : Form
    {
        private List<Proyect> listProyects;
        private int index;
        public EditProyect(List<Proyect> listProyects,int index)
        {
            InitializeComponent();
            this.listProyects = listProyects;
            this.index = index;
        }

        private void EditProyect_Load(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            CreateTask createTask = new CreateTask(listProyects,index);
            this.Hide();
            createTask.Show();
        }
    }
}

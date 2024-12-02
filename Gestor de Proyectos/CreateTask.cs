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
    public partial class CreateTask : Form
    {
        private List<Proyect> listProyects;
        private int index;
        private Task task;
        private List<SubTask> listSubTasks;
        private List<Developer> listDevs;
        public CreateTask(List<Proyect> listProyects, int index)
        {
            this.listProyects = listProyects;
            this.index = index;
            this.listSubTasks = new List<SubTask>();
            this.listDevs = new List<Developer>();
            this.task = null;
            InitializeComponent();
            listBoxDevProyect.Items.Clear();
            listBoxDevProyect.DataSource = listProyects[index].developers;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBoxSubTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateSubTask_Click(object sender, EventArgs e)
        {
            string subTask = textBoxNameSubTask.Text;
            if (string.IsNullOrEmpty(subTask)) {
                MessageBox.Show("Error: No hay ninguna sub tarea creada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listSubTasks.Add(new SubTask(subTask));
                listBoxSubTasks.DataSource = null;
                listBoxSubTasks.DataSource = listSubTasks;
                textBoxNameSubTask.Text = "";
            }
        }

        private void buttonSaveDevs_Click(object sender, EventArgs e)
        {
            listDevs.Clear();
            foreach (var item in listBoxDevProyect.SelectedItems)
            {
                listDevs.Add((Developer)item);
            }
            MessageBox.Show("Se han guardado los desarrolladores correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDeletteSubTask_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxSubTasks.SelectedItems)
            {
                listSubTasks.Remove((SubTask)item);
            }
            listBoxSubTasks.DataSource = null;
            listBoxSubTasks.DataSource= listSubTasks;
        }
    }
}

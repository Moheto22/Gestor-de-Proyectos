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
        private int page;
        public EditProyect(List<Proyect> listProyects,int index)
        {
            InitializeComponent();
            this.listProyects = listProyects;
            this.index = index;
            page = 0;
            fillGridView(listProyects,index,page);

        }

        private void fillGridView(List<Proyect> listProyects, int index, int page)
        {
            Proyect proyect = listProyects[index];
            List<Task> tasksToShow = takeTaskToShow(proyect,page);
            if (tasksToShow != null && tasksToShow.Count > 0)
            {

            }
            
            
        }

        private List<Task> takeTaskToShow(Proyect proyect, int page)
        {
            List<Task> tasks = new List<Task>();
            DateTime date;
            bool finish = false;
            int actualPage = 0;
            int i = 0;
            if (proyect.tasks.Count == 0)
            {
                tasks = null;
            }
            else
            {
                date = proyect.tasks[0].dateFinish;
                while (i==proyect.tasks.Count && !finish)
                {   
                    if (proyect.tasks[i].dateFinish != date)
                    {
                        actualPage++;
                    }
                    if (actualPage == page)
                    {
                        tasks.Add(proyect.tasks[i]);
                    }
                    else if (tasks.Count != 1)
                    {
                        finish = true;
                    }
                    i++;

                }
                if (!finish) {
                    MessageBox.Show("No hay tareas mas haya de la fecha actual", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return tasks;
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

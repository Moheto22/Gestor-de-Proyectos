using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            fillGridView();

        }

        private void fillGridView()
        {
            Proyect proyect = this.listProyects[this.index];
            List<Task> tasksToShow = takeTaskToShow(proyect,this.page);
            if (tasksToShow != null && tasksToShow.Count > 0)
            {
                var datos = tasksToShow.Select(t => new
                {   t.id,
                    t.name,
                    listDev = t.takeNameDevs(),
                    percentatge = t.getPercentatge() + "%",
                    finish = t.finish.ToString()
                }).ToList();
                dataGridViewTask.DataSource = datos;
            }
            else if (proyect.tasks.Count == 0)
            {
                dataGridViewTask.DataSource = null;
            }
            
        }

        private List<Task> takeTaskToShow(Proyect proyect, int page)
        {
            List<Task> tasks = new List<Task>();
            DateTime date;
            DateTime dateToShow = DateTime.Now;
            bool firstTake = false;
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
                while (i<proyect.tasks.Count && !finish)
                {   
                    if (proyect.tasks[i].dateFinish != date)
                    {
                        actualPage++;
                        date = proyect.tasks[i].dateFinish;
                    }
                    if (actualPage == this.page)
                    {
                        if (!firstTake)
                        {
                            dateToShow = date;
                        }
                        tasks.Add(proyect.tasks[i]);
                    }
                    else if (tasks.Count > 0)
                    {
                        finish = true;
                    }
                    i++;
                }
                if (!finish && tasks.Count == 0) {
                    MessageBox.Show("No hay tareas mas haya de la fecha actual", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.page--;
                }
                else
                {
                   labelDate.Text = dateToShow.ToShortDateString();
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

        private void buttonPreviousDay_Click(object sender, EventArgs e)
        {
            if(page == 0)
            {
                MessageBox.Show("No hay tareas anteriores a la fecha actual", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                this.page--;
                fillGridView();
            }
        }

        private void buttonNextDay_Click(object sender, EventArgs e)
        {
            this.page++;
            fillGridView();
        }

        private void buttonEditTask_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> listRowSelected =dataGridViewTask.SelectedRows.Cast<DataGridViewRow>().ToList();
            if(listRowSelected.Count > 1)
            {
                MessageBox.Show("No se puede seleccionar mas de una fila al mismo tiempo para editar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (listRowSelected.Count == 0)
            {
                MessageBox.Show("Debes de seleccionar una fila para editar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = (int)listRowSelected[0].Cells[0].Value;
                Task task = takeTaskById(id);
                CreateTask create = new CreateTask(listProyects, index, task);
                create.Show();
                this.Hide();
            }
        }
        private Task takeTaskById(int id)
        {
            List<Task> list = this.listProyects[this.index].tasks;
            bool finish = false;
            int i = 0;
            while (i < list.Count && !finish) { 
                if(list[i].id == id) { 
                    finish = true;
                }
                else
                {
                    i++;
                }
            }
            return list[i];
        }

        private void buttonAddDev_Click(object sender, EventArgs e)
        {
            CreateDeveloper c =new CreateDeveloper(this.listProyects,this.index);
            c.Show();
            this.Hide();
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> listRowSelected = dataGridViewTask.SelectedRows.Cast<DataGridViewRow>().ToList();
            if (listRowSelected.Count <= 0 )
            {
                MessageBox.Show("Debes de seleccionar una minimo una fila para eliminarla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<int> listIds = new List<int>();
                foreach (DataGridViewRow row in listRowSelected)
                {
                    listIds.Add((int)row.Cells[0].Value);
                }
                List<Task> tasks = getTaskById(listIds);
                foreach (Task task in tasks) {
                    this.listProyects[index].removeTask(task);
                }
                fillGridView();
            }   
        }
        private List<Task> getTaskById(List<int> listIds)
        {
            List<Task> tasks = new List<Task>();
            int i = 0;
            int j = 0;
            while (tasks.Count != listIds.Count) {
                if (this.listProyects[this.index].tasks[i].id == listIds[j])
                {
                    tasks.Add(this.listProyects[this.index].tasks[i]);
                    j++;
                }
                else
                {
                    i++;
                }
            }
            return tasks;
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            JArray arrayProyect = (JArray)JToken.FromObject(listProyects);
            File.WriteAllText(@"..\..\data\proyects.json", arrayProyect.ToString());
            JArray arrayDevs = (JArray)JToken.FromObject(getDevs());
            File.WriteAllText(@"..\..\data\developers.json", arrayDevs.ToString());
            Menu m = new Menu(listProyects);
            m.Show();
            this.Hide();
        }

        private List<Developer> getDevs()
        {   
            List<Developer>listDevs = new List<Developer>();
            foreach(Proyect proyect in listProyects)
            {
                for (int i = 0; i < proyect.developers.Count; i++)
                {
                    listDevs.Add(proyect.developers[i]);
                }
            }
            return listDevs;
        }
    }
}

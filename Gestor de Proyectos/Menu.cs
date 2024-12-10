using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Proyectos
{
    public partial class Menu : Form
    {
        private List<Proyect> listProyects;

        public Menu(){
            JArray array = JArray.Parse(File.ReadAllText(@"..\..\data\proyects.json"));
            List<Proyect> listProyectsIDs = array.ToObject<List<Proyect>>();

            array = JArray.Parse(File.ReadAllText(@"..\..\data\developers.json"));
            List<Developer> listDevelopersIDs = array.ToObject<List<Developer>>();
            Proyect.updateIDS(listProyectsIDs);
            Developer.updateIDS(listDevelopersIDs);
            Task.updateIDS(listProyectsIDs);
            SubTask.updateIDS(listProyectsIDs);
            this.listProyects = generateFinalListProyects(listDevelopersIDs, listProyectsIDs);
            
            InitializeComponent();
        }

        private List<Proyect> generateFinalListProyects(List<Developer> listDevelopersIDs, List<Proyect> listProyectsIDs){
            List<Developer> listDevs;
            foreach (Proyect proyect in listProyectsIDs)
            {
                listDevs = getDevsById(proyect,listDevelopersIDs);
                for (int i = 0; i < listDevs.Count; i++)
                {
                    listDevs[i].proyect = proyect;
                    addTaskToDev(listDevs[i], proyect.tasks);
                    proyect.developers.Add(listDevs[i]);
                }
            }
            return listProyectsIDs;
        }

        private List<Developer> getDevsById(Proyect proyect, List<Developer> listDevelopers)
        {
            List<Developer> listDevs = new List<Developer>();
            int i = 0;
            int j = 0;
            while (j<proyect.idDevs.Count && i<listDevelopers.Count)
            {
                if (proyect.idDevs.Contains(listDevelopers[i].id))
                {
                    listDevs.Add(listDevelopers[i]);
                    j++;
                    listDevelopers.Remove(listDevelopers[i]);
                }
                else
                {
                    i++;
                }
            }
            return listDevs;
        }

        private void addTaskToDev(Developer dev, List<Task> tasks)
        {
            foreach(Task task in tasks)
            {
                if (task.idDevelopers.Contains(dev.id))
                {
                    dev.tasks.Add(task);
                    task.developers.Add(dev);
                }
            }
        }

        public Menu(List<Proyect> listProyects)
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

        private void buttonSearchProyect_Click(object sender, EventArgs e)
        {
            SelectProyect p = new SelectProyect(listProyects);
            p.Show();
            this.Hide();
        }

        private void buttonDeleteProyect_Click(object sender, EventArgs e)
        {

        }
    }
}

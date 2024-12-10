using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Proyectos
{
    public class Task
    {   
        private static int total = 0;
        public List<int> idDevelopers = new List<int>();
        public int id { get; set; }
        public String name { get; set; }
        public List<SubTask> subTask { get; set; }
        public bool finish { get; set; }
        public DateTime dateFinish { get; set; }
        [JsonIgnore]
        public List<Developer> developers { get; set; }

        public Task(String name, List<SubTask> subTask, List<Developer> developers, DateTime dateFinish)
        {
            this.name = name;
            this.subTask = subTask;
            this.finish = false;
            this.developers = developers;
            Task.total++;
            this.id = Task.total;
            this.dateFinish = dateFinish;
            foreach (Developer devs in this.developers)
            {
                devs.addTask(this);
                idDevelopers.Add(devs.id);
            }
        }
        [JsonConstructor]
        public Task(List<int> idDevelopers, int id,String name, List<SubTask> subTask, bool finish, DateTime dateFinish)
        {
            this.idDevelopers = idDevelopers;
            this.name = name;
            this.subTask = subTask;
            this.finish = finish;
            this.id = id;
            this.dateFinish =dateFinish;
            this.developers = new List<Developer>();

        }
        public void addDeveloper(Developer developer)
        {
            this.developers.Add(developer);
            this.idDevelopers.Add(developer.id);
        }
        public void removeDeveloper(Developer developer)
        {
            this.developers.Remove(developer);
            this.idDevelopers.Remove(developer.id);
        }
        public void addSubTask(SubTask subTask)
        {
            this.subTask.Add(subTask);
        }
        public void removeSubTask(SubTask subTask)
        {
            this.subTask.Remove(subTask);
        }
        public string takeNameDevs()
        {
            string names = "";
            for (int i = 0; i < this.developers.Count; i++)
            {
                names += this.developers[i].ToString();
                if (i == this.developers.Count - 1)
                {
                    names += ".";
                }
                else
                {
                    names += ", ";
                }
            }
            return names;
        }
        public int getPercentatge()
        {
            int subTaskDone = takeSubTaskDone();
            if (subTaskDone == 0)
            {
                return 0;
            }
            else
            {
                return (int)this.subTask.Count / subTaskDone;
            }
            
        }

        private int takeSubTaskDone()
        {
            int total = 0;
            foreach (var subTask in this.subTask)
            {
                if (subTask.state == "done")
                {
                    total++;
                }
            }
            return total;
        }
        public void changeAllDevs(List<Developer>devs)
        {
            this.developers.Clear();
            this.idDevelopers.Clear();
            foreach (var dev in devs)
            {
                this.developers.Add(dev);
                this.idDevelopers.Add(dev.id);
            }
        }
    }
}

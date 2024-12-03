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
        private int id { get; set; }
        public String name { get; set; }
        private List<SubTask> subTask { get; set; }
        public bool finish { get; set; }
        private List<Developer> developers { get; set; }
        public DateTime dateFinish { get; set; }

        public Task(String name, List<SubTask> subTask, List<Developer> developers, DateTime dateFinish)
        {
            this.name = name;
            this.subTask = subTask;
            this.finish = false;
            this.developers = developers;
            Task.total++;
            this.id = Task.total;
            this.dateFinish = dateFinish;
        }
        public void addDeveloper(Developer developer)
        {
            this.developers.Add(developer);
        }
        public void removeDeveloper(Developer developer)
        {
            this.developers.Remove(developer);
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
    }
}

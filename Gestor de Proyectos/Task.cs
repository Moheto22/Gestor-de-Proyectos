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
        private String name { get; set; }
        private List<SubTask> subTask { get; set; }
        private bool finish { get; set; }
        private List<Developer> developers { get; set; }
        private DateTime dateFinish { get; set; }

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
            
    }
}

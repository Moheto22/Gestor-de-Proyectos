using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Proyectos
{
    public class Tarea
    {
        private static int total = 0;
        private int id { get; set; }
        private String name { get; set; }
        private List<SubTarea> subTask { get; set; }
        private bool finish { get; set; }
        private List<Developer> developers { get; set; }

        public Tarea(String name, List<SubTarea> subTask, List<Developer> developers)
        {
            this.name = name;
            this.subTask = subTask;
            this.finish = false;
            this.developers = developers;
            Tarea.total++;
            this.id = Tarea.total;
        }
        public void addDeveloper(Developer developer)
        {
            this.developers.Add(developer);
        }
        public void removeDeveloper(Developer developer)
        {
            this.developers.Remove(developer);
        }
        public void addSubTask(SubTarea subTask)
        {
            this.subTask.Add(subTask);
        }
        public void removeSubTask(SubTarea subTask)
        {
            this.subTask.Remove(subTask);
        }
            
    }
}

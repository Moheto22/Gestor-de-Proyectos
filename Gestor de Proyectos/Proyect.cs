using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Gestor_de_Proyectos
{
    public class Proyect
    {
        private static int total = 0;
        private int id { get; set; }
        private string name { get; set; }
        private List<Developer> developers { get; set; }
        private List<Task> tasks { get; set; }
        public Proyect( string name, List<Developer> developers, List<Task> tasks)
        {
            this.name = name;
            this.developers = developers;
            this.tasks = tasks;
            Proyect.total++;
            this.id = Proyect.total;
        }
        public void addDeveloper(Developer developer)
        {
            this.developers.Add(developer);
        }
        public void removeDeveloper(Developer developer)
        {
            this.developers.Remove(developer);
        }
        public void addTask(Task task)
        {
            tasks.Add(task);
        }
        public void removeTask(Task task)
        {
            tasks.Remove(task);
        }
    }
}

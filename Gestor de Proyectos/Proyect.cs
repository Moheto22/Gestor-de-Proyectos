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
        public List<Developer> developers { get; set; }
        public List<Task> tasks { get; set; }
        public Proyect( string name)
        {
            this.name = name;
            this.developers = new List<Developer>();
            this.tasks = new List<Task>();
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

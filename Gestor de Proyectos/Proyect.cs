using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Gestor_de_Proyectos
{
    public class Proyect
    {
        private static int total = 0;
        public int id { get; set; }
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
            order();
        }
        public void removeTask(Task task)
        {
            tasks.Remove(task);
        }
        public void order()
        {
            this.tasks = this.tasks.OrderBy(t => t.dateFinish).ToList();
        }
        public override string ToString()
        {
            return $"{name}";
        }
    }
}

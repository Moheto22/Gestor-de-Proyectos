using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Gestor_de_Proyectos
{
    internal class Proyecto
    {
        private static int total = 0;
        private int id { get; set; }
        private string name { get; set; }
        private List<Developer> developers { get; set; }
        private List<Tarea> tasks { get; set; }
        public Proyecto( string name, List<Developer> developers, List<Tarea> tasks)
        {
            this.name = name;
            this.developers = developers;
            this.tasks = tasks;
            Proyecto.total++;
            this.id = Proyecto.total;
        }
        public void addDeveloper(Developer developer)
        {
            this.developers.Add(developer);
        }
        public void removeDeveloper(Developer developer)
        {
            this.developers.Remove(developer);
        }
        public void addTask(Tarea task)
        {
            tasks.Add(task);
        }
        public void removeTask(Tarea task)
        {
            tasks.Remove(task);
        }
    }
}

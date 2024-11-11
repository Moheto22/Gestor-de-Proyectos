using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Proyectos
{
    internal class SubTarea
    {
        private static int total = 0;
        private int id { get; set; }
        private string name { get; set; }
        private Tarea task { get; set; }
        private String state { get; set; }
        public SubTarea( string name, Tarea task)
        {
            this.name = name;
            this.task = task;
            SubTarea.total++;
            this.id = SubTarea.total;
            this.state = "new";
        }

    }
}

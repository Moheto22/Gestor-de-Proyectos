using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Proyectos
{
    public class SubTask
    {
        private static int total = 0;
        public int id { get; set; }
        public string name { get; set; }
        public String state { get; set; }
        public SubTask ( string name)
        {
            this.name = name;
            SubTask.total++;
            this.id = SubTask.total;
            this.state = "new";
        }
        public override string ToString()
        {
            return $"{name}";
        }
    }
}

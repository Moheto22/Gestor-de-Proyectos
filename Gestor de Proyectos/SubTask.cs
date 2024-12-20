using Newtonsoft.Json;
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
        [JsonConstructor]
        public SubTask(int id,string name,string state)
        {
            this.state=state;
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return $"{name}";
        }
        public static void updateIDS(List<Proyect> list)
        {
            int max = 0;
            foreach (Proyect proyect in list)
            {
                for (int i = 0; i<proyect.tasks.Count; i++)
                {
                    for(int j = 0; j < proyect.tasks[i].subTask.Count; j++)
                    {
                        if (proyect.tasks[i].subTask[j].id > max)
                        {
                            max = proyect.tasks[i].subTask[j].id;
                        }
                    }
                }
            }
            total = max;
        }
    }
    
}

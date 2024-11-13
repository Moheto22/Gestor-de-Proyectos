using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Proyectos
{
    internal class Developer
    {
        private static int total = 0;
        private int id { get; set; }
        private String name { get; set; }
        private String surname { get; set; }
        private String password { get; set; }
        private String email { get; set; }
        private List<Tarea> tasks { get; set; }

        public Developer(String name, String surname, String email,String type,List<Tarea>task,String password) {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.tasks = task;
            this.password = password;
            Developer.total++;
            this.id = Developer.total;
        }
        public void addTask(Tarea task)
        {
            tasks.Add(task);
        }
        public void removeTask(Tarea task) {
            tasks.Remove(task); 
        }
    }
}

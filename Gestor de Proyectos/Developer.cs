using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gestor_de_Proyectos
{
    public class Developer
    {
        private static int total = 0;
        public int id { get; set; }
        private List<int> idTask = new List<int>();
        private String name { get; set; }
        private String surname { get; set; }
        private String password { get; set; }
        private String email { get; set; }
        private List<Task> tasks { get; set; }
        private Proyect proyect { get; set; }
        private int idProyect;

        public Developer(String name, String surname, String email,String password,Proyect proyect) {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.tasks = new List<Task>();
            this.password = password;
            Developer.total++;
            this.id = Developer.total;
            this.proyect = proyect;
            this.idProyect = proyect.id;
        }
        public void addTask(Task task)
        {
            tasks.Add(task);
            this.idTask.Add(task.id);
        }
        public void removeTask(Task task) {
            tasks.Remove(task);
            this.idTask.Remove(task.id);
        }
        public override string ToString()
        {
            return $"{name} {surname}";
        }
       
    }
}

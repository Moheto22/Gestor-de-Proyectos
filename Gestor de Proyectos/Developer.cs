using Newtonsoft.Json;
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
        public List<int> idTask = new List<int>();
        public String name { get; set; }
        public String surname { get; set; }
        public String password { get; set; }
        public String email { get; set; }
        public int idProyect;
        [JsonIgnore]
        public List<Task> tasks { get; set; }
        [JsonIgnore]
        public Proyect proyect { get; set; }

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
        [JsonConstructor]
        public Developer(List<int> idTask ,int idProyect,int id, String name, String surname, String password,  String email)
        {
            this.idTask = idTask;
            this.idProyect= idProyect;
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.tasks = new List<Task>();
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

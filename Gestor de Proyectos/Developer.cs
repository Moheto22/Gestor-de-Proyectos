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
        private int id { get; set; }
        private String name { get; set; }
        private String surname { get; set; }
        private String password { get; set; }
        private String email { get; set; }
        private List<Task> tasks { get; set; }

        public Developer(String name, String surname, String email,String password) {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.tasks = new List<Task>();
            this.password = password;
            Developer.total++;
            this.id = Developer.total;
        }
        public void addTask(Task task)
        {
            tasks.Add(task);
        }
        public void removeTask(Task task) {
            tasks.Remove(task); 
        }
        public override string ToString()
        {
            return $"{name} {surname}";
        }
       
    }
}

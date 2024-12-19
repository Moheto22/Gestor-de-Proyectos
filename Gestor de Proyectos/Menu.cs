using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Proyectos
{
    public partial class Menu : Form
    {
        private List<Proyect> listProyects;
        private static string Key = "1234567890123456";
        private static string IV = "abcdefghijklmnop";

        public Menu(){
            string cryptedProyect = File.ReadAllText(@"..\..\data\proyects.json");
            string decryptedProyect = decryptJson(cryptedProyect);
            JArray array = new JArray(decryptedProyect);
            List<Proyect> listProyectsIDs = JsonConvert.DeserializeObject<List<Proyect>>(decryptedProyect);

            string cryptedDevelopers = File.ReadAllText(@"..\..\data\developers.json");
            string decryptedDevelopers = decryptJson(cryptedDevelopers);
            array = new JArray(decryptedDevelopers);
            List<Developer> listDevelopersIDs = JsonConvert.DeserializeObject<List<Developer>>(decryptedDevelopers);

            this.listProyects = generateFinalListProyects(listDevelopersIDs, listProyectsIDs);
            
            InitializeComponent();
        }

        private List<Proyect> generateFinalListProyects(List<Developer> listDevelopersIDs, List<Proyect> listProyectsIDs){
            List<Developer> listDevs;
            foreach (Proyect proyect in listProyectsIDs)
            {
                listDevs = getDevsById(proyect,listDevelopersIDs);
                for (int i = 0; i < listDevs.Count; i++)
                {
                    listDevs[i].proyect = proyect;
                    addTaskToDev(listDevs[i], proyect.tasks);
                    proyect.developers.Add(listDevs[i]);
                }
            }
            return listProyectsIDs;
        }

        private List<Developer> getDevsById(Proyect proyect, List<Developer> listDevelopers)
        {
            List<Developer> listDevs = new List<Developer>();
            int i = 0;
            int j = 0;
            while (j<proyect.idDevs.Count && i<listDevelopers.Count)
            {
                if (proyect.idDevs.Contains(listDevelopers[i].id))
                {
                    listDevs.Add(listDevelopers[i]);
                    j++;
                    listDevelopers.Remove(listDevelopers[i]);
                }
                else
                {
                    i++;
                }
            }
            return listDevs;
        }

        private void addTaskToDev(Developer dev, List<Task> tasks)
        {
            foreach(Task task in tasks)
            {
                if (task.idDevelopers.Contains(dev.id))
                {
                    dev.tasks.Add(task);
                    task.developers.Add(dev);
                }
            }
        }

        public Menu(List<Proyect> listProyects)
        {
            this.listProyects = listProyects;
            InitializeComponent();

        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonCreateProyect_Click(object sender, EventArgs e)
        {
            CreateProyect f = new CreateProyect(listProyects);
            f.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearchProyect_Click(object sender, EventArgs e)
        {
            SelectProyect p = new SelectProyect(listProyects);
            p.Show();
            this.Hide();
        }

        private void buttonDeleteProyect_Click(object sender, EventArgs e)
        {

        }
        public static string decryptJson(string encryptedJson)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(Key);
                aes.IV = Encoding.UTF8.GetBytes(IV);

                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                var encryptedBytes = Convert.FromBase64String(encryptedJson);

                var decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
}

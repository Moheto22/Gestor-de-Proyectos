using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gestor_de_Proyectos
{
    public partial class CreateDeveloper : Form
    {
        private List<Proyect> listProyects = null;
        private List<Developer> listDev = null;
        private int index;
        public CreateDeveloper(List<Developer> listDev, List<Proyect> listProyects)
        {
            InitializeComponent();
            this.listDev = listDev;
            this.listProyects = listProyects;
        }
        public CreateDeveloper(List<Proyect> listProyects, int index)
        {
            InitializeComponent();
            this.listDev = null;
            this.listProyects = listProyects;
            this.index = index;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateDeveloper_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            bool valide = true; 
            String error = "Error:\n";
            if (textBoxNameDev.Text.Equals("")){
                error = error + "No existe nombre de desarrollador.\n";
                valide = false;
            }
            if (textBoxSurnameDev.Text.Equals(""))
            {
                error = error + "No existe apellido del desarrollador.\n";
                valide = false;
            }
            if (valide)
            {
                if (nameExist(textBoxNameDev.Text,textBoxSurnameDev.Text))
                {
                    error = error + "Este nombre y apellidos ya existen.\n";
                    valide = false;
                }
            }
            if (textBoxEmail.Text.Equals(""))
            {
                error = error + "No existe correo electronico del desarrollador.\n";
                valide = false;
            }else if (existEmail(textBoxEmail.Text))
            {
                error = error + "El correo ya existe.\n";
                valide = false;
            }
            
            if (textBoxPasswordDev.Text.Equals(""))
            {
                error = error + "No existe contraseña del desarrollador.\n";
                valide = false;
            }
            if (!valide)
            {
                MessageBox.Show(error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if (listDev == null)
                {
                    this.listProyects[this.index].addDeveloper(new Developer(textBoxNameDev.Text, textBoxSurnameDev.Text, textBoxEmail.Text, textBoxPasswordDev.Text, this.listProyects[this.index]));
                    EditProyect f = new EditProyect(listProyects,index);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    listDev.Add(new Developer(textBoxNameDev.Text, textBoxSurnameDev.Text, textBoxEmail.Text, textBoxPasswordDev.Text, this.listProyects[this.index]));
                    CreateProyect2 f = new CreateProyect2(listProyects, listDev);
                    f.Show();
                    this.Hide();
                }
                
            }
        }

        private bool nameExist(string name, string surname)
        {
            bool exist = false;
            int i = 0;
            if (listDev != null)
            {
                while (!exist && i < listDev.Count)
                {
                    if (name == listDev[i].name && surname == listDev[i].surname)
                    {
                        exist = true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            else
            {
                while (!exist && i < listProyects[index].developers.Count)
                {
                    if (name == listProyects[index].developers[i].name && surname == listProyects[index].developers[i].surname)
                    {
                        exist = true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return exist;
        }

        private bool existEmail(string email)
        {
            bool exist = false;
            int i = 0;
            if (listDev != null)
            {
                while (!exist && i < listDev.Count)
                {
                    if (email == listDev[i].email)
                    {
                        exist = true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            else {
                while (!exist && i < listProyects[index].developers.Count)
                {
                    if (email == listProyects[index].developers[i].email)
                    {
                        exist = true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            
            return exist;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

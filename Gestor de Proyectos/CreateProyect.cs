using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Proyectos
{
    public partial class CreateProyect : Form
    {
        private List<Proyect> listPoroyects = null;
        public CreateProyect(List<Proyect> listProyects)
        {
            this.listPoroyects = listProyects;
            InitializeComponent();
        }

        private void buttonContinueCreateProyect_Click(object sender, EventArgs e)
        {
            string name = textBoxNameProyect.Text;
            if (name == "")
            {
                MessageBox.Show("Error: Debes introducir un nombre para el proyecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (existProyect(name))
            {
                MessageBox.Show("Error: Este nombre de proyecto ya esta en uso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                listPoroyects.Add(new Proyect(name));
                CreateProyect2 f = new CreateProyect2(listPoroyects);
                this.Hide();
                f.Show();
            }
            
        }

        private bool existProyect(string name)
        {
            bool exist = false;
            int i = 0;
            while (!exist && i<listPoroyects.Count) {
                if (name == listPoroyects[i].name)
                {
                    exist = true;
                }
                else {
                    i++;
                }
            }
            return exist;
        }
    }
}

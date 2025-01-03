﻿using System;
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
    public partial class DeleteUser : Form
    {
        private List<Developer> listDev;
        private List<Proyect> listProyects;
        public DeleteUser(List<Developer> listDev, List<Proyect> listProyects)
        {
            this.listProyects = listProyects;
            this.listDev = listDev;
            InitializeComponent();
            listBoxDevData.DataSource = listDev;
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CreateProyect2 f = new CreateProyect2(listProyects,listDev);
            this.Hide();
            f.Show();
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxDevData.SelectedItems)
            { 
                listDev.Remove((Developer)item);
            }
            listBoxDevData.DataSource = null;
            listBoxDevData.DataSource=listDev;
        }

        private void listBoxDevData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {

        }
    }
}

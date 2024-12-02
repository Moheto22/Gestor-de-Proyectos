namespace Gestor_de_Proyectos
{
    partial class CreateTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNameTask = new System.Windows.Forms.Label();
            this.textBoxNameTask = new System.Windows.Forms.TextBox();
            this.textBoxNameSubTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDevProyect = new System.Windows.Forms.ListBox();
            this.listBoxSubTasks = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveDevs = new System.Windows.Forms.Button();
            this.buttonCreateSubTask = new System.Windows.Forms.Button();
            this.buttonDeletteSubTask = new System.Windows.Forms.Button();
            this.buttonCreateTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameTask
            // 
            this.labelNameTask.AutoSize = true;
            this.labelNameTask.BackColor = System.Drawing.Color.Transparent;
            this.labelNameTask.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelNameTask.ForeColor = System.Drawing.Color.Transparent;
            this.labelNameTask.Location = new System.Drawing.Point(260, 237);
            this.labelNameTask.Name = "labelNameTask";
            this.labelNameTask.Size = new System.Drawing.Size(341, 47);
            this.labelNameTask.TabIndex = 0;
            this.labelNameTask.Text = "Nombre de la tarea";
            // 
            // textBoxNameTask
            // 
            this.textBoxNameTask.BackColor = System.Drawing.Color.White;
            this.textBoxNameTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNameTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNameTask.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameTask.ForeColor = System.Drawing.Color.Black;
            this.textBoxNameTask.Location = new System.Drawing.Point(687, 228);
            this.textBoxNameTask.Name = "textBoxNameTask";
            this.textBoxNameTask.Size = new System.Drawing.Size(726, 66);
            this.textBoxNameTask.TabIndex = 14;
            // 
            // textBoxNameSubTask
            // 
            this.textBoxNameSubTask.BackColor = System.Drawing.Color.White;
            this.textBoxNameSubTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNameSubTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNameSubTask.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameSubTask.ForeColor = System.Drawing.Color.Black;
            this.textBoxNameSubTask.Location = new System.Drawing.Point(986, 776);
            this.textBoxNameSubTask.Name = "textBoxNameSubTask";
            this.textBoxNameSubTask.Size = new System.Drawing.Size(357, 66);
            this.textBoxNameSubTask.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(260, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 40);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lista de Desarrolladores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(698, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 47);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lista de subtareas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBoxDevProyect
            // 
            this.listBoxDevProyect.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDevProyect.FormattingEnabled = true;
            this.listBoxDevProyect.ItemHeight = 37;
            this.listBoxDevProyect.Location = new System.Drawing.Point(268, 441);
            this.listBoxDevProyect.Name = "listBoxDevProyect";
            this.listBoxDevProyect.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDevProyect.Size = new System.Drawing.Size(317, 263);
            this.listBoxDevProyect.TabIndex = 18;
            // 
            // listBoxSubTasks
            // 
            this.listBoxSubTasks.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSubTasks.FormattingEnabled = true;
            this.listBoxSubTasks.ItemHeight = 37;
            this.listBoxSubTasks.Location = new System.Drawing.Point(707, 441);
            this.listBoxSubTasks.Name = "listBoxSubTasks";
            this.listBoxSubTasks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSubTasks.Size = new System.Drawing.Size(1004, 263);
            this.listBoxSubTasks.TabIndex = 19;
            this.listBoxSubTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxSubTasks_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(680, 786);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 40);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre subtarea";
            // 
            // buttonSaveDevs
            // 
            this.buttonSaveDevs.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.yellowButton;
            this.buttonSaveDevs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSaveDevs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveDevs.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveDevs.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSaveDevs.Location = new System.Drawing.Point(324, 774);
            this.buttonSaveDevs.Name = "buttonSaveDevs";
            this.buttonSaveDevs.Size = new System.Drawing.Size(232, 68);
            this.buttonSaveDevs.TabIndex = 24;
            this.buttonSaveDevs.Text = "Guardar";
            this.buttonSaveDevs.UseVisualStyleBackColor = true;
            // 
            // buttonCreateSubTask
            // 
            this.buttonCreateSubTask.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.greenButton;
            this.buttonCreateSubTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreateSubTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateSubTask.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateSubTask.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCreateSubTask.Location = new System.Drawing.Point(1428, 774);
            this.buttonCreateSubTask.Name = "buttonCreateSubTask";
            this.buttonCreateSubTask.Size = new System.Drawing.Size(156, 65);
            this.buttonCreateSubTask.TabIndex = 25;
            this.buttonCreateSubTask.Text = "Crear";
            this.buttonCreateSubTask.UseVisualStyleBackColor = true;
            this.buttonCreateSubTask.Click += new System.EventHandler(this.buttonCreateSubTask_Click);
            // 
            // buttonDeletteSubTask
            // 
            this.buttonDeletteSubTask.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.orangeButton;
            this.buttonDeletteSubTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeletteSubTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletteSubTask.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletteSubTask.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDeletteSubTask.Location = new System.Drawing.Point(1599, 774);
            this.buttonDeletteSubTask.Name = "buttonDeletteSubTask";
            this.buttonDeletteSubTask.Size = new System.Drawing.Size(156, 65);
            this.buttonDeletteSubTask.TabIndex = 26;
            this.buttonDeletteSubTask.Text = "Eliminar";
            this.buttonDeletteSubTask.UseVisualStyleBackColor = true;
            // 
            // buttonCreateTask
            // 
            this.buttonCreateTask.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.purpleButton;
            this.buttonCreateTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTask.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTask.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCreateTask.Location = new System.Drawing.Point(651, 886);
            this.buttonCreateTask.Name = "buttonCreateTask";
            this.buttonCreateTask.Size = new System.Drawing.Size(598, 124);
            this.buttonCreateTask.TabIndex = 27;
            this.buttonCreateTask.Text = "Crear tarea";
            this.buttonCreateTask.UseVisualStyleBackColor = true;
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.wallpaperCreateTasks;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonCreateTask);
            this.Controls.Add(this.buttonDeletteSubTask);
            this.Controls.Add(this.buttonCreateSubTask);
            this.Controls.Add(this.buttonSaveDevs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxSubTasks);
            this.Controls.Add(this.listBoxDevProyect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameSubTask);
            this.Controls.Add(this.textBoxNameTask);
            this.Controls.Add(this.labelNameTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateTask";
            this.Text = "CreateTask";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameTask;
        private System.Windows.Forms.TextBox textBoxNameTask;
        private System.Windows.Forms.TextBox textBoxNameSubTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDevProyect;
        private System.Windows.Forms.ListBox listBoxSubTasks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveDevs;
        private System.Windows.Forms.Button buttonCreateSubTask;
        private System.Windows.Forms.Button buttonDeletteSubTask;
        private System.Windows.Forms.Button buttonCreateTask;
    }
}
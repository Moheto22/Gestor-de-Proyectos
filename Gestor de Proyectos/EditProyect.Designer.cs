namespace Gestor_de_Proyectos
{
    partial class EditProyect
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTask = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonPreviousDay = new System.Windows.Forms.Button();
            this.buttonNextDay = new System.Windows.Forms.Button();
            this.buttonEditTask = new System.Windows.Forms.Button();
            this.buttonAddDev = new System.Windows.Forms.Button();
            this.buttonDeleteTask = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTask
            // 
            this.dataGridViewTask.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTask.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTask.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(96)))), ((int)(((byte)(134)))));
            this.dataGridViewTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTask.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridViewTask.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameTask,
            this.devs,
            this.Porcentaje,
            this.finish});
            this.dataGridViewTask.Location = new System.Drawing.Point(709, 268);
            this.dataGridViewTask.Name = "dataGridViewTask";
            this.dataGridViewTask.ReadOnly = true;
            this.dataGridViewTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTask.Size = new System.Drawing.Size(1029, 428);
            this.dataGridViewTask.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // nameTask
            // 
            this.nameTask.DataPropertyName = "name";
            this.nameTask.HeaderText = "Nombre de la Tarea";
            this.nameTask.Name = "nameTask";
            this.nameTask.ReadOnly = true;
            this.nameTask.Width = 300;
            // 
            // devs
            // 
            this.devs.DataPropertyName = "listDev";
            this.devs.HeaderText = "Lista de Desarrolladores";
            this.devs.Name = "devs";
            this.devs.ReadOnly = true;
            this.devs.Width = 435;
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "percentatge";
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            // 
            // finish
            // 
            this.finish.DataPropertyName = "finish";
            this.finish.HeaderText = "Acabado";
            this.finish.Name = "finish";
            this.finish.ReadOnly = true;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.greenButton;
            this.buttonAddTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTask.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTask.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddTask.Location = new System.Drawing.Point(54, 220);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(472, 112);
            this.buttonAddTask.TabIndex = 1;
            this.buttonAddTask.Text = "Agregar una nueva tarea";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonPreviousDay
            // 
            this.buttonPreviousDay.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.blueButton;
            this.buttonPreviousDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPreviousDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousDay.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviousDay.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPreviousDay.Location = new System.Drawing.Point(654, 775);
            this.buttonPreviousDay.Name = "buttonPreviousDay";
            this.buttonPreviousDay.Size = new System.Drawing.Size(412, 121);
            this.buttonPreviousDay.TabIndex = 6;
            this.buttonPreviousDay.Text = "Dia anterior";
            this.buttonPreviousDay.UseVisualStyleBackColor = true;
            this.buttonPreviousDay.Click += new System.EventHandler(this.buttonPreviousDay_Click);
            // 
            // buttonNextDay
            // 
            this.buttonNextDay.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.blueButton;
            this.buttonNextDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNextDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextDay.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextDay.ForeColor = System.Drawing.Color.Transparent;
            this.buttonNextDay.Location = new System.Drawing.Point(1398, 775);
            this.buttonNextDay.Name = "buttonNextDay";
            this.buttonNextDay.Size = new System.Drawing.Size(412, 121);
            this.buttonNextDay.TabIndex = 7;
            this.buttonNextDay.Text = "Dia posterior";
            this.buttonNextDay.UseVisualStyleBackColor = true;
            this.buttonNextDay.Click += new System.EventHandler(this.buttonNextDay_Click);
            // 
            // buttonEditTask
            // 
            this.buttonEditTask.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.blueButton;
            this.buttonEditTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditTask.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTask.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEditTask.Location = new System.Drawing.Point(54, 364);
            this.buttonEditTask.Name = "buttonEditTask";
            this.buttonEditTask.Size = new System.Drawing.Size(472, 112);
            this.buttonEditTask.TabIndex = 8;
            this.buttonEditTask.Text = "Editar tarea";
            this.buttonEditTask.UseVisualStyleBackColor = true;
            this.buttonEditTask.Click += new System.EventHandler(this.buttonEditTask_Click);
            // 
            // buttonAddDev
            // 
            this.buttonAddDev.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.purpleButton;
            this.buttonAddDev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDev.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDev.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddDev.Location = new System.Drawing.Point(54, 502);
            this.buttonAddDev.Name = "buttonAddDev";
            this.buttonAddDev.Size = new System.Drawing.Size(472, 112);
            this.buttonAddDev.TabIndex = 9;
            this.buttonAddDev.Text = "Agregar desarrollador";
            this.buttonAddDev.UseVisualStyleBackColor = true;
            this.buttonAddDev.Click += new System.EventHandler(this.buttonAddDev_Click);
            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.yellowButton;
            this.buttonDeleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTask.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTask.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDeleteTask.Location = new System.Drawing.Point(54, 639);
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Size = new System.Drawing.Size(472, 112);
            this.buttonDeleteTask.TabIndex = 10;
            this.buttonDeleteTask.Text = "Eliminar tarea";
            this.buttonDeleteTask.UseVisualStyleBackColor = true;
            this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.orangeButton;
            this.buttonOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOut.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOut.ForeColor = System.Drawing.Color.Transparent;
            this.buttonOut.Location = new System.Drawing.Point(54, 779);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(472, 112);
            this.buttonOut.TabIndex = 11;
            this.buttonOut.Text = "Salir";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(1137, 812);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(192, 47);
            this.labelDate.TabIndex = 12;
            this.labelDate.Text = "000/00/00";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // EditProyect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.wallpaperEditProyect;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.buttonDeleteTask);
            this.Controls.Add(this.buttonAddDev);
            this.Controls.Add(this.buttonEditTask);
            this.Controls.Add(this.buttonNextDay);
            this.Controls.Add(this.buttonPreviousDay);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.dataGridViewTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProyect";
            this.Text = "EditProyect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditProyect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTask;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonPreviousDay;
        private System.Windows.Forms.Button buttonNextDay;
        private System.Windows.Forms.Button buttonEditTask;
        private System.Windows.Forms.Button buttonAddDev;
        private System.Windows.Forms.Button buttonDeleteTask;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn devs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn finish;
    }
}
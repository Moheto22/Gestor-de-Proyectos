namespace Gestor_de_Proyectos
{
    partial class CreateProyect2
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
            this.buttonAddDev = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonDeleteDev = new System.Windows.Forms.Button();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddDev
            // 
            this.buttonAddDev.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.greenButton;
            this.buttonAddDev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDev.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonAddDev.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddDev.Location = new System.Drawing.Point(626, 511);
            this.buttonAddDev.Name = "buttonAddDev";
            this.buttonAddDev.Size = new System.Drawing.Size(254, 92);
            this.buttonAddDev.TabIndex = 0;
            this.buttonAddDev.Text = "Agregar nuevo desarrollador";
            this.buttonAddDev.UseVisualStyleBackColor = true;
            this.buttonAddDev.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.blueButton;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(835, 609);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 88);
            this.button3.TabIndex = 2;
            this.button3.Text = "Continuar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDev
            // 
            this.buttonDeleteDev.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.purpleButton;
            this.buttonDeleteDev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDev.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteDev.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDeleteDev.Location = new System.Drawing.Point(1001, 511);
            this.buttonDeleteDev.Name = "buttonDeleteDev";
            this.buttonDeleteDev.Size = new System.Drawing.Size(271, 92);
            this.buttonDeleteDev.TabIndex = 3;
            this.buttonDeleteDev.Text = "Eliminar desarrollador";
            this.buttonDeleteDev.UseVisualStyleBackColor = true;
            this.buttonDeleteDev.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.BackColor = System.Drawing.Color.Transparent;
            this.labelNameUser.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameUser.Location = new System.Drawing.Point(712, 445);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(456, 48);
            this.labelNameUser.TabIndex = 7;
            this.labelNameUser.Text = "Crea tu equipo de desarrolladores";
            this.labelNameUser.Click += new System.EventHandler(this.labelNameUser_Click);
            // 
            // CreateProyect2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.wallpaperForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1872, 963);
            this.Controls.Add(this.labelNameUser);
            this.Controls.Add(this.buttonDeleteDev);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAddDev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateProyect2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "CreateProyect2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddDev;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonDeleteDev;
        private System.Windows.Forms.Label labelNameUser;
    }
}
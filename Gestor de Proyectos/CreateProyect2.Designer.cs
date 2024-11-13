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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.greenButton;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(626, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 92);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar nuevo desarrollador";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.wallpaperBlueBoton;
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
            // button2
            // 
            this.button2.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.purpleButton;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(1001, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 92);
            this.button2.TabIndex = 3;
            this.button2.Text = "Eliminar desarrollador";
            this.button2.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateProyect2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "CreateProyect2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelNameUser;
    }
}
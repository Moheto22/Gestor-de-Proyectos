namespace Gestor_de_Proyectos
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonCreateProyect = new System.Windows.Forms.Button();
            this.buttonSearchProyect = new System.Windows.Forms.Button();
            this.buttonDeleteProyect = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateProyect
            // 
            this.buttonCreateProyect.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.bottonAddProyect;
            this.buttonCreateProyect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreateProyect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateProyect.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCreateProyect.Location = new System.Drawing.Point(1033, 164);
            this.buttonCreateProyect.Name = "buttonCreateProyect";
            this.buttonCreateProyect.Size = new System.Drawing.Size(350, 350);
            this.buttonCreateProyect.TabIndex = 0;
            this.buttonCreateProyect.UseVisualStyleBackColor = true;
            this.buttonCreateProyect.Click += new System.EventHandler(this.buttonCreateProyect_Click);
            // 
            // buttonSearchProyect
            // 
            this.buttonSearchProyect.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.bottonSearchProyect;
            this.buttonSearchProyect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchProyect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchProyect.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearchProyect.Location = new System.Drawing.Point(1406, 164);
            this.buttonSearchProyect.Name = "buttonSearchProyect";
            this.buttonSearchProyect.Size = new System.Drawing.Size(350, 350);
            this.buttonSearchProyect.TabIndex = 1;
            this.buttonSearchProyect.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteProyect
            // 
            this.buttonDeleteProyect.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.bottonDeleteProyect;
            this.buttonDeleteProyect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteProyect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProyect.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDeleteProyect.Location = new System.Drawing.Point(1033, 538);
            this.buttonDeleteProyect.Name = "buttonDeleteProyect";
            this.buttonDeleteProyect.Size = new System.Drawing.Size(350, 350);
            this.buttonDeleteProyect.TabIndex = 2;
            this.buttonDeleteProyect.UseVisualStyleBackColor = true;
            // 
            // buttonOut
            // 
            this.buttonOut.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.bottonOut;
            this.buttonOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOut.ForeColor = System.Drawing.Color.Transparent;
            this.buttonOut.Location = new System.Drawing.Point(1406, 538);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(350, 350);
            this.buttonOut.TabIndex = 3;
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.wallpaper_menu;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.buttonDeleteProyect);
            this.Controls.Add(this.buttonSearchProyect);
            this.Controls.Add(this.buttonCreateProyect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateProyect;
        private System.Windows.Forms.Button buttonSearchProyect;
        private System.Windows.Forms.Button buttonDeleteProyect;
        private System.Windows.Forms.Button buttonOut;
    }
}
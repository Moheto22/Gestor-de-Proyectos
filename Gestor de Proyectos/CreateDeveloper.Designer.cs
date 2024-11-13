namespace Gestor_de_Proyectos
{
    partial class CreateDeveloper
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
            this.labelNameUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNameDev = new System.Windows.Forms.TextBox();
            this.textBoxSurnameDev = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPasswordDev = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.BackColor = System.Drawing.Color.Transparent;
            this.labelNameUser.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameUser.ForeColor = System.Drawing.Color.White;
            this.labelNameUser.Location = new System.Drawing.Point(544, 382);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(163, 62);
            this.labelNameUser.TabIndex = 8;
            this.labelNameUser.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(544, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 62);
            this.label1.TabIndex = 9;
            this.label1.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(544, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 62);
            this.label2.TabIndex = 10;
            this.label2.Text = "Corre electronico";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(544, 673);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 62);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.blueButton;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(828, 778);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 87);
            this.button1.TabIndex = 12;
            this.button1.Text = "Crear";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNameDev
            // 
            this.textBoxNameDev.BackColor = System.Drawing.Color.White;
            this.textBoxNameDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNameDev.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNameDev.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameDev.ForeColor = System.Drawing.Color.Black;
            this.textBoxNameDev.Location = new System.Drawing.Point(914, 375);
            this.textBoxNameDev.Name = "textBoxNameDev";
            this.textBoxNameDev.Size = new System.Drawing.Size(431, 66);
            this.textBoxNameDev.TabIndex = 13;
            // 
            // textBoxSurnameDev
            // 
            this.textBoxSurnameDev.BackColor = System.Drawing.Color.White;
            this.textBoxSurnameDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSurnameDev.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurnameDev.ForeColor = System.Drawing.Color.Black;
            this.textBoxSurnameDev.Location = new System.Drawing.Point(914, 471);
            this.textBoxSurnameDev.Name = "textBoxSurnameDev";
            this.textBoxSurnameDev.Size = new System.Drawing.Size(431, 66);
            this.textBoxSurnameDev.TabIndex = 17;
            this.textBoxSurnameDev.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmail.Location = new System.Drawing.Point(914, 571);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(431, 66);
            this.textBoxEmail.TabIndex = 18;
            // 
            // textBoxPasswordDev
            // 
            this.textBoxPasswordDev.BackColor = System.Drawing.Color.White;
            this.textBoxPasswordDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordDev.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordDev.ForeColor = System.Drawing.Color.Black;
            this.textBoxPasswordDev.Location = new System.Drawing.Point(914, 667);
            this.textBoxPasswordDev.Name = "textBoxPasswordDev";
            this.textBoxPasswordDev.Size = new System.Drawing.Size(431, 66);
            this.textBoxPasswordDev.TabIndex = 19;
            // 
            // CreateDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.wallpaperCreateDev;
            this.ClientSize = new System.Drawing.Size(1872, 963);
            this.Controls.Add(this.textBoxPasswordDev);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSurnameDev);
            this.Controls.Add(this.textBoxNameDev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNameUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateDeveloper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateDeveloper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNameDev;
        private System.Windows.Forms.TextBox textBoxSurnameDev;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPasswordDev;
    }
}
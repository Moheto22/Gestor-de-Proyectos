namespace Gestor_de_Proyectos
{
    partial class CreateProyect
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
            this.textBoxNameProyect = new System.Windows.Forms.TextBox();
            this.buttonContinueCreateProyect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.BackColor = System.Drawing.Color.Transparent;
            this.labelNameUser.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameUser.Location = new System.Drawing.Point(807, 433);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(296, 48);
            this.labelNameUser.TabIndex = 6;
            this.labelNameUser.Text = "Nombre del proyecto";
            // 
            // textBoxNameProyect
            // 
            this.textBoxNameProyect.BackColor = System.Drawing.Color.White;
            this.textBoxNameProyect.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameProyect.ForeColor = System.Drawing.Color.Black;
            this.textBoxNameProyect.Location = new System.Drawing.Point(786, 498);
            this.textBoxNameProyect.Name = "textBoxNameProyect";
            this.textBoxNameProyect.Size = new System.Drawing.Size(333, 58);
            this.textBoxNameProyect.TabIndex = 5;
            this.textBoxNameProyect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonContinueCreateProyect
            // 
            this.buttonContinueCreateProyect.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.wallpaperBlueBoton;
            this.buttonContinueCreateProyect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonContinueCreateProyect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinueCreateProyect.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinueCreateProyect.ForeColor = System.Drawing.Color.White;
            this.buttonContinueCreateProyect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonContinueCreateProyect.Location = new System.Drawing.Point(873, 598);
            this.buttonContinueCreateProyect.Name = "buttonContinueCreateProyect";
            this.buttonContinueCreateProyect.Size = new System.Drawing.Size(172, 70);
            this.buttonContinueCreateProyect.TabIndex = 7;
            this.buttonContinueCreateProyect.Text = "Continuar";
            this.buttonContinueCreateProyect.UseVisualStyleBackColor = true;
            // 
            // CreateProyect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.wallpaperForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1888, 1002);
            this.Controls.Add(this.buttonContinueCreateProyect);
            this.Controls.Add(this.labelNameUser);
            this.Controls.Add(this.textBoxNameProyect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateProyect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.TextBox textBoxNameProyect;
        private System.Windows.Forms.Button buttonContinueCreateProyect;
    }
}
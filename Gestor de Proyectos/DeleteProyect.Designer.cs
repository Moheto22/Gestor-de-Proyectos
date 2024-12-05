namespace Gestor_de_Proyectos
{
    partial class DeleteProyect
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.listBoxProData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.orangeButton;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDelete.Location = new System.Drawing.Point(973, 853);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(254, 85);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.blueButton;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBack.Location = new System.Drawing.Point(682, 853);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(254, 85);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Salir";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listBoxProData
            // 
            this.listBoxProData.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxProData.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProData.FormattingEnabled = true;
            this.listBoxProData.ItemHeight = 37;
            this.listBoxProData.Location = new System.Drawing.Point(686, 398);
            this.listBoxProData.Name = "listBoxProData";
            this.listBoxProData.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxProData.Size = new System.Drawing.Size(541, 374);
            this.listBoxProData.TabIndex = 3;
            // 
            // DeleteProyect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.wallpaperDeleteUser;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxProData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteProyect";
            this.Text = "DeleteProyect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeleteProyect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox listBoxProData;
    }
}
namespace Gestor_de_Proyectos
{
    partial class SelectProyect
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
            this.listBoxProyects = new System.Windows.Forms.ListBox();
            this.buttonSelectPro = new System.Windows.Forms.Button();
            this.buttonLeaveSelectionPro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProyects
            // 
            this.listBoxProyects.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxProyects.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProyects.FormattingEnabled = true;
            this.listBoxProyects.ItemHeight = 37;
            this.listBoxProyects.Location = new System.Drawing.Point(690, 397);
            this.listBoxProyects.Name = "listBoxProyects";
            this.listBoxProyects.Size = new System.Drawing.Size(541, 374);
            this.listBoxProyects.TabIndex = 1;
            // 
            // buttonSelectPro
            // 
            this.buttonSelectPro.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.blueButton;
            this.buttonSelectPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelectPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectPro.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonSelectPro.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSelectPro.Location = new System.Drawing.Point(690, 853);
            this.buttonSelectPro.Name = "buttonSelectPro";
            this.buttonSelectPro.Size = new System.Drawing.Size(254, 85);
            this.buttonSelectPro.TabIndex = 2;
            this.buttonSelectPro.Text = "Seleccionar";
            this.buttonSelectPro.UseVisualStyleBackColor = true;
            this.buttonSelectPro.Click += new System.EventHandler(this.buttonSelectPro_Click);
            // 
            // buttonLeaveSelectionPro
            // 
            this.buttonLeaveSelectionPro.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.orangeButton;
            this.buttonLeaveSelectionPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeaveSelectionPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeaveSelectionPro.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonLeaveSelectionPro.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLeaveSelectionPro.Location = new System.Drawing.Point(977, 853);
            this.buttonLeaveSelectionPro.Name = "buttonLeaveSelectionPro";
            this.buttonLeaveSelectionPro.Size = new System.Drawing.Size(254, 85);
            this.buttonLeaveSelectionPro.TabIndex = 3;
            this.buttonLeaveSelectionPro.Text = "Salir";
            this.buttonLeaveSelectionPro.UseVisualStyleBackColor = true;
            this.buttonLeaveSelectionPro.Click += new System.EventHandler(this.buttonLeaveSelectionPro_Click);
            // 
            // SelectProyect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestor_de_Proyectos.Properties.Resources.wallpaperDeleteUser;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonLeaveSelectionPro);
            this.Controls.Add(this.buttonSelectPro);
            this.Controls.Add(this.listBoxProyects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectProyect";
            this.Text = "SelectProyect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SelectProyect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProyects;
        private System.Windows.Forms.Button buttonSelectPro;
        private System.Windows.Forms.Button buttonLeaveSelectionPro;
    }
}
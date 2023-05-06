namespace Presentacion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pACIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarHistorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pACIENTESToolStripMenuItem,
            this.historialToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pACIENTESToolStripMenuItem
            // 
            this.pACIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPacientesToolStripMenuItem,
            this.modificarPacientesToolStripMenuItem});
            this.pACIENTESToolStripMenuItem.Name = "pACIENTESToolStripMenuItem";
            this.pACIENTESToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.pACIENTESToolStripMenuItem.Text = "PACIENTES";
            // 
            // registrarPacientesToolStripMenuItem
            // 
            this.registrarPacientesToolStripMenuItem.Name = "registrarPacientesToolStripMenuItem";
            this.registrarPacientesToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.registrarPacientesToolStripMenuItem.Text = "Registrar pacientes";
            this.registrarPacientesToolStripMenuItem.Click += new System.EventHandler(this.registrarPacientesToolStripMenuItem_Click);
            // 
            // modificarPacientesToolStripMenuItem
            // 
            this.modificarPacientesToolStripMenuItem.Name = "modificarPacientesToolStripMenuItem";
            this.modificarPacientesToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.modificarPacientesToolStripMenuItem.Text = "Modificar Pacientes";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialGeneralToolStripMenuItem,
            this.buscarHistorialToolStripMenuItem});
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.historialToolStripMenuItem.Text = "HISTORIAL";
            // 
            // historialGeneralToolStripMenuItem
            // 
            this.historialGeneralToolStripMenuItem.Name = "historialGeneralToolStripMenuItem";
            this.historialGeneralToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.historialGeneralToolStripMenuItem.Text = "Historial General";
            this.historialGeneralToolStripMenuItem.Click += new System.EventHandler(this.historialGeneralToolStripMenuItem_Click);
            // 
            // buscarHistorialToolStripMenuItem
            // 
            this.buscarHistorialToolStripMenuItem.Name = "buscarHistorialToolStripMenuItem";
            this.buscarHistorialToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.buscarHistorialToolStripMenuItem.Text = "Buscar Historial";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(115, 21);
            this.sALIRToolStripMenuItem.Text = "CERRAR SESION";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 648);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pACIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarHistorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}
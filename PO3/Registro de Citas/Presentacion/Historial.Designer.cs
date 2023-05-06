namespace Presentacion
{
    partial class Historial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PROBLEME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHADECITA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORREO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HISTORIALdg = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HISTORIALdg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.HISTORIALdg);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 345);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "HISTORIAL DE PACIENTES";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(725, 339);
            this.textBox1.TabIndex = 0;
            // 
            // PROBLEME
            // 
            this.PROBLEME.HeaderText = "PROBLEMA";
            this.PROBLEME.MinimumWidth = 6;
            this.PROBLEME.Name = "PROBLEME";
            this.PROBLEME.ReadOnly = true;
            this.PROBLEME.Width = 110;
            // 
            // FECHADECITA
            // 
            this.FECHADECITA.HeaderText = "FECHACITA";
            this.FECHADECITA.MinimumWidth = 6;
            this.FECHADECITA.Name = "FECHADECITA";
            this.FECHADECITA.ReadOnly = true;
            this.FECHADECITA.Width = 110;
            // 
            // CORREO
            // 
            this.CORREO.HeaderText = "CORREO";
            this.CORREO.MinimumWidth = 6;
            this.CORREO.Name = "CORREO";
            this.CORREO.ReadOnly = true;
            this.CORREO.Width = 110;
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.MinimumWidth = 6;
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            this.TELEFONO.Width = 110;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 110;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 110;
            // 
            // HISTORIALdg
            // 
            this.HISTORIALdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HISTORIALdg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NAME,
            this.TELEFONO,
            this.CORREO,
            this.FECHADECITA,
            this.PROBLEME});
            this.HISTORIALdg.Location = new System.Drawing.Point(48, 25);
            this.HISTORIALdg.Name = "HISTORIALdg";
            this.HISTORIALdg.ReadOnly = true;
            this.HISTORIALdg.RowHeadersWidth = 45;
            this.HISTORIALdg.Size = new System.Drawing.Size(701, 150);
            this.HISTORIALdg.TabIndex = 1;
            this.HISTORIALdg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HISTORIALdg_CellContentClick);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Historial";
            this.Text = "Historial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HISTORIALdg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView HISTORIALdg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORREO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHADECITA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROBLEME;
        private System.Windows.Forms.TextBox textBox1;
    }
}
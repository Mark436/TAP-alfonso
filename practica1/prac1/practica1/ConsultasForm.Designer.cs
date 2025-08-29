namespace practica1
{
    partial class ConsultasForm
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
            this.MateriasComboBox = new System.Windows.Forms.ComboBox();
            this.GruposListBox = new System.Windows.Forms.ListBox();
            this.AlumnosListBox = new System.Windows.Forms.ListBox();
            this.ImprimirBtn = new System.Windows.Forms.Button();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MateriasComboBox
            // 
            this.MateriasComboBox.FormattingEnabled = true;
            this.MateriasComboBox.Items.AddRange(new object[] {
            "Español",
            "Inglés",
            "Matemáticas"});
            this.MateriasComboBox.Location = new System.Drawing.Point(51, 45);
            this.MateriasComboBox.Name = "MateriasComboBox";
            this.MateriasComboBox.Size = new System.Drawing.Size(165, 33);
            this.MateriasComboBox.TabIndex = 0;
            this.MateriasComboBox.SelectedIndexChanged += new System.EventHandler(this.MateriasComboBox_SelectedIndexChanged);
            // 
            // GruposListBox
            // 
            this.GruposListBox.FormattingEnabled = true;
            this.GruposListBox.ItemHeight = 25;
            this.GruposListBox.Location = new System.Drawing.Point(51, 160);
            this.GruposListBox.Name = "GruposListBox";
            this.GruposListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.GruposListBox.Size = new System.Drawing.Size(277, 179);
            this.GruposListBox.TabIndex = 1;
            // 
            // AlumnosListBox
            // 
            this.AlumnosListBox.FormattingEnabled = true;
            this.AlumnosListBox.ItemHeight = 25;
            this.AlumnosListBox.Location = new System.Drawing.Point(398, 160);
            this.AlumnosListBox.Name = "AlumnosListBox";
            this.AlumnosListBox.Size = new System.Drawing.Size(277, 179);
            this.AlumnosListBox.TabIndex = 2;
            // 
            // ImprimirBtn
            // 
            this.ImprimirBtn.Location = new System.Drawing.Point(434, 87);
            this.ImprimirBtn.Name = "ImprimirBtn";
            this.ImprimirBtn.Size = new System.Drawing.Size(112, 39);
            this.ImprimirBtn.TabIndex = 3;
            this.ImprimirBtn.Text = "Imprimir";
            this.ImprimirBtn.UseVisualStyleBackColor = true;
            this.ImprimirBtn.Click += new System.EventHandler(this.ImprimirBtn_Click);
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.Location = new System.Drawing.Point(563, 87);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(112, 39);
            this.LimpiarBtn.TabIndex = 4;
            this.LimpiarBtn.Text = "Limpiar";
            this.LimpiarBtn.UseVisualStyleBackColor = true;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(563, 371);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(112, 39);
            this.SalirBtn.TabIndex = 5;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // ConsultasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(735, 437);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.LimpiarBtn);
            this.Controls.Add(this.ImprimirBtn);
            this.Controls.Add(this.AlumnosListBox);
            this.Controls.Add(this.GruposListBox);
            this.Controls.Add(this.MateriasComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConsultasForm";
            this.Text = "Consultas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox MateriasComboBox;
        private System.Windows.Forms.ListBox GruposListBox;
        private System.Windows.Forms.ListBox AlumnosListBox;
        private System.Windows.Forms.Button ImprimirBtn;
        private System.Windows.Forms.Button LimpiarBtn;
        private System.Windows.Forms.Button SalirBtn;
    }
}
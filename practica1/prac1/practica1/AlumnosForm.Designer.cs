namespace practica1
{
    partial class Alumnos
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
            this.AlumnosComboBox = new System.Windows.Forms.ComboBox();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.ApellidosTextBox = new System.Windows.Forms.TextBox();
            this.TurnoTextBox = new System.Windows.Forms.TextBox();
            this.SemestreTextBox = new System.Windows.Forms.TextBox();
            this.NombresLabel = new System.Windows.Forms.Label();
            this.ApellidosLabel = new System.Windows.Forms.Label();
            this.SemestreLabel = new System.Windows.Forms.Label();
            this.TurnoLabel = new System.Windows.Forms.Label();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlumnosComboBox
            // 
            this.AlumnosComboBox.FormattingEnabled = true;
            this.AlumnosComboBox.Items.AddRange(new object[] {
            "Alvaro Alain",
            "Marcos Javier",
            "Joseph de Jesus"});
            this.AlumnosComboBox.Location = new System.Drawing.Point(49, 49);
            this.AlumnosComboBox.Name = "AlumnosComboBox";
            this.AlumnosComboBox.Size = new System.Drawing.Size(229, 33);
            this.AlumnosComboBox.TabIndex = 0;
            this.AlumnosComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(49, 124);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.ReadOnly = true;
            this.NombresTextBox.Size = new System.Drawing.Size(352, 31);
            this.NombresTextBox.TabIndex = 1;
            // 
            // ApellidosTextBox
            // 
            this.ApellidosTextBox.Location = new System.Drawing.Point(49, 203);
            this.ApellidosTextBox.Name = "ApellidosTextBox";
            this.ApellidosTextBox.ReadOnly = true;
            this.ApellidosTextBox.Size = new System.Drawing.Size(352, 31);
            this.ApellidosTextBox.TabIndex = 2;
            // 
            // TurnoTextBox
            // 
            this.TurnoTextBox.Location = new System.Drawing.Point(49, 373);
            this.TurnoTextBox.Name = "TurnoTextBox";
            this.TurnoTextBox.ReadOnly = true;
            this.TurnoTextBox.Size = new System.Drawing.Size(352, 31);
            this.TurnoTextBox.TabIndex = 4;
            // 
            // SemestreTextBox
            // 
            this.SemestreTextBox.Location = new System.Drawing.Point(49, 292);
            this.SemestreTextBox.Name = "SemestreTextBox";
            this.SemestreTextBox.ReadOnly = true;
            this.SemestreTextBox.Size = new System.Drawing.Size(352, 31);
            this.SemestreTextBox.TabIndex = 3;
            // 
            // NombresLabel
            // 
            this.NombresLabel.AutoSize = true;
            this.NombresLabel.Location = new System.Drawing.Point(49, 94);
            this.NombresLabel.Name = "NombresLabel";
            this.NombresLabel.Size = new System.Drawing.Size(98, 25);
            this.NombresLabel.TabIndex = 5;
            this.NombresLabel.Text = "Nombres";
            // 
            // ApellidosLabel
            // 
            this.ApellidosLabel.AutoSize = true;
            this.ApellidosLabel.Location = new System.Drawing.Point(49, 175);
            this.ApellidosLabel.Name = "ApellidosLabel";
            this.ApellidosLabel.Size = new System.Drawing.Size(100, 25);
            this.ApellidosLabel.TabIndex = 6;
            this.ApellidosLabel.Text = "Apellidos";
            // 
            // SemestreLabel
            // 
            this.SemestreLabel.AutoSize = true;
            this.SemestreLabel.Location = new System.Drawing.Point(49, 264);
            this.SemestreLabel.Name = "SemestreLabel";
            this.SemestreLabel.Size = new System.Drawing.Size(103, 25);
            this.SemestreLabel.TabIndex = 7;
            this.SemestreLabel.Text = "Semestre";
            // 
            // TurnoLabel
            // 
            this.TurnoLabel.AutoSize = true;
            this.TurnoLabel.Location = new System.Drawing.Point(49, 345);
            this.TurnoLabel.Name = "TurnoLabel";
            this.TurnoLabel.Size = new System.Drawing.Size(68, 25);
            this.TurnoLabel.TabIndex = 8;
            this.TurnoLabel.Text = "Turno";
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(296, 516);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(105, 41);
            this.SalirBtn.TabIndex = 9;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(506, 607);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.TurnoLabel);
            this.Controls.Add(this.SemestreLabel);
            this.Controls.Add(this.ApellidosLabel);
            this.Controls.Add(this.NombresLabel);
            this.Controls.Add(this.TurnoTextBox);
            this.Controls.Add(this.SemestreTextBox);
            this.Controls.Add(this.ApellidosTextBox);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.AlumnosComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AlumnosComboBox;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.TextBox ApellidosTextBox;
        private System.Windows.Forms.TextBox TurnoTextBox;
        private System.Windows.Forms.TextBox SemestreTextBox;
        private System.Windows.Forms.Label NombresLabel;
        private System.Windows.Forms.Label ApellidosLabel;
        private System.Windows.Forms.Label SemestreLabel;
        private System.Windows.Forms.Label TurnoLabel;
        private System.Windows.Forms.Button SalirBtn;
    }
}
namespace proyecto_4
{
    partial class Form1
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
            this.BtnHilo1 = new System.Windows.Forms.Button();
            this.BtnHilo2 = new System.Windows.Forms.Button();
            this.BtnHilo4 = new System.Windows.Forms.Button();
            this.BtnHilo3 = new System.Windows.Forms.Button();
            this.EstadoHilo1 = new System.Windows.Forms.Label();
            this.TitleHilos = new System.Windows.Forms.Label();
            this.TitleEstados = new System.Windows.Forms.Label();
            this.EstadoHilo2 = new System.Windows.Forms.Label();
            this.EstadoHilo3 = new System.Windows.Forms.Label();
            this.EstadoHilo4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHilo1
            // 
            this.BtnHilo1.Location = new System.Drawing.Point(77, 84);
            this.BtnHilo1.Name = "BtnHilo1";
            this.BtnHilo1.Size = new System.Drawing.Size(106, 39);
            this.BtnHilo1.TabIndex = 0;
            this.BtnHilo1.Text = "1";
            this.BtnHilo1.UseVisualStyleBackColor = true;
            this.BtnHilo1.Click += new System.EventHandler(this.BtnHilo1_Click);
            // 
            // BtnHilo2
            // 
            this.BtnHilo2.Location = new System.Drawing.Point(77, 129);
            this.BtnHilo2.Name = "BtnHilo2";
            this.BtnHilo2.Size = new System.Drawing.Size(106, 39);
            this.BtnHilo2.TabIndex = 1;
            this.BtnHilo2.Text = "2";
            this.BtnHilo2.UseVisualStyleBackColor = true;
            this.BtnHilo2.Click += new System.EventHandler(this.BtnHilo2_Click);
            // 
            // BtnHilo4
            // 
            this.BtnHilo4.Location = new System.Drawing.Point(77, 219);
            this.BtnHilo4.Name = "BtnHilo4";
            this.BtnHilo4.Size = new System.Drawing.Size(106, 39);
            this.BtnHilo4.TabIndex = 3;
            this.BtnHilo4.Text = "4";
            this.BtnHilo4.UseVisualStyleBackColor = true;
            this.BtnHilo4.Click += new System.EventHandler(this.BtnHilo4_Click);
            // 
            // BtnHilo3
            // 
            this.BtnHilo3.Location = new System.Drawing.Point(77, 174);
            this.BtnHilo3.Name = "BtnHilo3";
            this.BtnHilo3.Size = new System.Drawing.Size(106, 39);
            this.BtnHilo3.TabIndex = 2;
            this.BtnHilo3.Text = "3";
            this.BtnHilo3.UseVisualStyleBackColor = true;
            this.BtnHilo3.Click += new System.EventHandler(this.BtnHilo3_Click);
            // 
            // EstadoHilo1
            // 
            this.EstadoHilo1.AutoSize = true;
            this.EstadoHilo1.Location = new System.Drawing.Point(207, 91);
            this.EstadoHilo1.Name = "EstadoHilo1";
            this.EstadoHilo1.Size = new System.Drawing.Size(80, 25);
            this.EstadoHilo1.TabIndex = 4;
            this.EstadoHilo1.Text = "Espera";
            // 
            // TitleHilos
            // 
            this.TitleHilos.AutoSize = true;
            this.TitleHilos.Location = new System.Drawing.Point(104, 56);
            this.TitleHilos.Name = "TitleHilos";
            this.TitleHilos.Size = new System.Drawing.Size(49, 25);
            this.TitleHilos.TabIndex = 5;
            this.TitleHilos.Text = "Hilo";
            // 
            // TitleEstados
            // 
            this.TitleEstados.AutoSize = true;
            this.TitleEstados.Location = new System.Drawing.Point(207, 56);
            this.TitleEstados.Name = "TitleEstados";
            this.TitleEstados.Size = new System.Drawing.Size(79, 25);
            this.TitleEstados.TabIndex = 6;
            this.TitleEstados.Text = "Estado";
            // 
            // EstadoHilo2
            // 
            this.EstadoHilo2.AutoSize = true;
            this.EstadoHilo2.Location = new System.Drawing.Point(207, 136);
            this.EstadoHilo2.Name = "EstadoHilo2";
            this.EstadoHilo2.Size = new System.Drawing.Size(80, 25);
            this.EstadoHilo2.TabIndex = 7;
            this.EstadoHilo2.Text = "Espera";
            // 
            // EstadoHilo3
            // 
            this.EstadoHilo3.AutoSize = true;
            this.EstadoHilo3.Location = new System.Drawing.Point(207, 181);
            this.EstadoHilo3.Name = "EstadoHilo3";
            this.EstadoHilo3.Size = new System.Drawing.Size(80, 25);
            this.EstadoHilo3.TabIndex = 8;
            this.EstadoHilo3.Text = "Espera";
            // 
            // EstadoHilo4
            // 
            this.EstadoHilo4.AutoSize = true;
            this.EstadoHilo4.Location = new System.Drawing.Point(207, 226);
            this.EstadoHilo4.Name = "EstadoHilo4";
            this.EstadoHilo4.Size = new System.Drawing.Size(80, 25);
            this.EstadoHilo4.TabIndex = 9;
            this.EstadoHilo4.Text = "Espera";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 378);
            this.Controls.Add(this.EstadoHilo4);
            this.Controls.Add(this.EstadoHilo3);
            this.Controls.Add(this.EstadoHilo2);
            this.Controls.Add(this.TitleEstados);
            this.Controls.Add(this.TitleHilos);
            this.Controls.Add(this.EstadoHilo1);
            this.Controls.Add(this.BtnHilo4);
            this.Controls.Add(this.BtnHilo3);
            this.Controls.Add(this.BtnHilo2);
            this.Controls.Add(this.BtnHilo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHilo1;
        private System.Windows.Forms.Button BtnHilo2;
        private System.Windows.Forms.Button BtnHilo4;
        private System.Windows.Forms.Button BtnHilo3;
        private System.Windows.Forms.Label EstadoHilo1;
        private System.Windows.Forms.Label TitleHilos;
        private System.Windows.Forms.Label TitleEstados;
        private System.Windows.Forms.Label EstadoHilo2;
        private System.Windows.Forms.Label EstadoHilo3;
        private System.Windows.Forms.Label EstadoHilo4;
    }
}


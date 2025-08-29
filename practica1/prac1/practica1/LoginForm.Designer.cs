namespace practica1
{
    partial class LoginForm
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
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.IniciarBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AccessibleName = "Nombre de usuario";
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(58, 44);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(86, 25);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Tag = "";
            this.UserLabel.Text = "Usuario";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(64, 77);
            this.UserTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(308, 31);
            this.UserTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(64, 167);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(308, 31);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(64, 129);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(123, 25);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Contraseña";
            // 
            // IniciarBtn
            // 
            this.IniciarBtn.Location = new System.Drawing.Point(64, 233);
            this.IniciarBtn.Margin = new System.Windows.Forms.Padding(6);
            this.IniciarBtn.Name = "IniciarBtn";
            this.IniciarBtn.Size = new System.Drawing.Size(150, 44);
            this.IniciarBtn.TabIndex = 4;
            this.IniciarBtn.Text = "Iniciar";
            this.IniciarBtn.UseVisualStyleBackColor = true;
            this.IniciarBtn.Click += new System.EventHandler(this.IniciarBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(226, 233);
            this.SalirBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(150, 44);
            this.SalirBtn.TabIndex = 5;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(464, 327);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.IniciarBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.UserLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button IniciarBtn;
        private System.Windows.Forms.Button SalirBtn;
    }
}
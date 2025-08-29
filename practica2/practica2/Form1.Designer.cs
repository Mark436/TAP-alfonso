namespace practica2
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
            this.DisplayGridView = new System.Windows.Forms.DataGridView();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.cargarButton = new System.Windows.Forms.Button();
            this.cargarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayGridView
            // 
            this.DisplayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DisplayGridView.Location = new System.Drawing.Point(755, 175);
            this.DisplayGridView.Name = "DisplayGridView";
            this.DisplayGridView.ReadOnly = true;
            this.DisplayGridView.RowHeadersWidth = 82;
            this.DisplayGridView.RowTemplate.Height = 33;
            this.DisplayGridView.Size = new System.Drawing.Size(750, 458);
            this.DisplayGridView.TabIndex = 0;
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Location = new System.Drawing.Point(61, 175);
            this.DisplayTextBox.Multiline = true;
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.ReadOnly = true;
            this.DisplayTextBox.Size = new System.Drawing.Size(676, 458);
            this.DisplayTextBox.TabIndex = 1;
            // 
            // cargarButton
            // 
            this.cargarButton.Location = new System.Drawing.Point(61, 107);
            this.cargarButton.Name = "cargarButton";
            this.cargarButton.Size = new System.Drawing.Size(161, 53);
            this.cargarButton.TabIndex = 2;
            this.cargarButton.Text = "cargar";
            this.cargarButton.UseVisualStyleBackColor = true;
            this.cargarButton.Click += new System.EventHandler(this.cargarButton_Click);
            // 
            // cargarLabel
            // 
            this.cargarLabel.AutoSize = true;
            this.cargarLabel.Location = new System.Drawing.Point(67, 79);
            this.cargarLabel.Name = "cargarLabel";
            this.cargarLabel.Size = new System.Drawing.Size(155, 25);
            this.cargarLabel.TabIndex = 3;
            this.cargarLabel.Text = "Cargar Archivo";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1579, 697);
            this.Controls.Add(this.cargarLabel);
            this.Controls.Add(this.cargarButton);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.DisplayGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DisplayGridView;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Button cargarButton;
        private System.Windows.Forms.Label cargarLabel;
    }
}


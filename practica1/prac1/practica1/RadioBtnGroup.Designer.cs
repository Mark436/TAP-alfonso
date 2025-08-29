namespace practica1
{
    partial class RadioBtnGroup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RadBtnNum1 = new System.Windows.Forms.RadioButton();
            this.RadBtnNum2 = new System.Windows.Forms.RadioButton();
            this.RadBtnNum5 = new System.Windows.Forms.RadioButton();
            this.RadBtnNum4 = new System.Windows.Forms.RadioButton();
            this.RadBtnNum3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RadBtnNum1
            // 
            this.RadBtnNum1.AutoSize = true;
            this.RadBtnNum1.Location = new System.Drawing.Point(13, 17);
            this.RadBtnNum1.Name = "RadBtnNum1";
            this.RadBtnNum1.Size = new System.Drawing.Size(55, 29);
            this.RadBtnNum1.TabIndex = 0;
            this.RadBtnNum1.TabStop = true;
            this.RadBtnNum1.Text = "1";
            this.RadBtnNum1.UseVisualStyleBackColor = true;
            this.RadBtnNum1.CheckedChanged += new System.EventHandler(this.RadBtnNum1_CheckedChanged);
            // 
            // RadBtnNum2
            // 
            this.RadBtnNum2.AutoSize = true;
            this.RadBtnNum2.Location = new System.Drawing.Point(74, 17);
            this.RadBtnNum2.Name = "RadBtnNum2";
            this.RadBtnNum2.Size = new System.Drawing.Size(55, 29);
            this.RadBtnNum2.TabIndex = 1;
            this.RadBtnNum2.TabStop = true;
            this.RadBtnNum2.Text = "2";
            this.RadBtnNum2.UseVisualStyleBackColor = true;
            this.RadBtnNum2.CheckedChanged += new System.EventHandler(this.RadBtnNum2_CheckedChanged);
            // 
            // RadBtnNum5
            // 
            this.RadBtnNum5.AutoSize = true;
            this.RadBtnNum5.Location = new System.Drawing.Point(257, 17);
            this.RadBtnNum5.Name = "RadBtnNum5";
            this.RadBtnNum5.Size = new System.Drawing.Size(55, 29);
            this.RadBtnNum5.TabIndex = 2;
            this.RadBtnNum5.TabStop = true;
            this.RadBtnNum5.Text = "5";
            this.RadBtnNum5.UseVisualStyleBackColor = true;
            this.RadBtnNum5.CheckedChanged += new System.EventHandler(this.RadBtnNum5_CheckedChanged);
            // 
            // RadBtnNum4
            // 
            this.RadBtnNum4.AutoSize = true;
            this.RadBtnNum4.Location = new System.Drawing.Point(196, 17);
            this.RadBtnNum4.Name = "RadBtnNum4";
            this.RadBtnNum4.Size = new System.Drawing.Size(55, 29);
            this.RadBtnNum4.TabIndex = 3;
            this.RadBtnNum4.TabStop = true;
            this.RadBtnNum4.Text = "4";
            this.RadBtnNum4.UseVisualStyleBackColor = true;
            this.RadBtnNum4.CheckedChanged += new System.EventHandler(this.RadBtnNum4_CheckedChanged);
            // 
            // RadBtnNum3
            // 
            this.RadBtnNum3.AutoSize = true;
            this.RadBtnNum3.Location = new System.Drawing.Point(135, 17);
            this.RadBtnNum3.Name = "RadBtnNum3";
            this.RadBtnNum3.Size = new System.Drawing.Size(55, 29);
            this.RadBtnNum3.TabIndex = 4;
            this.RadBtnNum3.TabStop = true;
            this.RadBtnNum3.Text = "3";
            this.RadBtnNum3.UseVisualStyleBackColor = true;
            this.RadBtnNum3.CheckedChanged += new System.EventHandler(this.RadBtnNum3_CheckedChanged);
            // 
            // RadioBtnGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RadBtnNum3);
            this.Controls.Add(this.RadBtnNum4);
            this.Controls.Add(this.RadBtnNum5);
            this.Controls.Add(this.RadBtnNum2);
            this.Controls.Add(this.RadBtnNum1);
            this.Name = "RadioBtnGroup";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(316, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadBtnNum1;
        private System.Windows.Forms.RadioButton RadBtnNum2;
        private System.Windows.Forms.RadioButton RadBtnNum5;
        private System.Windows.Forms.RadioButton RadBtnNum4;
        private System.Windows.Forms.RadioButton RadBtnNum3;
    }
}

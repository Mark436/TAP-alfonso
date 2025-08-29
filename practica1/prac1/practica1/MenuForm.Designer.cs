namespace practica1
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProfesorStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CapturaMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlumnosStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.ImageMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.ImageMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfesorStripMenuItem,
            this.AlumnosStripMenuItem,
            this.SalirStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1444, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProfesorStripMenuItem
            // 
            this.ProfesorStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CapturaMenuStripItem,
            this.ConsultaMenuStripItem});
            this.ProfesorStripMenuItem.Name = "ProfesorStripMenuItem";
            this.ProfesorStripMenuItem.Size = new System.Drawing.Size(122, 36);
            this.ProfesorStripMenuItem.Text = "Profesor";
            // 
            // CapturaMenuStripItem
            // 
            this.CapturaMenuStripItem.Name = "CapturaMenuStripItem";
            this.CapturaMenuStripItem.Size = new System.Drawing.Size(240, 44);
            this.CapturaMenuStripItem.Text = "Captura";
            this.CapturaMenuStripItem.Click += new System.EventHandler(this.CapturaMenuStripItem_Click);
            // 
            // ConsultaMenuStripItem
            // 
            this.ConsultaMenuStripItem.Name = "ConsultaMenuStripItem";
            this.ConsultaMenuStripItem.Size = new System.Drawing.Size(240, 44);
            this.ConsultaMenuStripItem.Text = "Consulta";
            this.ConsultaMenuStripItem.Click += new System.EventHandler(this.ConsultaMenuStripItem_Click);
            // 
            // AlumnosStripMenuItem
            // 
            this.AlumnosStripMenuItem.Name = "AlumnosStripMenuItem";
            this.AlumnosStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.AlumnosStripMenuItem.Text = "Alumnos";
            this.AlumnosStripMenuItem.Click += new System.EventHandler(this.AlumnosStripMenuItem_Click);
            // 
            // SalirStripMenuItem
            // 
            this.SalirStripMenuItem.Name = "SalirStripMenuItem";
            this.SalirStripMenuItem.Size = new System.Drawing.Size(79, 36);
            this.SalirStripMenuItem.Text = "Salir";
            this.SalirStripMenuItem.Click += new System.EventHandler(this.SalirStripMenuItem_Click);
            // 
            // Imagen
            // 
            this.Imagen.ContextMenuStrip = this.ImageMenuStrip;
            this.Imagen.Image = ((System.Drawing.Image)(resources.GetObject("Imagen.Image")));
            this.Imagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("Imagen.InitialImage")));
            this.Imagen.Location = new System.Drawing.Point(668, 338);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(288, 276);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagen.TabIndex = 4;
            this.Imagen.TabStop = false;
            // 
            // ImageMenuStrip
            // 
            this.ImageMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ImageMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesorToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.ImageMenuStrip.Name = "ImageMenuStrip";
            this.ImageMenuStrip.Size = new System.Drawing.Size(183, 118);
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturaToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(182, 38);
            this.profesorToolStripMenuItem.Text = "Profesor";
            // 
            // capturaToolStripMenuItem
            // 
            this.capturaToolStripMenuItem.Name = "capturaToolStripMenuItem";
            this.capturaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.capturaToolStripMenuItem.Text = "Captura";
            this.capturaToolStripMenuItem.Click += new System.EventHandler(this.CapturaMenuStripItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.ConsultaMenuStripItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(182, 38);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.AlumnosStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(182, 38);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.ContextMenuStrip = this.ImageMenuStrip;
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ImageMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProfesorStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CapturaMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultaMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem AlumnosStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirStripMenuItem;
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.ContextMenuStrip ImageMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}


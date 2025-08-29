namespace proyecto3
{
    partial class Modificar
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
            this.gridModificar = new System.Windows.Forms.DataGridView();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lAEMPRESADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lAEMPRESADataSet = new proyecto3.LAEMPRESADataSet();
            this.uSUARIOSTableAdapter = new proyecto3.LAEMPRESADataSetTableAdapters.USUARIOSTableAdapter();
            this.salirBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.claveTxtBox = new System.Windows.Forms.TextBox();
            this.claveLbl = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.nombreTxtBox = new System.Windows.Forms.TextBox();
            this.direccionLbl = new System.Windows.Forms.Label();
            this.direccionTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAEMPRESADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAEMPRESADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridModificar
            // 
            this.gridModificar.AllowUserToAddRows = false;
            this.gridModificar.AllowUserToDeleteRows = false;
            this.gridModificar.AutoGenerateColumns = false;
            this.gridModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridModificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn});
            this.gridModificar.DataSource = this.uSUARIOSBindingSource;
            this.gridModificar.Location = new System.Drawing.Point(150, 76);
            this.gridModificar.Name = "gridModificar";
            this.gridModificar.ReadOnly = true;
            this.gridModificar.RowHeadersWidth = 82;
            this.gridModificar.RowTemplate.Height = 33;
            this.gridModificar.Size = new System.Drawing.Size(1306, 546);
            this.gridModificar.TabIndex = 0;
            // 
            // claveDataGridViewTextBoxColumn
            // 
            this.claveDataGridViewTextBoxColumn.DataPropertyName = "Clave";
            this.claveDataGridViewTextBoxColumn.HeaderText = "Clave";
            this.claveDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            this.claveDataGridViewTextBoxColumn.ReadOnly = true;
            this.claveDataGridViewTextBoxColumn.Width = 200;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 200;
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contraseñaDataGridViewTextBoxColumn.Width = 200;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.lAEMPRESADataSetBindingSource;
            // 
            // lAEMPRESADataSetBindingSource
            // 
            this.lAEMPRESADataSetBindingSource.DataSource = this.lAEMPRESADataSet;
            this.lAEMPRESADataSetBindingSource.Position = 0;
            // 
            // lAEMPRESADataSet
            // 
            this.lAEMPRESADataSet.DataSetName = "LAEMPRESADataSet";
            this.lAEMPRESADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // salirBtn
            // 
            this.salirBtn.Location = new System.Drawing.Point(1362, 666);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(94, 45);
            this.salirBtn.TabIndex = 1;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Location = new System.Drawing.Point(1233, 666);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(112, 45);
            this.modificarBtn.TabIndex = 2;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // claveTxtBox
            // 
            this.claveTxtBox.Location = new System.Drawing.Point(150, 680);
            this.claveTxtBox.Name = "claveTxtBox";
            this.claveTxtBox.Size = new System.Drawing.Size(100, 31);
            this.claveTxtBox.TabIndex = 3;
            // 
            // claveLbl
            // 
            this.claveLbl.AutoSize = true;
            this.claveLbl.Location = new System.Drawing.Point(149, 650);
            this.claveLbl.Name = "claveLbl";
            this.claveLbl.Size = new System.Drawing.Size(67, 25);
            this.claveLbl.TabIndex = 4;
            this.claveLbl.Text = "Clave";
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Location = new System.Drawing.Point(338, 650);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(87, 25);
            this.nombreLbl.TabIndex = 6;
            this.nombreLbl.Text = "Nombre";
            // 
            // nombreTxtBox
            // 
            this.nombreTxtBox.Location = new System.Drawing.Point(339, 680);
            this.nombreTxtBox.Name = "nombreTxtBox";
            this.nombreTxtBox.Size = new System.Drawing.Size(257, 31);
            this.nombreTxtBox.TabIndex = 5;
            // 
            // direccionLbl
            // 
            this.direccionLbl.AutoSize = true;
            this.direccionLbl.Location = new System.Drawing.Point(641, 650);
            this.direccionLbl.Name = "direccionLbl";
            this.direccionLbl.Size = new System.Drawing.Size(102, 25);
            this.direccionLbl.TabIndex = 8;
            this.direccionLbl.Text = "Dirección";
            // 
            // direccionTxtBox
            // 
            this.direccionTxtBox.Location = new System.Drawing.Point(642, 680);
            this.direccionTxtBox.Name = "direccionTxtBox";
            this.direccionTxtBox.Size = new System.Drawing.Size(257, 31);
            this.direccionTxtBox.TabIndex = 7;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(923, 650);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(123, 25);
            this.passwordLbl.TabIndex = 10;
            this.passwordLbl.Text = "Contraseña";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(924, 680);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(257, 31);
            this.passwordTxtBox.TabIndex = 9;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 793);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.direccionLbl);
            this.Controls.Add(this.direccionTxtBox);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.nombreTxtBox);
            this.Controls.Add(this.claveLbl);
            this.Controls.Add(this.claveTxtBox);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.gridModificar);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAEMPRESADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAEMPRESADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridModificar;
        private System.Windows.Forms.BindingSource lAEMPRESADataSetBindingSource;
        private LAEMPRESADataSet lAEMPRESADataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private LAEMPRESADataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.TextBox claveTxtBox;
        private System.Windows.Forms.Label claveLbl;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.TextBox nombreTxtBox;
        private System.Windows.Forms.Label direccionLbl;
        private System.Windows.Forms.TextBox direccionTxtBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTxtBox;
    }
}
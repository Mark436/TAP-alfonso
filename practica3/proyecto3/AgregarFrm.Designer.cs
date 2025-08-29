namespace proyecto3
{
    partial class AgregarFrm
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
            this.gridAgregar = new System.Windows.Forms.DataGridView();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lAEMPRESADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lAEMPRESADataSet = new proyecto3.LAEMPRESADataSet();
            this.uSUARIOSTableAdapter = new proyecto3.LAEMPRESADataSetTableAdapters.USUARIOSTableAdapter();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.nombreTxtBox = new System.Windows.Forms.TextBox();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.direccionLbl = new System.Windows.Forms.Label();
            this.direccionTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.salirBtn = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAEMPRESADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAEMPRESADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAgregar
            // 
            this.gridAgregar.AllowUserToAddRows = false;
            this.gridAgregar.AllowUserToDeleteRows = false;
            this.gridAgregar.AutoGenerateColumns = false;
            this.gridAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAgregar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn});
            this.gridAgregar.DataSource = this.uSUARIOSBindingSource;
            this.gridAgregar.Location = new System.Drawing.Point(157, 151);
            this.gridAgregar.Name = "gridAgregar";
            this.gridAgregar.ReadOnly = true;
            this.gridAgregar.RowHeadersWidth = 82;
            this.gridAgregar.RowTemplate.Height = 33;
            this.gridAgregar.Size = new System.Drawing.Size(1284, 413);
            this.gridAgregar.TabIndex = 0;
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
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(1127, 606);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(153, 44);
            this.agregarBtn.TabIndex = 1;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // nombreTxtBox
            // 
            this.nombreTxtBox.Location = new System.Drawing.Point(341, 619);
            this.nombreTxtBox.Name = "nombreTxtBox";
            this.nombreTxtBox.Size = new System.Drawing.Size(205, 31);
            this.nombreTxtBox.TabIndex = 2;
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Location = new System.Drawing.Point(336, 590);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(87, 25);
            this.nombreLbl.TabIndex = 3;
            this.nombreLbl.Text = "Nombre";
            // 
            // direccionLbl
            // 
            this.direccionLbl.AutoSize = true;
            this.direccionLbl.Location = new System.Drawing.Point(592, 590);
            this.direccionLbl.Name = "direccionLbl";
            this.direccionLbl.Size = new System.Drawing.Size(102, 25);
            this.direccionLbl.TabIndex = 5;
            this.direccionLbl.Text = "Dirección";
            // 
            // direccionTxtBox
            // 
            this.direccionTxtBox.Location = new System.Drawing.Point(597, 619);
            this.direccionTxtBox.Name = "direccionTxtBox";
            this.direccionTxtBox.Size = new System.Drawing.Size(232, 31);
            this.direccionTxtBox.TabIndex = 4;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(878, 590);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(123, 25);
            this.passwordLbl.TabIndex = 7;
            this.passwordLbl.Text = "Contraseña";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(883, 619);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(205, 31);
            this.passwordTxtBox.TabIndex = 6;
            // 
            // salirBtn
            // 
            this.salirBtn.Location = new System.Drawing.Point(1286, 606);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(153, 44);
            this.salirBtn.TabIndex = 8;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(161, 590);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(67, 25);
            this.idLbl.TabIndex = 10;
            this.idLbl.Text = "Clave";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(166, 619);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(130, 31);
            this.idTxtBox.TabIndex = 9;
            // 
            // AgregarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 776);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.direccionLbl);
            this.Controls.Add(this.direccionTxtBox);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.nombreTxtBox);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.gridAgregar);
            this.Name = "AgregarFrm";
            this.Text = "AgregarFrm";
            this.Load += new System.EventHandler(this.EditarFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAEMPRESADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAEMPRESADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAgregar;
        private System.Windows.Forms.BindingSource lAEMPRESADataSetBindingSource;
        private LAEMPRESADataSet lAEMPRESADataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private LAEMPRESADataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.TextBox nombreTxtBox;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label direccionLbl;
        private System.Windows.Forms.TextBox direccionTxtBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox idTxtBox;
    }
}
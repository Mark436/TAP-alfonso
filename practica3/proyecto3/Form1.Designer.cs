namespace proyecto3
{
    partial class mainForm
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
            this.gridViewMain = new System.Windows.Forms.DataGridView();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lAEMPRESADataSet = new proyecto3.LAEMPRESADataSet();
            this.uSUARIOSTableAdapter = new proyecto3.LAEMPRESADataSetTableAdapters.USUARIOSTableAdapter();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.salirBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAEMPRESADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewMain
            // 
            this.gridViewMain.AllowUserToAddRows = false;
            this.gridViewMain.AllowUserToDeleteRows = false;
            this.gridViewMain.AutoGenerateColumns = false;
            this.gridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn});
            this.gridViewMain.DataSource = this.uSUARIOSBindingSource;
            this.gridViewMain.Location = new System.Drawing.Point(111, 72);
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.ReadOnly = true;
            this.gridViewMain.RowHeadersWidth = 82;
            this.gridViewMain.RowTemplate.Height = 33;
            this.gridViewMain.Size = new System.Drawing.Size(1283, 563);
            this.gridViewMain.TabIndex = 0;
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
            this.uSUARIOSBindingSource.DataSource = this.lAEMPRESADataSet;
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
            this.agregarBtn.Location = new System.Drawing.Point(111, 668);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(115, 45);
            this.agregarBtn.TabIndex = 1;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(251, 668);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(115, 45);
            this.eliminarBtn.TabIndex = 2;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Location = new System.Drawing.Point(388, 668);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(115, 45);
            this.modificarBtn.TabIndex = 3;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // salirBtn
            // 
            this.salirBtn.Location = new System.Drawing.Point(522, 668);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(115, 45);
            this.salirBtn.TabIndex = 4;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 817);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.gridViewMain);
            this.Name = "mainForm";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAEMPRESADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewMain;
        private LAEMPRESADataSet lAEMPRESADataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private LAEMPRESADataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Button salirBtn;
    }
}


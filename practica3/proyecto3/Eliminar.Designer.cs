namespace proyecto3
{
    partial class Eliminar
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
            this.gridEliminar = new System.Windows.Forms.DataGridView();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lAEMPRESADataSet = new proyecto3.LAEMPRESADataSet();
            this.uSUARIOSTableAdapter = new proyecto3.LAEMPRESADataSetTableAdapters.USUARIOSTableAdapter();
            this.claveTxtBox = new System.Windows.Forms.TextBox();
            this.claveLbl = new System.Windows.Forms.Label();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.salirBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAEMPRESADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEliminar
            // 
            this.gridEliminar.AllowUserToAddRows = false;
            this.gridEliminar.AllowUserToDeleteRows = false;
            this.gridEliminar.AutoGenerateColumns = false;
            this.gridEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEliminar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn});
            this.gridEliminar.DataSource = this.uSUARIOSBindingSource;
            this.gridEliminar.Location = new System.Drawing.Point(154, 118);
            this.gridEliminar.Name = "gridEliminar";
            this.gridEliminar.ReadOnly = true;
            this.gridEliminar.RowHeadersWidth = 82;
            this.gridEliminar.RowTemplate.Height = 33;
            this.gridEliminar.Size = new System.Drawing.Size(1344, 489);
            this.gridEliminar.TabIndex = 0;
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
            // claveTxtBox
            // 
            this.claveTxtBox.Location = new System.Drawing.Point(666, 653);
            this.claveTxtBox.Name = "claveTxtBox";
            this.claveTxtBox.Size = new System.Drawing.Size(131, 31);
            this.claveTxtBox.TabIndex = 1;
            // 
            // claveLbl
            // 
            this.claveLbl.AutoSize = true;
            this.claveLbl.Location = new System.Drawing.Point(667, 617);
            this.claveLbl.Name = "claveLbl";
            this.claveLbl.Size = new System.Drawing.Size(67, 25);
            this.claveLbl.TabIndex = 2;
            this.claveLbl.Text = "Clave";
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(854, 645);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(122, 39);
            this.eliminarBtn.TabIndex = 3;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // salirBtn
            // 
            this.salirBtn.Location = new System.Drawing.Point(994, 645);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(122, 39);
            this.salirBtn.TabIndex = 4;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1727, 844);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.claveLbl);
            this.Controls.Add(this.claveTxtBox);
            this.Controls.Add(this.gridEliminar);
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAEMPRESADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEliminar;
        private LAEMPRESADataSet lAEMPRESADataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private LAEMPRESADataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox claveTxtBox;
        private System.Windows.Forms.Label claveLbl;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button salirBtn;
    }
}
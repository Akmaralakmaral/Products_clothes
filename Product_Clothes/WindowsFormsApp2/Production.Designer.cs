namespace WindowsFormsApp2
{
    partial class Production
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dB_accounting_material_financial_assetsDataSet = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSet();
            this.productionDataGridView = new System.Windows.Forms.DataGridView();
            this.productManufacturingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_ManufacturingsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.Product_ManufacturingsTableAdapter();
            this.iDProductManufacturingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityProductManufacturingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finished_ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finished_ProductsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.Finished_ProductsTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productManufacturingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(56, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Производство Продукции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Start";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 36;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(528, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(528, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // dB_accounting_material_financial_assetsDataSet
            // 
            this.dB_accounting_material_financial_assetsDataSet.DataSetName = "DB_accounting_material_financial_assetsDataSet";
            this.dB_accounting_material_financial_assetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productionDataGridView
            // 
            this.productionDataGridView.AutoGenerateColumns = false;
            this.productionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductManufacturingDataGridViewTextBoxColumn,
            this.productManufacturingDataGridViewTextBoxColumn,
            this.quantityProductManufacturingDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn});
            this.productionDataGridView.DataSource = this.productManufacturingsBindingSource;
            this.productionDataGridView.Location = new System.Drawing.Point(12, 83);
            this.productionDataGridView.Name = "productionDataGridView";
            this.productionDataGridView.Size = new System.Drawing.Size(716, 333);
            this.productionDataGridView.TabIndex = 40;
            // 
            // productManufacturingsBindingSource
            // 
            this.productManufacturingsBindingSource.DataMember = "Product_Manufacturings";
            this.productManufacturingsBindingSource.DataSource = this.dB_accounting_material_financial_assetsDataSet;
            // 
            // product_ManufacturingsTableAdapter
            // 
            this.product_ManufacturingsTableAdapter.ClearBeforeFill = true;
            // 
            // iDProductManufacturingDataGridViewTextBoxColumn
            // 
            this.iDProductManufacturingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDProductManufacturingDataGridViewTextBoxColumn.DataPropertyName = "ID_Product_Manufacturing";
            this.iDProductManufacturingDataGridViewTextBoxColumn.HeaderText = "ID_Product_Manufacturing";
            this.iDProductManufacturingDataGridViewTextBoxColumn.Name = "iDProductManufacturingDataGridViewTextBoxColumn";
            this.iDProductManufacturingDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProductManufacturingDataGridViewTextBoxColumn.Width = 160;
            // 
            // productManufacturingDataGridViewTextBoxColumn
            // 
            this.productManufacturingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productManufacturingDataGridViewTextBoxColumn.DataPropertyName = "Product_Manufacturing";
            this.productManufacturingDataGridViewTextBoxColumn.HeaderText = "Product_Manufacturing";
            this.productManufacturingDataGridViewTextBoxColumn.Name = "productManufacturingDataGridViewTextBoxColumn";
            this.productManufacturingDataGridViewTextBoxColumn.Width = 143;
            // 
            // quantityProductManufacturingDataGridViewTextBoxColumn
            // 
            this.quantityProductManufacturingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityProductManufacturingDataGridViewTextBoxColumn.DataPropertyName = "Quantity_Product_Manufacturing";
            this.quantityProductManufacturingDataGridViewTextBoxColumn.HeaderText = "Quantity_Product_Manufacturing";
            this.quantityProductManufacturingDataGridViewTextBoxColumn.Name = "quantityProductManufacturingDataGridViewTextBoxColumn";
            this.quantityProductManufacturingDataGridViewTextBoxColumn.Width = 188;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 55;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.Width = 78;
            // 
            // finished_ProductsBindingSource
            // 
            this.finished_ProductsBindingSource.DataMember = "Finished_Products";
            this.finished_ProductsBindingSource.DataSource = this.dB_accounting_material_financial_assetsDataSet;
            // 
            // finished_ProductsTableAdapter
            // 
            this.finished_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.dB_accounting_material_financial_assetsDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Production
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 436);
            this.Controls.Add(this.productionDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Production";
            this.Text = "Production";
            this.Load += new System.EventHandler(this.Production_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productManufacturingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DB_accounting_material_financial_assetsDataSet dB_accounting_material_financial_assetsDataSet;
        private System.Windows.Forms.DataGridView productionDataGridView;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.Product_ManufacturingsTableAdapter product_ManufacturingsTableAdapter;
        private System.Windows.Forms.BindingSource productManufacturingsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductManufacturingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityProductManufacturingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.Finished_ProductsTableAdapter finished_ProductsTableAdapter;
        private System.Windows.Forms.BindingSource finished_ProductsBindingSource;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
    }
}
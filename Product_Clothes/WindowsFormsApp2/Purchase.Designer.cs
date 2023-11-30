namespace WindowsFormsApp2
{
    partial class Purchase
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
            this.tableAdapterManager = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager();
            this.employeesTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.EmployeesTableAdapter();
            this.purchase_Raw_MaterialsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.Purchase_Raw_MaterialsTableAdapter();
            this.raw_materialsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.Raw_materialsTableAdapter();
            this.purchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.iDPurchaseRawMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityPurchaseRawMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPurchaseRawMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_Raw_MaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_Raw_MaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raw_materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(171, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Закупка Сырья";
           // this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Start";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 30;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(519, 41);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(519, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // dB_accounting_material_financial_assetsDataSet
            // 
            this.dB_accounting_material_financial_assetsDataSet.DataSetName = "DB_accounting_material_financial_assetsDataSet";
            this.dB_accounting_material_financial_assetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.Employee_PositionsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.Finished_ProductsTableAdapter = null;
            this.tableAdapterManager.IngredientsTableAdapter = null;
            this.tableAdapterManager.Product_ManufacturingsTableAdapter = null;
            this.tableAdapterManager.Purchase_Raw_MaterialsTableAdapter = this.purchase_Raw_MaterialsTableAdapter;
            this.tableAdapterManager.Raw_materialsTableAdapter = this.raw_materialsTableAdapter;
            this.tableAdapterManager.Sales_of_productsTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasurementsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // purchase_Raw_MaterialsTableAdapter
            // 
            this.purchase_Raw_MaterialsTableAdapter.ClearBeforeFill = true;
            // 
            // raw_materialsTableAdapter
            // 
            this.raw_materialsTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseDataGridView
            // 
            this.purchaseDataGridView.AutoGenerateColumns = false;
            this.purchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPurchaseRawMaterialDataGridViewTextBoxColumn,
            this.rawMaterialDataGridViewTextBoxColumn,
            this.quantityPurchaseRawMaterialDataGridViewTextBoxColumn,
            this.amountPurchaseRawMaterialDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn});
            this.purchaseDataGridView.DataSource = this.purchase_Raw_MaterialsBindingSource;
            this.purchaseDataGridView.Location = new System.Drawing.Point(12, 82);
            this.purchaseDataGridView.Name = "purchaseDataGridView";
            this.purchaseDataGridView.Size = new System.Drawing.Size(885, 371);
            this.purchaseDataGridView.TabIndex = 34;
            // 
            // iDPurchaseRawMaterialDataGridViewTextBoxColumn
            // 
            this.iDPurchaseRawMaterialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDPurchaseRawMaterialDataGridViewTextBoxColumn.DataPropertyName = "ID_Purchase_Raw_Material";
            this.iDPurchaseRawMaterialDataGridViewTextBoxColumn.HeaderText = "ID_Purchase_Raw_Material";
            this.iDPurchaseRawMaterialDataGridViewTextBoxColumn.Name = "iDPurchaseRawMaterialDataGridViewTextBoxColumn";
            this.iDPurchaseRawMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPurchaseRawMaterialDataGridViewTextBoxColumn.Width = 165;
            // 
            // rawMaterialDataGridViewTextBoxColumn
            // 
            this.rawMaterialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rawMaterialDataGridViewTextBoxColumn.DataPropertyName = "Raw_Material";
            this.rawMaterialDataGridViewTextBoxColumn.HeaderText = "Raw_Material";
            this.rawMaterialDataGridViewTextBoxColumn.Name = "rawMaterialDataGridViewTextBoxColumn";
            this.rawMaterialDataGridViewTextBoxColumn.Width = 97;
            // 
            // quantityPurchaseRawMaterialDataGridViewTextBoxColumn
            // 
            this.quantityPurchaseRawMaterialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityPurchaseRawMaterialDataGridViewTextBoxColumn.DataPropertyName = "Quantity_Purchase_Raw_Material";
            this.quantityPurchaseRawMaterialDataGridViewTextBoxColumn.HeaderText = "Quantity_Purchase_Raw_Material";
            this.quantityPurchaseRawMaterialDataGridViewTextBoxColumn.Name = "quantityPurchaseRawMaterialDataGridViewTextBoxColumn";
            this.quantityPurchaseRawMaterialDataGridViewTextBoxColumn.Width = 193;
            // 
            // amountPurchaseRawMaterialDataGridViewTextBoxColumn
            // 
            this.amountPurchaseRawMaterialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amountPurchaseRawMaterialDataGridViewTextBoxColumn.DataPropertyName = "Amount__Purchase_Raw_Material";
            this.amountPurchaseRawMaterialDataGridViewTextBoxColumn.HeaderText = "Amount__Purchase_Raw_Material";
            this.amountPurchaseRawMaterialDataGridViewTextBoxColumn.Name = "amountPurchaseRawMaterialDataGridViewTextBoxColumn";
            this.amountPurchaseRawMaterialDataGridViewTextBoxColumn.Width = 196;
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
            // purchase_Raw_MaterialsBindingSource
            // 
            this.purchase_Raw_MaterialsBindingSource.DataMember = "Purchase_Raw_Materials";
            this.purchase_Raw_MaterialsBindingSource.DataSource = this.dB_accounting_material_financial_assetsDataSet;
            // 
            // raw_materialsBindingSource
            // 
            this.raw_materialsBindingSource.DataMember = "Raw_materials";
            this.raw_materialsBindingSource.DataSource = this.dB_accounting_material_financial_assetsDataSet;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.dB_accounting_material_financial_assetsDataSet;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 465);
            this.Controls.Add(this.purchaseDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_Raw_MaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raw_materialsBindingSource)).EndInit();
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
        private DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.Purchase_Raw_MaterialsTableAdapter purchase_Raw_MaterialsTableAdapter;
        private System.Windows.Forms.DataGridView purchaseDataGridView;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.Raw_materialsTableAdapter raw_materialsTableAdapter;
        private System.Windows.Forms.BindingSource purchase_Raw_MaterialsBindingSource;
        private System.Windows.Forms.BindingSource raw_materialsBindingSource;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPurchaseRawMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPurchaseRawMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPurchaseRawMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
    }
}
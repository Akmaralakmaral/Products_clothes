namespace WindowsFormsApp2
{
    partial class Sale
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
            this.saleDataGridView = new System.Windows.Forms.DataGridView();
            this.salesofproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sales_of_productsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.Sales_of_productsTableAdapter();
            this.iDSalesofproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSalesofproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitySalesofproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountSalesofproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finished_ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finished_ProductsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.Finished_ProductsTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesofproductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(63, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Продажа Продукции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Start";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 42;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(535, 39);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(535, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // dB_accounting_material_financial_assetsDataSet
            // 
            this.dB_accounting_material_financial_assetsDataSet.DataSetName = "DB_accounting_material_financial_assetsDataSet";
            this.dB_accounting_material_financial_assetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleDataGridView
            // 
            this.saleDataGridView.AutoGenerateColumns = false;
            this.saleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSalesofproductDataGridViewTextBoxColumn,
            this.productSalesofproductDataGridViewTextBoxColumn,
            this.quantitySalesofproductDataGridViewTextBoxColumn,
            this.amountSalesofproductDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn});
            this.saleDataGridView.DataSource = this.salesofproductsBindingSource;
            this.saleDataGridView.Location = new System.Drawing.Point(12, 77);
            this.saleDataGridView.Name = "saleDataGridView";
            this.saleDataGridView.Size = new System.Drawing.Size(810, 220);
            this.saleDataGridView.TabIndex = 46;
            // 
            // salesofproductsBindingSource
            // 
            this.salesofproductsBindingSource.DataMember = "Sales_of_products";
            this.salesofproductsBindingSource.DataSource = this.dB_accounting_material_financial_assetsDataSet;
            // 
            // sales_of_productsTableAdapter
            // 
            this.sales_of_productsTableAdapter.ClearBeforeFill = true;
            // 
            // iDSalesofproductDataGridViewTextBoxColumn
            // 
            this.iDSalesofproductDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDSalesofproductDataGridViewTextBoxColumn.DataPropertyName = "ID_Sales_of_product";
            this.iDSalesofproductDataGridViewTextBoxColumn.HeaderText = "ID_Sales_of_product";
            this.iDSalesofproductDataGridViewTextBoxColumn.Name = "iDSalesofproductDataGridViewTextBoxColumn";
            this.iDSalesofproductDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSalesofproductDataGridViewTextBoxColumn.Width = 132;
            // 
            // productSalesofproductDataGridViewTextBoxColumn
            // 
            this.productSalesofproductDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productSalesofproductDataGridViewTextBoxColumn.DataPropertyName = "Product_Sales_of_product";
            this.productSalesofproductDataGridViewTextBoxColumn.HeaderText = "Product_Sales_of_product";
            this.productSalesofproductDataGridViewTextBoxColumn.Name = "productSalesofproductDataGridViewTextBoxColumn";
            this.productSalesofproductDataGridViewTextBoxColumn.Width = 158;
            // 
            // quantitySalesofproductDataGridViewTextBoxColumn
            // 
            this.quantitySalesofproductDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantitySalesofproductDataGridViewTextBoxColumn.DataPropertyName = "Quantity_Sales_of_product";
            this.quantitySalesofproductDataGridViewTextBoxColumn.HeaderText = "Quantity_Sales_of_product";
            this.quantitySalesofproductDataGridViewTextBoxColumn.Name = "quantitySalesofproductDataGridViewTextBoxColumn";
            this.quantitySalesofproductDataGridViewTextBoxColumn.Width = 160;
            // 
            // amountSalesofproductDataGridViewTextBoxColumn
            // 
            this.amountSalesofproductDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amountSalesofproductDataGridViewTextBoxColumn.DataPropertyName = "Amount_Sales_of_product";
            this.amountSalesofproductDataGridViewTextBoxColumn.HeaderText = "Amount_Sales_of_product";
            this.amountSalesofproductDataGridViewTextBoxColumn.Name = "amountSalesofproductDataGridViewTextBoxColumn";
            this.amountSalesofproductDataGridViewTextBoxColumn.Width = 157;
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
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.saleDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Sale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesofproductsBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView saleDataGridView;
        private System.Windows.Forms.BindingSource salesofproductsBindingSource;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.Sales_of_productsTableAdapter sales_of_productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSalesofproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSalesofproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitySalesofproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountSalesofproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource finished_ProductsBindingSource;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.Finished_ProductsTableAdapter finished_ProductsTableAdapter;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
    }
}
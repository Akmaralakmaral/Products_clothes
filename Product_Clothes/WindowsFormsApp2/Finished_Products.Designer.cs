namespace WindowsFormsApp2
{
    partial class Finished_Products
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
            this.label1 = new System.Windows.Forms.Label();
            this.finished_ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_accounting_material_financial_assetsDataSet = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSet();
            this.finished_ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitOfMeasurementsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.UnitOfMeasurementsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager();
            this.finished_ProductsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.Finished_ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(305, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Готовая Продукция";
            // 
            // finished_ProductsBindingSource
            // 
            this.finished_ProductsBindingSource.DataMember = "Finished_Products";
            this.finished_ProductsBindingSource.DataSource = this.dB_accounting_material_financial_assetsDataSet;
            // 
            // dB_accounting_material_financial_assetsDataSet
            // 
            this.dB_accounting_material_financial_assetsDataSet.DataSetName = "DB_accounting_material_financial_assetsDataSet";
            this.dB_accounting_material_financial_assetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finished_ProductsDataGridView
            // 
            this.finished_ProductsDataGridView.AutoGenerateColumns = false;
            this.finished_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finished_ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.finished_ProductsDataGridView.DataSource = this.finished_ProductsBindingSource;
            this.finished_ProductsDataGridView.Location = new System.Drawing.Point(12, 53);
            this.finished_ProductsDataGridView.Name = "finished_ProductsDataGridView";
            this.finished_ProductsDataGridView.Size = new System.Drawing.Size(765, 220);
            this.finished_ProductsDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Finished_Product";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Finished_Product";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 131;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_Finished_Product";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name_Finished_Product";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 148;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitOfMeasurement";
            this.dataGridViewTextBoxColumn3.HeaderText = "UnitOfMeasurement";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 126;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity_Finished_Product";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity_Finished_Product";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 159;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Amount_Finished_Product";
            this.dataGridViewTextBoxColumn5.HeaderText = "Amount_Finished_Product";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 156;
            // 
            // unitOfMeasurementsTableAdapter
            // 
            this.unitOfMeasurementsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.Employee_PositionsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.Finished_ProductsTableAdapter = this.finished_ProductsTableAdapter;
            this.tableAdapterManager.IngredientsTableAdapter = null;
            this.tableAdapterManager.Product_ManufacturingsTableAdapter = null;
            this.tableAdapterManager.Purchase_Raw_MaterialsTableAdapter = null;
            this.tableAdapterManager.Raw_materialsTableAdapter = null;
            this.tableAdapterManager.Sales_of_productsTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasurementsTableAdapter = this.unitOfMeasurementsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // finished_ProductsTableAdapter
            // 
            this.finished_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // Finished_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 293);
            this.Controls.Add(this.finished_ProductsDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Finished_Products";
            this.Text = "Finished_Products";
            this.Load += new System.EventHandler(this.Finished_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DB_accounting_material_financial_assetsDataSet dB_accounting_material_financial_assetsDataSet;
        private System.Windows.Forms.BindingSource finished_ProductsBindingSource;
        private System.Windows.Forms.DataGridView finished_ProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.UnitOfMeasurementsTableAdapter unitOfMeasurementsTableAdapter;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.Finished_ProductsTableAdapter finished_ProductsTableAdapter;
    }
}
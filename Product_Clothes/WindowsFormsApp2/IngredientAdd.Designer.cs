namespace WindowsFormsApp2
{
    partial class IngredientAdd
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dB_accounting_material_financial_assetsDataSet = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSet();
            this.tableAdapterManager = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager();
            this.finished_ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finished_ProductsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.Finished_ProductsTableAdapter();
            this.finished_ProductsComboBox = new System.Windows.Forms.ComboBox();
            this.raw_materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_materialsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.Raw_materialsTableAdapter();
            this.raw_materialsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raw_materialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantity_Ingredient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Raw_material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Finished_Product";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 20);
            this.textBox4.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Новый Ингредиент";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.Finished_ProductsTableAdapter = this.finished_ProductsTableAdapter;
            this.tableAdapterManager.IngredientsTableAdapter = null;
            this.tableAdapterManager.Product_ManufacturingsTableAdapter = null;
            this.tableAdapterManager.Purchase_Raw_MaterialsTableAdapter = null;
            this.tableAdapterManager.Raw_materialsTableAdapter = this.raw_materialsTableAdapter;
            this.tableAdapterManager.Sales_of_productsTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasurementsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // finished_ProductsComboBox
            // 
            this.finished_ProductsComboBox.DataSource = this.finished_ProductsBindingSource;
            this.finished_ProductsComboBox.DisplayMember = "Name_Finished_Product";
            this.finished_ProductsComboBox.FormattingEnabled = true;
            this.finished_ProductsComboBox.Location = new System.Drawing.Point(149, 49);
            this.finished_ProductsComboBox.Name = "finished_ProductsComboBox";
            this.finished_ProductsComboBox.Size = new System.Drawing.Size(168, 21);
            this.finished_ProductsComboBox.TabIndex = 24;
            this.finished_ProductsComboBox.ValueMember = "ID_Finished_Product";
            // 
            // raw_materialsBindingSource
            // 
            this.raw_materialsBindingSource.DataMember = "Raw_materials";
            this.raw_materialsBindingSource.DataSource = this.dB_accounting_material_financial_assetsDataSet;
            // 
            // raw_materialsTableAdapter
            // 
            this.raw_materialsTableAdapter.ClearBeforeFill = true;
            // 
            // raw_materialsComboBox
            // 
            this.raw_materialsComboBox.DataSource = this.raw_materialsBindingSource;
            this.raw_materialsComboBox.DisplayMember = "Name_Raw_material";
            this.raw_materialsComboBox.FormattingEnabled = true;
            this.raw_materialsComboBox.Location = new System.Drawing.Point(149, 81);
            this.raw_materialsComboBox.Name = "raw_materialsComboBox";
            this.raw_materialsComboBox.Size = new System.Drawing.Size(168, 21);
            this.raw_materialsComboBox.TabIndex = 24;
            this.raw_materialsComboBox.ValueMember = "ID_Raw_material";
            // 
            // IngredientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 208);
            this.Controls.Add(this.raw_materialsComboBox);
            this.Controls.Add(this.finished_ProductsComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Name = "IngredientAdd";
            this.Text = "IngredientAdd";
            this.Load += new System.EventHandler(this.IngredientAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raw_materialsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private DB_accounting_material_financial_assetsDataSet dB_accounting_material_financial_assetsDataSet;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.Finished_ProductsTableAdapter finished_ProductsTableAdapter;
        private System.Windows.Forms.BindingSource finished_ProductsBindingSource;
        private System.Windows.Forms.ComboBox finished_ProductsComboBox;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.Raw_materialsTableAdapter raw_materialsTableAdapter;
        private System.Windows.Forms.BindingSource raw_materialsBindingSource;
        private System.Windows.Forms.ComboBox raw_materialsComboBox;
    }
}
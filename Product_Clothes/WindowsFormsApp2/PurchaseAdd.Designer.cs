namespace WindowsFormsApp2
{
    partial class PurchaseAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dB_accounting_material_financial_assetsDataSet = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSet();
            this.tableAdapterManager = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager();
            this.raw_materialsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.Raw_materialsTableAdapter();
            this.raw_materialsComboBox = new System.Windows.Forms.ComboBox();
            this.raw_materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.EmployeesTableAdapter();
            this.employeesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raw_materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 29;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Новая закупка сырья";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Raw Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Employee";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 34;
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
            this.tableAdapterManager.Purchase_Raw_MaterialsTableAdapter = null;
            this.tableAdapterManager.Raw_materialsTableAdapter = this.raw_materialsTableAdapter;
            this.tableAdapterManager.Sales_of_productsTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasurementsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.raw_materialsComboBox.Location = new System.Drawing.Point(115, 45);
            this.raw_materialsComboBox.Name = "raw_materialsComboBox";
            this.raw_materialsComboBox.Size = new System.Drawing.Size(200, 21);
            this.raw_materialsComboBox.TabIndex = 35;
            this.raw_materialsComboBox.ValueMember = "ID_Raw_material";
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
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesComboBox
            // 
            this.employeesComboBox.DataSource = this.employeesBindingSource;
            this.employeesComboBox.DisplayMember = "Name_Employee";
            this.employeesComboBox.FormattingEnabled = true;
            this.employeesComboBox.Location = new System.Drawing.Point(115, 157);
            this.employeesComboBox.Name = "employeesComboBox";
            this.employeesComboBox.Size = new System.Drawing.Size(200, 21);
            this.employeesComboBox.TabIndex = 35;
            this.employeesComboBox.ValueMember = "ID_Employee";
            // 
            // PurchaseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 255);
            this.Controls.Add(this.employeesComboBox);
            this.Controls.Add(this.raw_materialsComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "PurchaseAdd";
            this.Text = "PurchaseAdd";
            this.Load += new System.EventHandler(this.PurchaseAdd_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raw_materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DB_accounting_material_financial_assetsDataSet dB_accounting_material_financial_assetsDataSet;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.Raw_materialsTableAdapter raw_materialsTableAdapter;
        private System.Windows.Forms.ComboBox raw_materialsComboBox;
        private System.Windows.Forms.BindingSource raw_materialsBindingSource;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.ComboBox employeesComboBox;
    }
}
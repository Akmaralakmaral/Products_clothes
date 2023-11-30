namespace WindowsFormsApp2
{
    partial class Ingredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingredients));
            this.label1 = new System.Windows.Forms.Label();
            this.IngredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raw_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dB_accounting_material_financial_assetsDataSet = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSet();
            this.finished_ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finished_ProductsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.Finished_ProductsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager();
            this.ingredientsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.IngredientsTableAdapter();
            this.raw_materialsTableAdapter = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.Raw_materialsTableAdapter();
            this.finished_ProductsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.finished_ProductsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.finished_ProductsListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.finished_ProductsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finished_ProductsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.finished_ProductsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingNavigator)).BeginInit();
            this.finished_ProductsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(225, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ингредиенты";
            // 
            // IngredientsDataGridView
            // 
            this.IngredientsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IngredientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IngredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngredientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Raw_material,
            this.Count});
            this.IngredientsDataGridView.Location = new System.Drawing.Point(139, 53);
            this.IngredientsDataGridView.Name = "IngredientsDataGridView";
            this.IngredientsDataGridView.Size = new System.Drawing.Size(380, 220);
            this.IngredientsDataGridView.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID_Ingredient";
            this.ID.Name = "ID";
            // 
            // Raw_material
            // 
            this.Raw_material.HeaderText = "Raw_material";
            this.Raw_material.Name = "Raw_material";
            // 
            // Count
            // 
            this.Count.HeaderText = "Quantity_Ingredient";
            this.Count.Name = "Count";
            // 
            // dB_accounting_material_financial_assetsDataSet
            // 
            this.dB_accounting_material_financial_assetsDataSet.DataSetName = "DB_accounting_material_financial_assetsDataSet";
            this.dB_accounting_material_financial_assetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.Employee_PositionsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.Finished_ProductsTableAdapter = this.finished_ProductsTableAdapter;
            this.tableAdapterManager.IngredientsTableAdapter = this.ingredientsTableAdapter;
            this.tableAdapterManager.Product_ManufacturingsTableAdapter = null;
            this.tableAdapterManager.Purchase_Raw_MaterialsTableAdapter = null;
            this.tableAdapterManager.Raw_materialsTableAdapter = this.raw_materialsTableAdapter;
            this.tableAdapterManager.Sales_of_productsTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasurementsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ingredientsTableAdapter
            // 
            this.ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // raw_materialsTableAdapter
            // 
            this.raw_materialsTableAdapter.ClearBeforeFill = true;
            // 
            // finished_ProductsBindingNavigator
            // 
            this.finished_ProductsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.finished_ProductsBindingNavigator.BindingSource = this.finished_ProductsBindingSource;
            this.finished_ProductsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.finished_ProductsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.finished_ProductsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.finished_ProductsBindingNavigatorSaveItem});
            this.finished_ProductsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.finished_ProductsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.finished_ProductsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.finished_ProductsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.finished_ProductsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.finished_ProductsBindingNavigator.Name = "finished_ProductsBindingNavigator";
            this.finished_ProductsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.finished_ProductsBindingNavigator.Size = new System.Drawing.Size(627, 25);
            this.finished_ProductsBindingNavigator.TabIndex = 8;
            this.finished_ProductsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // finished_ProductsBindingNavigatorSaveItem
            // 
            this.finished_ProductsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.finished_ProductsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("finished_ProductsBindingNavigatorSaveItem.Image")));
            this.finished_ProductsBindingNavigatorSaveItem.Name = "finished_ProductsBindingNavigatorSaveItem";
            this.finished_ProductsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.finished_ProductsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.finished_ProductsBindingNavigatorSaveItem.Click += new System.EventHandler(this.finished_ProductsBindingNavigatorSaveItem_Click);
            // 
            // finished_ProductsListBox
            // 
            this.finished_ProductsListBox.DataSource = this.finished_ProductsBindingSource;
            this.finished_ProductsListBox.DisplayMember = "Name_Finished_Product";
            this.finished_ProductsListBox.FormattingEnabled = true;
            this.finished_ProductsListBox.Location = new System.Drawing.Point(12, 53);
            this.finished_ProductsListBox.Name = "finished_ProductsListBox";
            this.finished_ProductsListBox.Size = new System.Drawing.Size(121, 225);
            this.finished_ProductsListBox.TabIndex = 8;
            this.finished_ProductsListBox.ValueMember = "ID_Finished_Product";
            this.finished_ProductsListBox.SelectedIndexChanged += new System.EventHandler(this.finished_ProductsListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(525, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "Удаление";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // finished_ProductsBindingSource1
            // 
            this.finished_ProductsBindingSource1.DataMember = "Finished_Products";
            this.finished_ProductsBindingSource1.DataSource = this.dB_accounting_material_financial_assetsDataSet;
            // 
            // finished_ProductsBindingSource2
            // 
            this.finished_ProductsBindingSource2.DataMember = "Finished_Products";
            this.finished_ProductsBindingSource2.DataSource = this.dB_accounting_material_financial_assetsDataSet;
            // 
            // finished_ProductsBindingSource3
            // 
            this.finished_ProductsBindingSource3.DataMember = "Finished_Products";
            this.finished_ProductsBindingSource3.DataSource = this.dB_accounting_material_financial_assetsDataSet;
            // 
            // Ingredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 285);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finished_ProductsListBox);
            this.Controls.Add(this.finished_ProductsBindingNavigator);
            this.Controls.Add(this.IngredientsDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Ingredients";
            this.Text = "Ingredients";
            this.Load += new System.EventHandler(this.Ingredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingNavigator)).EndInit();
            this.finished_ProductsBindingNavigator.ResumeLayout(false);
            this.finished_ProductsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_ProductsBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView IngredientsDataGridView;
        private DB_accounting_material_financial_assetsDataSet dB_accounting_material_financial_assetsDataSet;
        private System.Windows.Forms.BindingSource finished_ProductsBindingSource;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.Finished_ProductsTableAdapter finished_ProductsTableAdapter;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator finished_ProductsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton finished_ProductsBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox finished_ProductsListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource finished_ProductsBindingSource1;
        private System.Windows.Forms.BindingSource finished_ProductsBindingSource2;
        private System.Windows.Forms.BindingSource finished_ProductsBindingSource3;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.Raw_materialsTableAdapter raw_materialsTableAdapter;
        private DB_accounting_material_financial_assetsDataSetTableAdapters.IngredientsTableAdapter ingredientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raw_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}
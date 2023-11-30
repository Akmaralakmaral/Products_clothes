using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters;

namespace WindowsFormsApp2
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
            saleDataGridView.Columns[0].Width = 30;
            saleDataGridView.Columns[3].Width = 20;
            saleDataGridView.Columns[4].Width = 40;
            var box = new DataGridViewComboBoxColumn();
            box.HeaderText = "Product_Sales_Of_Product";
            box.DataSource = finished_ProductsTableAdapter.GetData();
            box.ValueMember = "ID_Finished_Product";
            box.DisplayMember = "Name_Finished_Product";
            box.DataPropertyName = "Product_Sales_Of_Product";
            saleDataGridView.Columns.RemoveAt(1);
            saleDataGridView.Columns.Insert(saleDataGridView.Columns.Count - 4, box);
            saleDataGridView.Columns[1].Width = 45;

            var box1 = new DataGridViewComboBoxColumn();
            box1.HeaderText = "Employee";
            box1.DataSource = employeesTableAdapter.GetData();
            box1.ValueMember = "ID_Employee";
            box1.DisplayMember = "Name_Employee";
            box1.DataPropertyName = "Employee";
            saleDataGridView.Columns.RemoveAt(5);
            saleDataGridView.Columns.Insert(saleDataGridView.Columns.Count - 0, box1);
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Finished_Products". При необходимости она может быть перемещена или удалена.
            this.finished_ProductsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Finished_Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Sales_of_products". При необходимости она может быть перемещена или удалена.
            this.sales_of_productsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Sales_of_products);
           
        }

        private void saleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "the_liquor_storeDataSet.Sale_of_products". При необходимости она может быть перемещена или удалена.
            this.sales_of_productsTableAdapter.Update(this.dB_accounting_material_financial_assetsDataSet.Sales_of_products);

        }

        private void saleDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "the_liquor_storeDataSet.Sale_of_products". При необходимости она может быть перемещена или удалена.
            this.sales_of_productsTableAdapter.Update(this.dB_accounting_material_financial_assetsDataSet.Sales_of_products);

        }


        private void Sale_of_Products_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "the_liquor_storeDataSet.Purchase_of_raw_materials". При необходимости она может быть перемещена или удалена.
            this.sales_of_productsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Sales_of_products);
            saleDataGridView.Update();
            saleDataGridView.Refresh();
        }
    }
}

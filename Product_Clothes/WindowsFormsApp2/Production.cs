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
    public partial class Production : Form
    {
        public Production()
        {
            InitializeComponent();
            productionDataGridView.Columns[0].Width = 50;
            var box = new DataGridViewComboBoxColumn();
            box.HeaderText = "Product_Manufacturing";
            box.DataSource = finished_ProductsTableAdapter.GetData();
            box.ValueMember = "ID_Finished_Product";
            box.DisplayMember = "Name_Finished_Product";
            box.DataPropertyName = "Product_Manufacturing";
            productionDataGridView.Columns.RemoveAt(1);
            productionDataGridView.Columns.Insert(productionDataGridView.Columns.Count - 3, box);

            var box1 = new DataGridViewComboBoxColumn();
            box1.HeaderText = "Employee";
            box1.DataSource = employeesTableAdapter.GetData();
            box1.ValueMember = "ID_Employee";
            box1.DisplayMember = "Name_Employee";
            box1.DataPropertyName = "Employee";
            productionDataGridView.Columns.RemoveAt(4);
            productionDataGridView.Columns.Insert(productionDataGridView.Columns.Count - 0, box1);
        }

        private void Production_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Finished_Products". При необходимости она может быть перемещена или удалена.
            this.finished_ProductsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Finished_Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Product_Manufacturings". При необходимости она может быть перемещена или удалена.
            this.product_ManufacturingsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Product_Manufacturings);
           
        }

        private void productionDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "the_liquor_storeDataSet.Production". При необходимости она может быть перемещена или удалена.
            this.product_ManufacturingsTableAdapter.Update(this.dB_accounting_material_financial_assetsDataSet.Product_Manufacturings);

        }

        private void productionDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "the_liquor_storeDataSet.Production". При необходимости она может быть перемещена или удалена.
            this.product_ManufacturingsTableAdapter.Update(this.dB_accounting_material_financial_assetsDataSet.Product_Manufacturings);

        }

        private void Production_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "the_liquor_storeDataSet.Purchase_of_raw_materials". При необходимости она может быть перемещена или удалена.
            this.product_ManufacturingsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Product_Manufacturings);
            productionDataGridView.Update();
            productionDataGridView.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductionViewer form = new ProductionViewer(dateTimePicker1, dateTimePicker2);
            form.Show();
        }
    }
}

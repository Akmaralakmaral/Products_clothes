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
    public partial class Finished_Products : Form
    {
        public Finished_Products()
        {
            InitializeComponent();
            finished_ProductsDataGridView.Columns[0].Width = 50;
            var box = new DataGridViewComboBoxColumn();
            box.HeaderText = "UnitOfMeasurement";
            box.DataSource = unitOfMeasurementsTableAdapter.GetData();
            box.ValueMember = "ID_UnitOfMeasurement";
            box.DisplayMember = "Name_UnitOfMeasurement";
            box.DataPropertyName = "UnitOfMeasurement";
            finished_ProductsDataGridView.Columns.RemoveAt(2);
            finished_ProductsDataGridView.Columns.Insert(finished_ProductsDataGridView.Columns.Count - 3, box);

          
        }

        private void finished_ProductsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.finished_ProductsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }

        private void Finished_Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.UnitOfMeasurements". При необходимости она может быть перемещена или удалена.
            this.unitOfMeasurementsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.UnitOfMeasurements);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Finished_Products". При необходимости она может быть перемещена или удалена.
            this.finished_ProductsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Finished_Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.UnitOfMeasurements". При необходимости она может быть перемещена или удалена.
            this.finished_ProductsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Finished_Products);
           // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Finished_Products". При необходимости она может быть перемещена или удалена.
            this.finished_ProductsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Finished_Products);

        }

        private void finished_ProductsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.finished_ProductsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }
    }
}

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
    public partial class Raw_Material : Form
    {
        public Raw_Material()
        {
            InitializeComponent();

            raw_materialsDataGridView.Columns[0].Width = 50;
            var box = new DataGridViewComboBoxColumn();
            box.HeaderText = "UnitOfMeasurement";
            box.DataSource = unitOfMeasurementsTableAdapter.GetData();
            box.ValueMember = "ID_UnitOfMeasurement";
            box.DisplayMember = "Name_UnitOfMeasurement";
            box.DataPropertyName = "UnitOfMeasurement";
            raw_materialsDataGridView.Columns.RemoveAt(2);
            raw_materialsDataGridView.Columns.Insert(raw_materialsDataGridView.Columns.Count - 2, box);

        }

        private void raw_materialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raw_materialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }

        private void Raw_Material_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.UnitOfMeasurements". При необходимости она может быть перемещена или удалена.
            this.unitOfMeasurementsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.UnitOfMeasurements);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Raw_materials". При необходимости она может быть перемещена или удалена.
            this.raw_materialsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Raw_materials);

        }
    }
}

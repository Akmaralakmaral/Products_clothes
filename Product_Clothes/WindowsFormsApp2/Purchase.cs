using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
            purchaseDataGridView.Columns[0].Width = 50;
            var box = new DataGridViewComboBoxColumn();
            box.HeaderText = "Raw_Material";
            box.DataSource = raw_materialsTableAdapter.GetData();
            box.ValueMember = "ID_Raw_Material";
            box.DisplayMember = "Name_Raw_material";
            box.DataPropertyName = "Raw_Material";
            purchaseDataGridView.Columns.RemoveAt(1);
            purchaseDataGridView.Columns.Insert(purchaseDataGridView.Columns.Count - 4, box);

            var box1 = new DataGridViewComboBoxColumn();
            box1.HeaderText = "Employee";
            box1.DataSource = employeesTableAdapter.GetData();
            box1.ValueMember = "ID_Employee";
            box1.DisplayMember = "Name_Employee";
            box1.DataPropertyName = "Employee";
            purchaseDataGridView.Columns.RemoveAt(5);
            purchaseDataGridView.Columns.Insert(purchaseDataGridView.Columns.Count - 0, box1);
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Raw_materials". При необходимости она может быть перемещена или удалена.
            this.raw_materialsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Raw_materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Purchase_Raw_Materials". При необходимости она может быть перемещена или удалена.
            this.purchase_Raw_MaterialsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Purchase_Raw_Materials);
            
        }
        private void purchaseDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Purchase_Raw_Materials". При необходимости она может быть перемещена или удалена.
            this.purchase_Raw_MaterialsTableAdapter.Update(this.dB_accounting_material_financial_assetsDataSet.Purchase_Raw_Materials);
        }

        private void purchaseDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Purchase_Raw_Materials". При необходимости она может быть перемещена или удалена.
            this.purchase_Raw_MaterialsTableAdapter.Update(this.dB_accounting_material_financial_assetsDataSet.Purchase_Raw_Materials);
        }


        private void Purchase_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Purchase_Raw_Materials". При необходимости она может быть перемещена или удалена.
            this.purchase_Raw_MaterialsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Purchase_Raw_Materials);
            purchaseDataGridView.Update();
            purchaseDataGridView.Refresh();
        }
    }
}

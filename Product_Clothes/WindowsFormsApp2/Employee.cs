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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            employeesDataGridView.Columns[1].Width= 200;
            employeesDataGridView.Columns[2].Width= 50;
            var box = new DataGridViewComboBoxColumn();
            box.HeaderText = "Position_Employee";
            box.DataSource = employee_PositionsTableAdapter.GetData();
            box.ValueMember = "ID_Position_Employee";
            box.DisplayMember = "Name_Position_Employee";
            box.DataPropertyName = "Position_Employee";
            employeesDataGridView.Columns.RemoveAt(2);
            employeesDataGridView.Columns.Insert(employeesDataGridView.Columns.Count - 3, box);

            
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Employee_Positions". При необходимости она может быть перемещена или удалена.
            this.employee_PositionsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Employee_Positions);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Employees);

        }

        private void employeesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }

        private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void employeesDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.Validate();
            this.employeesTableAdapter.Update(this.dB_accounting_material_financial_assetsDataSet.Employees);
        }

        private void employeesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.employeesTableAdapter.Update(this.dB_accounting_material_financial_assetsDataSet.Employees);
        }
    }
}

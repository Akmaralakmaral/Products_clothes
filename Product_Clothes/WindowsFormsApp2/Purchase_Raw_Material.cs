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
    public partial class Purchase_Raw_Material : Form
    {
        public Purchase_Raw_Material()
        {
            InitializeComponent();
            purchaseDataGridView.Columns[0].Width = 50;
            var box = new DataGridViewComboBoxColumn();
            box.HeaderText = "Name_Raw_material";
            box.DataSource = raw_materialsTableAdapter.GetData();
            box.ValueMember = "ID_Raw_Material";
            box.DisplayMember = "Name_Raw_material";
            box.DataPropertyName = "Name_Raw_material";
            purchaseDataGridView.Columns.RemoveAt(4);
            purchaseDataGridView.Columns.Insert(purchaseDataGridView.Columns.Count-1, box);
            

            //var box1 = new DataGridViewComboBoxColumn();
            //box1.HeaderText = "Name_Employee";
            //box1.DataSource = employeesTableAdapter.GetData();
            //box1.ValueMember = "ID";
            //box1.DisplayMember = "Name";
            //box1.DataPropertyName = "Employee";
            //purchaseDataGridView.Columns.RemoveAt(5);
            //purchaseDataGridView.Columns.Insert(purchaseDataGridView.Columns.Count - 0, box1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ReportPurchase form = new ReportPurchase(dateTimePicker1, dateTimePicker2);
            //form.Show();
        }

        private void Purchase_Raw_Material_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Raw_materials". При необходимости она может быть перемещена или удалена.
            this.raw_materialsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Raw_materials);
         
        }

        private void purchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

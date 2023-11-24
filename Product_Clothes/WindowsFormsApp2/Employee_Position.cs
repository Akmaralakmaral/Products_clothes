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
    public partial class Employee_Position : Form
    {
        public Employee_Position()
        {
            InitializeComponent();
        }

       

        private void Employee_Position_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Employee_Positions". При необходимости она может быть перемещена или удалена.
            this.employee_PositionsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Employee_Positions);
          

        }

        private void employee_PositionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee_PositionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }
    }
}

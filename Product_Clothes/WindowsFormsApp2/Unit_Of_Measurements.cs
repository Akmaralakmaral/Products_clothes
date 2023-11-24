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
    public partial class Unit_Of_Measurements : Form
    {
        public Unit_Of_Measurements()
        {
            InitializeComponent();
        }

        private void unitOfMeasurementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.unitOfMeasurementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }

        private void Unit_Of_Measurements_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.UnitOfMeasurements". При необходимости она может быть перемещена или удалена.
            this.unitOfMeasurementsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.UnitOfMeasurements);

        }

        private void unitOfMeasurementsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

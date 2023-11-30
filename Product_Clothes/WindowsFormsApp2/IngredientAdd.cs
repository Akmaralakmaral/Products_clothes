using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class IngredientAdd : Form
    {
        private string connectionString = Program.strConnection;
        public IngredientAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "IngredientAdd";
            command.Parameters.AddWithValue("@finished_prod", finished_ProductsComboBox.SelectedValue);
            command.Parameters.AddWithValue("@raw_materials", raw_materialsComboBox.SelectedValue);
            command.Parameters.AddWithValue("@Quantity", textBox4.Text);
            command.ExecuteNonQuery();
            dB_accounting_material_financial_assetsDataSet.AcceptChanges();
            connection.Close();
            MessageBox.Show("Новый ингредиент был добавлен");
        }

        private void finished_ProductsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }

        private void IngredientAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Raw_materials". При необходимости она может быть перемещена или удалена.
            this.raw_materialsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Raw_materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Finished_Products". При необходимости она может быть перемещена или удалена.
            this.finished_ProductsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Finished_Products);
           
        }

        private void finished_ProductsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }

        private void raw_materialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }

        private void finished_ProductsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.finished_ProductsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }
    }
}

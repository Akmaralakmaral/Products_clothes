using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class IngredientUpdate : Form
    {
        string connectionString = Program.strConnection;
        public IngredientUpdate(DataRow row)
        {
            InitializeComponent();
            finished_ProductsComboBox.DataSource = finished_ProductsTableAdapter.GetData();
            finished_ProductsComboBox.DisplayMember = "Name_Finished_Product";
            finished_ProductsComboBox.ValueMember = "ID_Finished_Product";
            raw_materialsComboBox.DataSource = raw_materialsTableAdapter.GetData();
            raw_materialsComboBox.DisplayMember = "Raw_material";
            raw_materialsComboBox.ValueMember = "ID_Raw_material";
            textBox1.Text = Convert.ToString(row[0]);
            finished_ProductsComboBox.SelectedValue = row.ItemArray[1];
            raw_materialsComboBox.SelectedValue = row.ItemArray[2];
            textBox4.Text = Convert.ToString(row[3]);   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "IngredientUpdate";
            command.Parameters.AddWithValue("@id", textBox1.Text);
            command.Parameters.AddWithValue("@finished_prod", finished_ProductsComboBox.SelectedValue);
            command.Parameters.AddWithValue("@raw_materials", raw_materialsComboBox.SelectedValue);
            command.Parameters.AddWithValue("@Quantity", textBox4.Text);
            command.ExecuteNonQuery();
            dB_accounting_material_financial_assetsDataSet.AcceptChanges();
            connection.Close();
            MessageBox.Show("Ингредиент был изменен");
            this.Close();

            Ingredients form = new Ingredients();
            form.Show();
        }

        private void finished_ProductsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.finished_ProductsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }

        private void IngredientUpdate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Raw_materials". При необходимости она может быть перемещена или удалена.
            this.raw_materialsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Raw_materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Finished_Products". При необходимости она может быть перемещена или удалена.
            this.finished_ProductsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Finished_Products);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Ingredients form = new Ingredients();
            form.Show();


        }
    }
}

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
using WindowsFormsApp2.DB_accounting_material_financial_assetsDataSetTableAdapters;
using WindowsFormsApp2;

namespace WindowsFormsApp2
{
   
    public partial class Ingredients : Form
    {
        string connectionString = Program.strConnection;
        public Ingredients()
        {
            InitializeComponent();
        }

        private void ingredientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }

        private void Ingredients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Ingredients". При необходимости она может быть перемещена или удалена.
            this.ingredientsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Ingredients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Raw_materials". При необходимости она может быть перемещена или удалена.
            this.raw_materialsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Raw_materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Finished_Products". При необходимости она может быть перемещена или удалена.
            this.finished_ProductsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Finished_Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Finished_Products". При необходимости она может быть перемещена или удалена.
            this.finished_ProductsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Finished_Products);
           

        }

        private void finished_ProductsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.finished_ProductsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }

        private void finished_ProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (finished_ProductsListBox.SelectedValue != null)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetIngredientsForProduct";
                command.Parameters.AddWithValue("@ProductID", finished_ProductsListBox.SelectedValue);
                command.ExecuteNonQuery();
                dB_accounting_material_financial_assetsDataSet.AcceptChanges();
                SqlDataReader d = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (d.Read())
                {
                    data.Add(new string[3]);
                    data[data.Count - 1][0] = d[0].ToString();
                    data[data.Count - 1][1] = d[1].ToString();
                    data[data.Count - 1][2] = d[2].ToString();
                }
                d.Close();
                connection.Close();
                IngredientsDataGridView.Rows.Clear();
                foreach (string[] s in data)
                    IngredientsDataGridView.Rows.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngredientAdd newForm = new IngredientAdd();
            newForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IngredientsDataGridView.SelectedRows.Count > 0)
            {
                int index = IngredientsDataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(IngredientsDataGridView[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                DataTable box = ingredientsTableAdapter.GetData();
                DataRow row = box.Rows.Find(id);
                IngredientUpdate plForm = new IngredientUpdate(row);
                plForm.Show();
                this.Close();
            }

        }
    }
}

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
    public partial class PurchaseAdd : Form
    {

        string connectionString = Program.strConnection;
        public PurchaseAdd()
        {
            InitializeComponent();

        }      

        private void PurchaseAdd_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_accounting_material_financial_assetsDataSet.Raw_materials". При необходимости она может быть перемещена или удалена.
            this.raw_materialsTableAdapter.Fill(this.dB_accounting_material_financial_assetsDataSet.Raw_materials);
        }

        private void raw_materialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raw_materialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_accounting_material_financial_assetsDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SP_Zakupka";
                command.Parameters.AddWithValue("@sum", Convert.ToDouble(textBox2.Text));
                var data = command.Parameters.AddWithValue("@return_value", SqlDbType.Int);
                data.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                dB_accounting_material_financial_assetsDataSet.AcceptChanges();
                SqlDataReader d = command.ExecuteReader();
                var value = data.Value;
                d.Close();
                if (value.Equals(0))
                {
                    SqlCommand command1 = connection.CreateCommand();
                    command1.CommandType = CommandType.StoredProcedure;
                    command1.CommandText = "Purchase_Insert";
                    command1.Parameters.AddWithValue("@raw_material", raw_materialsComboBox.SelectedValue);
                    command1.Parameters.AddWithValue("@quantity", Convert.ToDouble(textBox1.Text));
                    command1.Parameters.AddWithValue("@amount", Convert.ToDouble(textBox2.Text));
                    command1.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    command1.Parameters.AddWithValue("@employee", employeesComboBox.SelectedValue);
                    command1.ExecuteNonQuery();
                    dB_accounting_material_financial_assetsDataSet.AcceptChanges();
                    connection.Close();
                    MessageBox.Show("Новая закупка сырья была добавлена");
                }
                else
                {
                    MessageBox.Show("В бюджете нет средств для закупки сырья");
                }

                connection.Close();

            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class purchaseViewer : Form
    {
        string connectionString = Program.strConnection;
        public purchaseViewer(DateTimePicker start, DateTimePicker end)
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PurchaseDate2";
            command.Parameters.AddWithValue("@start", start.Value);
            command.Parameters.AddWithValue("@end", end.Value);
            command.ExecuteNonQuery();
            dB_accounting_material_financial_assetsDataSet.AcceptChanges();
            SqlDataReader d = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(d);

            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet", data));
            d.Close();
            connection.Close();
        }

        private void purchaseViewer_Load(object sender, EventArgs e)
        {
           
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

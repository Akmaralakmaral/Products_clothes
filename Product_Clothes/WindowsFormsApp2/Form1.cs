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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Budget form = new Budget();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Unit_Of_Measurements form = new Unit_Of_Measurements();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee_Position form = new Employee_Position();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee form = new Employee();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Finished_Products form  = new Finished_Products();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ingredients form= new Ingredients();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Production form = new Production();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Purchase_Raw_Material form = new Purchase_Raw_Material();
            //form.Show();
            Purchase form = new Purchase();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Raw_Material form = new Raw_Material();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Sale form = new Sale();
            form.Show();
        }
    }
}

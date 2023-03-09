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

namespace StudentDataApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(comboBox1.GetItemText(comboBox1.SelectedItem));
            SqlConnection con = new SqlConnection("Server = NLTI159\\SQLEXPRESS; Database = Employment; integrated Security = true");
            SqlCommand command = new SqlCommand($"SELECT *\r\nFROM Student\r\nJOIN Information\r\nON Student.StudentId = Information.ID WHERE StudentId = {studentId}", con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable= new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource= dataTable;
               
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employeedetails form = new Employeedetails();
            form.Show();
            this.Hide();
        }
    }
}

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
    public partial class Employeedetails : Form
    {
        public Employeedetails()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server = NLTI159\\SQLEXPRESS; Database = Employment; integrated Security = true");
            SqlCommand command = new SqlCommand($"SELECT s.FirstName,s.LastName,s.Department,e.Company,e.Salary\r\nFROM Student s\r\nJOIN Information e\r\nON S.StudentId = e.ID order by e.Salary DESC", con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server = NLTI159\\SQLEXPRESS; Database = Employment; integrated Security = true");
            SqlCommand command = new SqlCommand($"SELECT s.FirstName,s.LastName,s.Department,e.Company,e.Salary,e.designation\r\nFROM Student s\r\nJOIN Information e\r\nON S.StudentId = e.ID Group by e.designation,s.FirstName,s.LastName,s.Department,e.Company,e.Salary", con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


        }
    }
}

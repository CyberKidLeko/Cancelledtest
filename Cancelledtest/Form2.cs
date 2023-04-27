using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cancelledtest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        SqlCommand comm;
        SqlDataAdapter adapter;
        DataSet ds;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nkulu\source\repos\Cancelledtest\Cancelledtest\Data.mdf;Integrated Security = True";
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open();

                string query = "SELECT * FROM Student";
                adapter = new SqlDataAdapter();
                comm = new SqlCommand(query,cnn);
                ds = new DataSet();
                adapter.SelectCommand= comm;
                adapter.Fill(ds, "Student");

                dataGridView1.DataSource= ds ;
                dataGridView1.DataMember = "Student";



                cnn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

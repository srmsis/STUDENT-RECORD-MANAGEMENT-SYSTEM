using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace STUDENT_RECORD_MANAGEMENT_SYSTEM
{
    public partial class Course : Form
    {
        SqlCommand cnn;
        SqlConnection con;
        SqlDataAdapter de;
        public Course()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M8D1ROH\SQLEXPRESS; Initial Catalog=studentdb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into NewTable Values (@Id,@Course,@Credit)", con);
            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Course", (textBox2.Text));
            cnn.Parameters.AddWithValue("@Credit", int.Parse(textBox4.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Added");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M8D1ROH\SQLEXPRESS; Initial Catalog=studentdb;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Select * from NewTable", con);
            SqlDataAdapter de = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            de.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M8D1ROH\SQLEXPRESS; Initial Catalog=studentdb;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Update NewTable Set course=@course,credit=@credit where id=@id", con);
            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Course", (textBox2.Text));
            cnn.Parameters.AddWithValue("@Credit", int.Parse(textBox4.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");
        }
    }
}

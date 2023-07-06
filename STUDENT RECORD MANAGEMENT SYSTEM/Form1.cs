using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace STUDENT_RECORD_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        SqlCommand cnn;
        SqlConnection con;
        SqlDataAdapter de;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M8D1ROH\SQLEXPRESS; Initial Catalog=studentdb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into userinfo Values (@Id,@Name,@Age,@Course,@Date)", con);
            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", (textBox2.Text));
            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@Course", (textBox4.Text));
            cnn.Parameters.AddWithValue("@Date", DateTime.Parse(textBox5.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M8D1ROH\SQLEXPRESS; Initial Catalog=studentdb;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Select * from userinfo", con);
            SqlDataAdapter de = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            de.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M8D1ROH\SQLEXPRESS; Initial Catalog=studentdb;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("Update userinfo Set name=@name,age=@age,course=@course,date=@date where id=@id", con);
            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", (textBox2.Text));
            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@Course", (textBox4.Text));
            cnn.Parameters.AddWithValue("@Date", DateTime.Parse(textBox5.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");
        }
    }
}
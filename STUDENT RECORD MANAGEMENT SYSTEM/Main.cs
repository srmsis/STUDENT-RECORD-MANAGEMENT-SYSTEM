using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_RECORD_MANAGEMENT_SYSTEM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1Info = new Form1();
            Form1Info.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Course CourseInfo = new Course();
            CourseInfo.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}

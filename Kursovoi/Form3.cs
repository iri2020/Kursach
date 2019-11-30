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
using System.IO;

namespace Kursovoi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.textBox2.Visible = true;
            f.textBox3.Visible = true;
            f.label2.Visible = true;
            f.label3.Visible = true;

            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form10 f = new Form10();
            
            f.button5.Visible = false;
            f.button6.Visible = true;

            SqlConnection con = new SqlConnection(Program.podkl);
            con.Open();
            Program.urov = comboBox1.Text.Trim();

            string s = "select * from urovni where uroven = "+Program.urov+"";
            SqlCommand com = new SqlCommand(s, con);
            SqlDataReader read = com.ExecuteReader();
            read.Read();

            f.textBox1.Text = read.GetString(1);
            f.textBox2.Text = read.GetString(7);
            f.textBox3.Text = Convert.ToString( read.GetInt32(8));
            f.textBox4.Text = Convert.ToString( read.GetInt32(6));

            string s1 = read.GetString(2);
            f.pictureBox1.Image = Image.FromFile(s1);
            f.label1.Text = s1;
            string s2 = read.GetString(3);
            f.pictureBox2.Image = Image.FromFile(s2);
            f.label2.Text = s2;
            string s3 = read.GetString(4);
            f.pictureBox3.Image = Image.FromFile(s3);
            f.label3.Text = s3;
            string s4 = read.GetString(5);
            f.pictureBox4.Image = Image.FromFile(s4);
            f.label4.Text = s4;

            f.Show();
            this.Hide();
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igraDataSet.urovni". При необходимости она может быть перемещена или удалена.
            this.urovniTableAdapter.Fill(this.igraDataSet.urovni);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            f.Show();
        }
    }
}

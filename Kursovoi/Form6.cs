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

namespace Kursovoi
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.podkl);
            con.Open();
            string s = "select urovni.uroven, slovo,ris1,ris2,ris3,ris4,ball,podskazka,BalPodskazka,kolvoBall " +
                "from urovni inner join users on urovni.uroven=users.uroven where id_user=" + Program.id_user;

            SqlCommand com = new SqlCommand(s, con);
            SqlDataReader read = com.ExecuteReader();
            read.Read();
            Form5 f = new Form5();

            string s1 = read.GetString(2);
            f.pictureBox1.Image = Image.FromFile(s1);
            string s2 = read.GetString(3);
            f.pictureBox2.Image = Image.FromFile(s2);
            string s3 = read.GetString(4);
            f.pictureBox3.Image = Image.FromFile(s3);
            string s4 = read.GetString(5);
            f.pictureBox4.Image = Image.FromFile(s4);
            f.label1.Text = read.GetInt32(6) + " баллов за уровень.";
            f.label2.Text = "Ваши баллы: " + read.GetInt32(9);
            f.textBox2.Text = read.GetString(7);
            f.label3.Text = "Стоимость подсказки: " + read.GetInt32(8);
            f.label4.Text = Convert.ToString(read.GetInt32(0));

            f.Show();
            con.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.podkl);
            con.Open();

            string s = "select * from users where id_user =" + Program.id_user;
            SqlCommand com = new SqlCommand(s, con);
            SqlDataReader read = com.ExecuteReader();
            read.Read();
            Form2 f = new Form2();

            f.label1.Text = "добро пожаловать " + read.GetString(3) + "";

            f.Show();
            this.Close();
        }
    }
}

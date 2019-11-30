using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Kursovoi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(Program.podkl);
            con.Open();
            string s = "select ball,BalPodskazka,kolvoBall from urovni inner join users on urovni.uroven=users.uroven where id_user= " + Program.id_user;
            SqlCommand com = new SqlCommand(s, con);
            SqlDataReader read = com.ExecuteReader();
            read.Read();
            int bp = read.GetInt32(1);
            int b = read.GetInt32(2);

            if (b >= bp)
            {
                int bal = b - bp;
                read.Close();
                pictureBox5.Visible = false;
                string s1 = "update users set kolvoBall = " + bal + " where id_user = " + Program.id_user;
                SqlCommand comm = new SqlCommand(s1, con);
                comm.ExecuteScalar();


                label2.Text = "Ваши баллы :" + bal;
                con.Close();
            }
            else
            {
                MessageBox.Show("У вас недостаточно баллов!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.podkl);
            con.Open();
            Form6 f6 = new Form6();
            string s = "select * from urovni where uroven =" + label4.Text;

            SqlCommand com = new SqlCommand(s, con);
            SqlDataReader read= com.ExecuteReader();
            if (read.HasRows)
            {
                read.Read();
                string ss = read.GetString(1).Trim();
                int b = read.GetInt32(6);
                read.Close();
                if (textBox1.Text.Trim() == ss)
                {


                    string s2 = "update users set kolvoBall = kolvoBall+ " + b + ", uroven= uroven+1 where id_user = " + Program.id_user;
                    SqlCommand comm = new SqlCommand(s2, con);
                    comm.ExecuteScalar();

                    string s1 = "select * from reiting where id_user = " + Program.id_user;
                    SqlCommand com1 = new SqlCommand(s1, con);
                    SqlDataReader read1 = com1.ExecuteReader();

                    if (read1.HasRows)
                    {

                    }
                    else
                    {
                        read1.Close();

                        string s6 = "insert into reiting (mesto, id_user,nic,ball,uroven)" +
                        "(select DENSE_RANK() OVER(ORDER BY kolvoBall DESC) as mesto," +
                        " id_user, nickname, kolvoBall, uroven from users where type = 1 and id_user= " + Program.id_user + ")";
                        SqlCommand com6 = new SqlCommand(s6, con);
                        com6.ExecuteScalar();
                    }

                    f6.Show();
                    this.Close();
                }
                else
                {
                    pictureBox6.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("К сожалению уровни закончились =(");
            }
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Visible == false)
            {
                DialogResult result = MessageBox.Show("Вы уже потратили свои баллы на подсказку, точно выйти?(Потраченные балы не вернутся.) ", "Выход в меню",MessageBoxButtons.OKCancel );
                if (result == DialogResult.OK)
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
            else
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
        }
    }
}

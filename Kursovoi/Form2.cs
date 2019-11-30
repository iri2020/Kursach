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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            SqlConnection con = new SqlConnection(Program.podkl);
            con.Open();

            string s = "select * from users where id_user=" + Program.id_user.ToString() ;
            SqlCommand com = new SqlCommand(s, con);
            SqlDataReader read = com.ExecuteReader();

            
            read.Read();
            
            Form4 f = new Form4();

            f.textBox1.Text = read.GetString(1).Trim();
            f.textBox4.Text = read.GetString(3).Trim();
            f.textBox5.Text =  read.GetString(5).Trim();
            f.dateTimePicker1.Value = read.GetDateTime(4);
            f.button3.Visible = true;
            f.textBox6.Visible = true;
            f.label7.Visible = true;
            f.button1.Visible = false;
            f.button2.Visible = true;
            f.Show();
            this.Hide();
            
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
            f.label2.Text = "Ваши баллы: "+read.GetInt32(9);
            f.textBox2.Text = read.GetString(7);
            f.label3.Text = "Стоимость подсказки: "+read.GetInt32(8);
            f.label4.Text =Convert.ToString( read.GetInt32(0)) ;

            f.Show();
            con.Close();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("Вы уверены? Весь ваш прогресс и заработанные баллы будут обнулены ", "Сброс прогресса", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form8 f = new Form8();
                f.Show();
               
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            SqlConnection con = new SqlConnection(Program.podkl);
            con.Open();
            string ss = "select * from reiting where id_user = "+ Program.id_user;
            SqlCommand com = new SqlCommand(ss, con);
            SqlDataReader read = com.ExecuteReader();
            read.Read();
            
            if (read.HasRows)
            {

                read.Close();
                string s0 = "select count(*) from reiting " ;
                SqlCommand com0 = new SqlCommand(s0, con);
                SqlDataReader read0 = com0.ExecuteReader();
                read0.Read();
                int b = read0.GetInt32(0);
                read0.Close();
                for (int i=1; i<=b; i++)
                {
                    string s00 = "WITH MyTable AS(" +
                        " SELECT ROW_NUMBER() OVER(ORDER BY ball DESC) AS Row, *" +
                        " FROM reiting)" +
                        "SELECT Row, id_user,nic,ball,uroven " +
                        "FROM MyTable WHERE Row="+i;
                    SqlCommand com00 = new SqlCommand(s00, con);
                    SqlDataReader read00 = com00.ExecuteReader();
                    read00.Read();
                    int id = read00.GetInt32(1);
                    read00.Close();
                    string s2 = "update reiting set nic=(select nickname from users where id_user="+id+")," +
                        "ball =(select kolvoBall from users where id_user="+id+")," +
                        "uroven = (Select uroven from users where id_user="+id+")," +
                        "mesto = (select mesto from(select DENSE_RANK() OVER(ORDER BY kolvoBall DESC) as mesto, id_user from users )as reiting where id_user ="+id+")" +
                        " where id_user="+id;
                    SqlCommand comm = new SqlCommand(s2, con);
                    
                    comm.ExecuteScalar();
                }
            }
            else
            {
                f.label1.Text = "рейтинг";
            }


            

            con.Close();
            
            f.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()==""||
                textBox2.Text.Trim() == "" ||
                textBox3.Text.Trim() == "" ||
                textBox4.Text.Trim() == "" ||
                textBox5.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                SqlConnection con = new SqlConnection(Program.podkl);
                con.Open();

                string s = "select * from users where login='" + textBox1.Text.Trim() + "'";
                SqlCommand com = new SqlCommand(s, con);
                SqlDataReader read = com.ExecuteReader();
                if (read.HasRows)
                {
                    MessageBox.Show("Такой логин уже существует");
                }
                else
                {
                    if(textBox2.Text.Trim()!= textBox3.Text.Trim())
                    {
                        MessageBox.Show("Пароли не совпадают");
                    }
                    else
                    {
                        read.Close();
                        string s1 = "insert into users (login, pass, nickname, data_roj, email, type, kolvoBall,uroven) values(" +
                            "'" + textBox1.Text.Trim() + "'," +
                            "'" + textBox2.Text.Trim() + "'," +
                            "'" + textBox4.Text.Trim() + "'," +
                            "'" + dateTimePicker1.Value + "'," +
                            "'" + textBox5.Text.Trim() + "',1, 0,1)";
                        
                        SqlCommand com1 = new SqlCommand(s1, con);
                        com1.ExecuteScalar();
                        this.Close();
                    }
                }
                
                con.Close();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Visible == false)
            {
                SqlConnection con = new SqlConnection(Program.podkl);
                con.Open();

                string ss = "select * from users where id_user=" + Program.id_user;
                SqlCommand com = new SqlCommand(ss, con);
                SqlDataReader read = com.ExecuteReader();
                read.Read();
                string pas = read.GetString(2).Trim();

                if (pas != textBox6.Text.Trim())
                {
                    MessageBox.Show("Пароль неверный!");
                }
                else
                {

                   // 

                    string s = "update users set " +
                   "login= '" + textBox1.Text.Trim() + "'," +
                   " nickname='" + textBox4.Text.Trim() + "'," +
                   " data_roj='" + dateTimePicker1.Value + "'," +
                   "email='" + textBox5.Text.Trim() + "'" +
                   " where id_user=" + Program.id_user.ToString();

                    read.Close();
                    SqlCommand comm = new SqlCommand(s, con);
                    comm.ExecuteScalar();
                    Form2 f = new Form2();

                    
                    f.label1.Text = "Добро пожаловать " + textBox4.Text.Trim();
                    f.Show();
                    this.Close();
                }

                con.Close();
                
            }
            else
            {
                SqlConnection connect = new SqlConnection(Program.podkl);
                connect.Open();

                string s = "select * from users where id_user=" + Program.id_user;
                SqlCommand comm = new SqlCommand(s, connect);
                SqlDataReader read = comm.ExecuteReader();
                read.Read();

                string pas = read.GetString(2).Trim();

                if (pas != textBox6.Text.Trim())
                {
                    MessageBox.Show("Текущий пароль неверный!");
                }
                else
                {
                    if (textBox2.Text.Trim() != textBox3.Text.Trim())
                    {
                        MessageBox.Show("Пароли не совпадают!");
                    }
                    else
                    {
                        read.Close();

                        string sss = "update users set pass = '" + textBox2.Text.Trim() + "' where id_user =" + Program.id_user.ToString();
                        SqlCommand comm2 = new SqlCommand(sss, connect);
                        comm2.ExecuteScalar();
                        MessageBox.Show("Пароль изменён!");
                        Form2 ff = new Form2();
                        ff.label1.Text = "Добро пожаловать " + textBox4.Text.Trim();
                        ff.Show();
                        this.Close();

                    }
                }

                connect.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox3.Visible = true;
            textBox1.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            dateTimePicker1.Enabled = false;
            
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form2 f = new Form2();
            //f.Show();
            //f.label1.Text = "Добро пожаловать " + textBox4.Text.Trim();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text.Trim();
            string pass = textBox2.Text.Trim();
            if (log == "" || pass == "")
            {
                MessageBox.Show("Введите данные!");
            }
            else
            {
                SqlConnection con = new SqlConnection(Program.podkl);
                con.Open();

                string s = "select * from users where login = '" + log + "' and pass ='" + pass + "'";
                SqlCommand com = new SqlCommand(s, con);
                SqlDataReader read = com.ExecuteReader();

                if (read.HasRows)
                {
                    read.Read();
                    Program.id_user = read.GetInt32(0);
                    Program.type_user = read.GetBoolean(8);
                    if (Program.type_user == true)
                    {
                        Form2 f = new Form2();

                        f.label1.Text = "добро пожаловать " + read.GetString(3) + "";

                        f.Show();
                        
                        
                    }
                    else
                    {
                        Form3 f = new Form3();

                        f.Show();
                        
                        

                    }
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }

                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.textBox2.Visible = true;
            f.textBox3.Visible = true;
            f.label2.Visible = true;
            f.label3.Visible = true;

            f.Show();
        }
    }
}

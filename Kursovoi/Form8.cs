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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.podkl);
            con.Open();

            string s = "select * from users where id_user =" + Program.id_user;
            SqlCommand com = new SqlCommand(s, con);
            SqlDataReader read = com.ExecuteReader();
            read.Read();
            string ss = read.GetString(2).Trim();
            if (textBox1.Text.Trim() == ss)
            {
                SqlConnection con1 = new SqlConnection(Program.podkl);
                con1.Open();

                string s1 = "update users set kolvoBall=0, uroven=1 where id_user= " + Program.id_user;
                string s3 = "update reiting set  mesto= (select mesto from (select DENSE_RANK() OVER(ORDER BY kolvoBall DESC) " +
                        "as mesto, id_user from users )as reiting where id_user = " + Program.id_user + "), " +
                        "ball = 0, uroven= 1 where id_user = " + Program.id_user;
                SqlCommand commt = new SqlCommand(s3, con);
                read.Close();
                commt.ExecuteScalar();
                SqlCommand com1 = new SqlCommand(s1, con1);
                SqlDataReader read1 = com1.ExecuteReader();
                read1.Read();
                MessageBox.Show("Ваш прогресс обнулен!");
                
                con1.Close();
                this.Close();

            }
            else
            {
                MessageBox.Show("Пароль неверный!");
                this.Close();
            }
            con.Close();
        }
    }
}

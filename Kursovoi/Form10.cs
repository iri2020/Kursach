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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = Path.GetFileName(openFileDialog1.FileName);
                File.Copy(openFileDialog1.FileName, AppDomain.CurrentDomain.BaseDirectory + label1.Text,true);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.Text = Path.GetFileName(openFileDialog1.FileName);
                File.Copy(openFileDialog1.FileName, AppDomain.CurrentDomain.BaseDirectory + label2.Text, true);
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label3.Text = Path.GetFileName(openFileDialog1.FileName);
                File.Copy(openFileDialog1.FileName, AppDomain.CurrentDomain.BaseDirectory + label3.Text, true);
                pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label4.Text = Path.GetFileName(openFileDialog1.FileName);
                File.Copy(openFileDialog1.FileName, AppDomain.CurrentDomain.BaseDirectory + label4.Text, true);
                pictureBox4.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" ||
               textBox2.Text.Trim() == "" ||
               textBox3.Text.Trim() == "" ||
               textBox4.Text.Trim() == "" ||
               label1.Text.Trim()== "•Картинка 1" ||
               label2.Text.Trim() == "•Картинка 2" ||
               label3.Text.Trim() == "•Картинка 3" ||
               label4.Text.Trim() == "•Картинка 4")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                SqlConnection con = new SqlConnection(Program.podkl);
                con.Open();

                string s = "select * from urovni where slovo ='"+textBox1.Text.Trim()+"'";
                SqlCommand com = new SqlCommand(s, con);
                SqlDataReader read = com.ExecuteReader();
                if (read.HasRows)
                {
                    MessageBox.Show("Такой уровень уже существует");
                }
                else
                {
                    if (label1.Text.Trim()==label2.Text.Trim() ||
                        label1.Text.Trim() == label3.Text.Trim() ||
                        label1.Text.Trim() == label4.Text.Trim() ||
                        label4.Text.Trim() == label3.Text.Trim() ||
                        label4.Text.Trim() == label2.Text.Trim() ||
                        label2.Text.Trim() == label3.Text.Trim())
                    {
                        MessageBox.Show("Есть одинаковые картинки!");
                    }
                    else
                    {
                        read.Close();
                        string s1 = "insert into urovni values " +
                            "('"+textBox1.Text.Trim()+"'," +
                            "'"+label1.Text.Trim()+"'," +
                            "'"+label2.Text.Trim()+"'," +
                            "'"+label3.Text.Trim()+"'," +
                            "'"+label4.Text.Trim()+"'," +
                            ""+textBox4.Text.Trim()+"," +
                            "'"+textBox2.Text.Trim()+"'," +
                            ""+textBox3.Text.Trim()+")";
                        SqlCommand com1 = new SqlCommand(s1, con);
                        com1.ExecuteScalar();
                        this.Close();
                    }
                }
                Form3 ff = new Form3();
                ff.Show();
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.podkl);
            conn.Open();
            string s = "update urovni set " +
                "slovo='" + textBox1.Text.Trim() + "'," +
                "ris1='" + label1.Text.Trim() + "'," +
                "ris2='" + label2.Text.Trim() + "'," +
                "ris3='" + label3.Text.Trim() + "'," +
                "ris4='" + label4.Text.Trim() + "'," +
                "ball=" + textBox4.Text.Trim() + "," +
                "podskazka='" + textBox2.Text.Trim() + "'," +
                "BalPodskazka=" + textBox3.Text.Trim() + " where uroven = "+Program.urov+"";

            SqlCommand comm = new SqlCommand(s, conn);
            comm.ExecuteScalar();
            conn.Close();
            //Form3 ff = new Form3();
            //ff.Show();
            this.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}


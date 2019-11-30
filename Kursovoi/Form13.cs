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
    public partial class Form13 : Form
    {
        int n = 0;
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = n + 10;
            button3.Enabled = true;

            SqlConnection conn = new SqlConnection(Program.podkl);
            conn.Open();

            string s = "select * from reiting order by mesto offset " + n.ToString() + "" +
                "rows fetch next 10 rows only";
            SqlDataAdapter adap = new SqlDataAdapter(s, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count >= 10)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
            conn.Close();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igraDataSet4.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.igraDataSet4.users);
            SqlConnection conn = new SqlConnection(Program.podkl);
            conn.Open();

            string s = "select * from users order by id_user offset " + n.ToString() + "" +
                "rows fetch next 10 rows only";
            SqlDataAdapter adap = new SqlDataAdapter(s, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count >= 10)
            {
                button2.Enabled = true;

            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.Rows.Count > 1)
            {
                SqlConnection con = new SqlConnection(Program.podkl);
                con.Open();
                int k = dataGridView1.CurrentRow.Index;
                Program.id_user = Convert.ToInt32(dataGridView1[0, k].Value);

                string s = "delete from users where id_user= " + Program.id_user;
                SqlCommand comm = new SqlCommand(s, con);
                MessageBox.Show("Пользователь удален!");
                dataGridView1.Rows.RemoveAt(k);
                dataGridView1.Refresh();
                comm.ExecuteScalar();
                con.Close();
            }
            else
            {
                MessageBox.Show("НЕчего удалять!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = n - 10;
            button2.Enabled = true;

            SqlConnection conn = new SqlConnection(Program.podkl);
            conn.Open();

            string s = "select * from users order by id_user offset " + n.ToString() + "" +
                "rows fetch next 10 rows only";
            SqlDataAdapter adap = new SqlDataAdapter(s, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count >= 10)
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
            conn.Close();
        }
    }
}

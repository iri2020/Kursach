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
    public partial class Form9 : Form
    {
        int n = 0;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igraDataSet13.reiting". При необходимости она может быть перемещена или удалена.
            this.reitingTableAdapter7.Fill(this.igraDataSet13.reiting);
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
                button1.Enabled = true;
            }
            
            string ss = "select * from reiting where id_user = " + Program.id_user;
            SqlCommand com = new SqlCommand(ss, conn);
            SqlDataReader read = com.ExecuteReader();
            read.Read();
            if (read.HasRows)
            {
                label1.Text = "Вы находитесь на " + read.GetInt32(1) + " месте в рейтинге";
            }
            else
            {
                label1.Text = "рейтинг";
            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index +1).ToString();
            object header = this.dataGridView1.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridView1.Rows[index].HeaderCell.Value = indexStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            n = n + 10;
            button2.Enabled = true;

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
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = n - 10;
            if (n <= 0)
            {
                button2.Enabled = false;
            }
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
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            conn.Close();
        }
    }
}

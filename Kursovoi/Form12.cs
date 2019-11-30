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
using Microsoft.Office.Interop.Excel;


namespace Kursovoi
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.podkl);
            con.Open();
            if (radioButton1.Checked)
            {
                int id = Convert.ToInt32(comboBox1.SelectedValue);
                string s = "select nickname, data_roj, email,  users.uroven " +
                    "from users  where kolvoBall =" + id;
                SqlDataAdapter adap = new SqlDataAdapter(s, con);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton2.Checked)
            {
                int id = Convert.ToInt32(comboBox2.SelectedValue);
                string s = "select nickname, data_roj, email, kolvoBall, users.uroven " +
                    "from users inner join reiting on users.id_user=reiting.id_user where mesto=" + id;
                SqlDataAdapter adap = new SqlDataAdapter(s, con);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            con.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igraDataSet23.reiting". При необходимости она может быть перемещена или удалена.
            this.reitingTableAdapter4.Fill(this.igraDataSet23.reiting);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igraDataSet211.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter2.Fill(this.igraDataSet211.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igraDataSet211.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter2.Fill(this.igraDataSet211.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igraDataSet21.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter2.Fill(this.igraDataSet21.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igraDataSet20.users". При необходимости она может быть перемещена или удалена.
            
           
}
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            comboBox1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            comboBox1.Visible = false;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter2.Fill(this.igraDataSet21.users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application myExcel =
            new Microsoft.Office.Interop.Excel.Application();

            myExcel.Application.Workbooks.Add(Type.Missing);
            //Настраиваем ячейки
            myExcel.Columns.ColumnWidth = 15;
            //Пишем заголовки ячеек
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                myExcel.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    myExcel.Cells[j + 2, i + 1] = (dataGridView1[i, j].Value).ToString();
                }
            }

            myExcel.Visible = true;
        }
    }
}

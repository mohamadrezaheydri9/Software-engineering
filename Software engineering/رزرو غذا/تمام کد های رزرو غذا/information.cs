using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class information : Form
    {
        public information()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void information_Load(object sender, EventArgs e)
        {
            string username = Properties.Settings.Default.userlog;
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=singup.accdb";
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.CommandText = "select * from [singup] where [uname]=?";
            com.Parameters.AddWithValue("@uname", username);
            com.Connection = con;
            OleDbDataReader reader = com.ExecuteReader();
            if (reader.Read()) 
            {
                textBox1.Text = reader["fname"].ToString();
                textBox2.Text = reader["lname"].ToString();
                textBox3.Text = reader["number"].ToString();
                textBox4.Text = reader["uname"].ToString();
                textBox5.Text = reader["password"].ToString();

            }
            else
            {
                MessageBox.Show("مشکلی پیش آمده لطفا با پشتیبانی تماس بگیرید");
                Main main = new Main();
                this.Hide();
                main.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("لطفا نام خود را وارد کنید");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی خود را وارد کنید");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("لطفا شماره تماس خود را وارد کنید");

            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("لطفا شماره تماس خود را وارد کنید");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("لطفا پسوورد خود را وارد کنید");
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=singup.accdb";
                con.Open();
                OleDbCommand com = new OleDbCommand();
                com.CommandText = "update [singup] set [fname]=?,[lname]=?,[number]=?,[uname]=?,[password]=?";
                com.Parameters.AddWithValue("@fname", textBox1.Text);
                com.Parameters.AddWithValue("@lname", textBox2.Text);
                com.Parameters.AddWithValue("@number", textBox3.Text);
                com.Parameters.AddWithValue("@uname", textBox4.Text);
                com.Parameters.AddWithValue("@password", textBox5.Text);
                com.Connection = con;
                int count = (int)com.ExecuteNonQuery();
                if (count > 0)
                {
                 con.Close();
                    MessageBox.Show("تغییرات اعمال شد");
                }
                else
                {
                    MessageBox.Show("متاسفانه مشکلی پیش آمده لطفا بعدا مجدد تلاش کنید");
                }
            }
        }

        private void حذفحسابکاربریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result=MessageBox.Show("این عمل باعث حذف حساب کاربری میشود", "اخطار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string username = Properties.Settings.Default.userlog;
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=singup.accdb";
                con.Open();
                OleDbCommand com = new OleDbCommand();
                com.CommandText = "delete from [singup] where [uname]=?";
                com.Parameters.AddWithValue("@uname", username);
                com.Connection= con;
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("کابر با موفیقت حذف شد");
                Properties.Settings.Default.userlog = null;
                Properties.Settings.Default.Save();
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();

            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            singup singup = new singup();
            this.Hide();
            singup.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=singup.accdb";
                con.Open();
                OleDbCommand com = new OleDbCommand();
                com.CommandText = "select count(*) from [singup] where [uname]=? and [password]=? ";
                com.Parameters.AddWithValue("@uname", textBox1.Text);
                com.Parameters.AddWithValue("@password", textBox2.Text);
                com.Connection = con;
                int count = (int)com.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("ورود موفیقت آمیز بود");
                    con.Close();
                    Properties.Settings.Default.userlog= textBox1.Text;
                    Properties.Settings.Default.Save();
                    Main main = new Main();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("کاربر وجود ندارد");
                    con.Close();
                }
                
            }
            else
            {
                MessageBox.Show("پر کردن فیلد ها اجباری است");
                
            }
        }
    }
}

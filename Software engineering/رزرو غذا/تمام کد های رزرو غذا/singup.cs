using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class singup : Form
    {
        public singup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void singup_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
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
                MessageBox.Show("لطفا نام کاربری خود را وارد کنید");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("لطفا پسوورد خود را وارد کنید");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("لطفا تکرار پسوورد را وارد کنید");
            }
            else if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("پسوورد همخوانی ندارد");
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=singup.accdb";
                con.Open();
                OleDbCommand com = new OleDbCommand();
                

                com.CommandText = "insert into [singup]([fname],[lname],[number],[uname],[password]) values(?,?,?,?,?)";
                    com.Parameters.AddWithValue("@fname",textBox1.Text);
                    com.Parameters.AddWithValue("@lname",textBox2.Text);
                    com.Parameters.AddWithValue("@number",textBox3.Text);
                    com.Parameters.AddWithValue("@uname",textBox4.Text);
                    com.Parameters.AddWithValue("@password",textBox6.Text);
                    com.Connection = con;
                    int count = (int)com.ExecuteNonQuery();
                    if (count > 0)
                    {
                        con.Close();

                        MessageBox.Show("ثبت نام موفیقت آمیز بود");
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.Show();

                        //OleDbConnection conn = new OleDbConnection();
                        //conn.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=reservfood.accdb";
                        //conn.Open();
                        //OleDbCommand comm = new OleDbCommand();
                        //comm.CommandText = "insert into [reserv] ([uname]) values(?)";
                        //comm.Parameters.AddWithValue("@uname", textBox4.Text);
                        //comm.Connection = conn;
                        //comm.ExecuteNonQuery();
                        //conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("متاسفانه مشکلی پیش آمده مجدد تلاش کنید");
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.Show();
                    }
                    
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

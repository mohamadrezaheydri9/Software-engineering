using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public string shnahar {  get; set; }
        public string shsham {  get; set; }
        public string yeknahar {  get; set; }
        public string yeksham {  get; set; }
        public string donahar {  get; set; }
        public string dosham {  get; set; }
        public string senahar {  get; set; }
        public string sesham {  get; set; }
        public string charnahar {  get; set; }
        public string charsham {  get; set; }
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                shnahar = "زرشک پلو با مرغ";
            }
            else
            {
                shnahar = "رزرو نشده";
            }
            if (checkBox2.Checked)
            {
                shsham = "شنسیل مرغ";
            }
            else
            {
                shsham = "رزرو نشده";
            }
            if (checkBox3.Checked)
            {
                yeknahar = "قرمه سبزی";
            }
            else
            {
                yeknahar = "رزرو نشده";
            }
            if (checkBox7.Checked)
            {
                yeksham = "ماکارانی";
            }
            else
            {
                yeksham = "رزرو نشده";
            }
            if (checkBox4.Checked)
            {
                donahar = "قیمه";
            }
            else
            {
                donahar = "رزرو نشده";
            }
            if (checkBox8.Checked)
            {
                dosham = "کتلت";
            }
            else
            {
                dosham = "رزرو نشده";
            }
            if (checkBox5.Checked)
            {
                senahar = "لوبیاپلو";
            }
            else
            {
                senahar = "رزرو نشده";
            }
            if (checkBox9.Checked)
            {
                sesham = "کوبیده";
            }
            else
            {
                sesham = "رزرو نشده";
            }
            if (checkBox6.Checked)
            {
                charnahar = "تن ماهی";
            }
            else
            {
                charnahar = "رزرو نشده";
            }
            if (checkBox10.Checked)
            {
                charsham = "لوبیا";
            }
            else
            {
                charsham = "رزرو نشده";
            }

            string username = Properties.Settings.Default.userlog;
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=reservfood.accdb";
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.CommandText = "insert into reserv(shnahar,shsham,yeknahar,yeksham,donahar,dosham,senahar,sesham,charnahar,charsham,uname) values (?,?,?,?,?,?,?,?,?,?,?)";
            //com.CommandText = "UPDATE [reserv] SET ([shanhar],[shsham],[yeknahar],[yeksham],[donahar],[dosham],[senahar],[sesham],[charnahar],[charsham]) VALUSE (?,?,?,?,?,?,?,?,?,?) WHERE [uname] = ?";
            com.Parameters.AddWithValue("@shnahar", shnahar);
            com.Parameters.AddWithValue("@shsham", shsham);
            com.Parameters.AddWithValue("@yeknahar", yeknahar);
            com.Parameters.AddWithValue("@yeksham", yeksham);
            com.Parameters.AddWithValue("@donahar", donahar);
            com.Parameters.AddWithValue("@dosham", dosham);
            com.Parameters.AddWithValue("@senahar", senahar);
            com.Parameters.AddWithValue("@sesham", sesham);
            com.Parameters.AddWithValue("@charnahar", charnahar);
            com.Parameters.AddWithValue("@charsham", charsham);
            com.Parameters.AddWithValue("@uname", username);
            com.Connection = con;
            int count = (int)com.ExecuteNonQuery();
            if (count == 1)
            {
                con.Close();
                MessageBox.Show("رزرو انجام شد");

            }
            else
            {
                MessageBox.Show("مشکلی رخ داده با پشتیبانی تماس بگیرید");
            }


            //string username = Properties.Settings.Default.userlog;
            //    using (OleDbConnection con = new OleDbConnection())
            //    {
            //        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=reservfood.accdb";
            //        con.Open();

            //        using (OleDbCommand com = new OleDbCommand())
            //        {
            //            com.Connection = con;

            //            // ساخت دستور INSERT
            //            com.CommandText = "INSERT INTO reserv ([shanhar], [yeknahar], [yeksham], [donahar], [dosham], [senahar], [sesham], [charnahar], [charsham], [luname]) " +
            //                              "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            //            // مقداردهی به پارامترها
            //            com.Parameters.AddWithValue("@eshanhar", checkBox1.Checked);
            //            com.Parameters.AddWithValue("@yeknahar", checkBox2.Checked);
            //            com.Parameters.AddWithValue("@yeksham", checkBox3.Checked);
            //            com.Parameters.AddWithValue("@donahar", checkBox4.Checked);
            //            com.Parameters.AddWithValue("@dosham", checkBox5.Checked);
            //            com.Parameters.AddWithValue("@senahar", checkBox6.Checked);
            //            com.Parameters.AddWithValue("@sesham", checkBox7.Checked);
            //            com.Parameters.AddWithValue("@charnahar", checkBox8.Checked);
            //            com.Parameters.AddWithValue("@charsham", checkBox9.Checked);
            //            com.Parameters.AddWithValue("@luname", username);

            //            // اجرای دستور
            //            int count = com.ExecuteNonQuery();
            //            if (count == 1)
            //            {
            //                MessageBox.Show("داده‌ها با موفقیت ذخیره شد.");
            //            }
            //        }
            //    }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            list list = new list();
            this.Hide();    
            list.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            information information = new information();
            this.Hide();
            information.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
        }

        private void list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reservfoodDataSet.reserv' table. You can move, or remove it, as needed.
            this.reservTableAdapter.Fill(this.reservfoodDataSet.reserv);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main=new Main();
            this.Hide();
            main.Show();
        }
    }
}

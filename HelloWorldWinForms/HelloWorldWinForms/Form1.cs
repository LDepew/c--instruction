﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            lbl_hellomessage.Text = "Nice to meet you.";
        }

        private void btn_changecolor_Click(object sender, EventArgs e)
        {
            lbl_hellomessage.ForeColor = Color.Red;
        }
    }
}

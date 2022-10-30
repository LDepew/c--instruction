using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroLiz
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime alarmTime = DateTime.Parse(checkedListBox1.Text);

            if (currentTime.Hour == alarmTime.Hour && currentTime.Minute == alarmTime.Minute && currentTime.Second == alarmTime.Second)
            {
                timer.Stop();
                MessageBox.Show("Ring, Ring!", checkedListBox1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app made by me for Liz!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addData();
            //add timer here?
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems.OfType<string>().ToList())
            {
                checkedListBox1.Items.Remove(item);
                checkBox1.Checked = false;
                
                /*if (checkedListBox1.SelectedIndex != -1)
                {
                    for (int i = checkedListBox1.CheckedItems.Count - 1; i >= 0; i--)
                        //checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[i]);
                    checkedListBox1.SelectedItems.Remove(checkedListBox1.CheckedItems[i]);
                }*/
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                addData();
            }
        }

        private void addData()
        {
            //dateTimePicker1.Format = DateTimePickerFormat.Custom; 
            //dateTimePicker1.CustomFormat = "hh:mm:ss dddd MMMM dd, yyyy";
            string data1 = textBox1.Text;
            string data2 = dateTimePicker1.Text;

            string datat3 = (data1 + " | " + data2);

            checkedListBox1.Items.Add(datat3);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkBox1.Checked == true)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
                else
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }
    }
}

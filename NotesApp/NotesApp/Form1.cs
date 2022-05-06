using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This note app created by me");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Insert(0, textBox1.Text);
            checkedListBox1.Items.Insert(0, DateTime.Now.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }
    }

    public class MyNote
    {
        public string Note { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", Note, Date);
        }
    }
}

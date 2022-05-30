using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fee_Invoice__
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Invoice form = new Invoice();
            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Pub b = new Pub();
            b.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pub b = new Pub();
            b.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        } 

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();

        }
    }
}

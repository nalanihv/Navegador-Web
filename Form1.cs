using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonIr_Click(object sender, EventArgs e)
        {
            //webBrowser1.Navigate(new Uri(comboBox1.SelectedItem.ToString()));
            webBrowser1.Navigate(new Uri(comboBox1.SelectedItem.ToString()));
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome ();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward ();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack ();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            comboBox1 .SelectedIndex = 0;
            webBrowser1.GoHome();

        }
    }
}

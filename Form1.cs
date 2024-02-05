using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonIr_Click(object sender, EventArgs e)
        {
            string url = comboBox1.Text.ToString();
            if (!(url.Contains("http")))
            {
                url = "http://" + url;
            }
            //webBrowser1.Navigate(new Uri(comboBox1.SelectedItem.ToString())); 
            webBrowser1.Navigate(new Uri(url));
            if ((url.Contains(".")))
            {
                url = "http://www.google.com";
            }
            webBrowser1.Navigate(new Uri(url));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void homeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void goForwardToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void goBackToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            webBrowser1.GoHome();
        }
    }
}

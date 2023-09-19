using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwms
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
            this.webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uri address = new Uri(textBox1.Text);
            webBrowser1.Url = address;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBox1.Text != "")
                {
                    button1_Click(sender, e);
                }
            }
        }
    }
}

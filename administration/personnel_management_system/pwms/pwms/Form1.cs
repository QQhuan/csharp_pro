using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pwms.ModuleClass;

namespace pwms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar  = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 登录操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            if(username == "" || password == "")
            {
                MessageBox.Show("账号密码均不能为空！");
                return;
            }
            // 直接调用公共类里的登录方法
            bool isExist = MyModule.Instance.Login(username, password);
            if(isExist)
            {
                // 验证通过，暂时跳转主页面
                Form_mainUI mainUI = new Form_mainUI();
                mainUI.ShowDialog();
                this.Hide();
                this.Close();
            }
        }

        private void router()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 注册操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.ShowDialog();
            webBrowser.Dispose(); // 占用大量资源，必须释放
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                textBox2.Focus();
            }
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                // 按下了Tab键
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1_Click(sender, e);
            }
        }
    }
}

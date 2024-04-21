using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int mimic = 0;
        string txts;

        private void Clear()
        {
            txtTK.Clear();
            txtMK.Clear();
            txtTK.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Welcome Line Section
            txts = lbWelcome.Text;
            mimic = txts.Length;
            lbWelcome.Text = "";
            lbWelcome.Visible = false;

            //Login section
            ShowPassWord.Visible = false;
            txtTK.Focus();
        }

        private void ClosePassWord_Click(object sender, EventArgs e)
        {
            ShowPassWord.Visible = true;
            ClosePassWord.Visible = false;
            txtMK.PasswordChar = '\0';
        }

        private void ShowPassWord_Click(object sender, EventArgs e)
        {
            ShowPassWord.Visible=false;
            ClosePassWord.Visible = true;
            txtMK.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTK.Text == "loe712" && txtMK.Text == "baohoang712")
            {
                LoginPanel.Visible = false;
                timerLogo.Start();

            } else
            {
                MessageBox.Show(
                    "Sai du tk hoac mk!",
                    "Canh bao!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                Clear();
            }
        }

        private void timerLogo_Tick(object sender, EventArgs e)
        {

            LogoPic.Left += 12;
            Slogan.Left += 12;

            if (LogoPic.Left >= 190 && Slogan.Left >= 290)
            {
                timerLogo.Stop();
                lbWelcome.Visible = true;
                timerWelcomeLine.Start();
            }
        }

        private void timerWelcomeLine_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter > mimic)
            {
                counter = 0;
                lbWelcome.Text = "";
            }
            else
            {
                lbWelcome.Text = txts.Substring(0, counter);
                if(lbWelcome.Text == txts)
                {
                    timerWelcomeLine.Stop();
                    FrmMenu menu = new FrmMenu();
                    menu.Show();
                }
            }

        }

        private void lbWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}

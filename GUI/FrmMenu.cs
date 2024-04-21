using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace GUI
{
    public partial class FrmMenu : Form
    {
        FrmMenuSP menuSP = new FrmMenuSP();

        public FrmMenu()
        {
            InitializeComponent();
        }
        bool menuExpand = false;

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnHam_Click_1(object sender, EventArgs e)
        {
            if (menuExpand == true)
            {
                menuTransition.Start();
            }
            sidebarTransition.Start();
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 490)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 76)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnsanPham_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();

            menuSP.TopLevel = false;
            panelMenu.Controls.Add(menuSP);
            menuSP.Size = panelMenu.Size;
            menuSP.Dock = DockStyle.Fill;
            menuSP.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sideBarExpand == false && menuExpand == false)
            {
                sidebarTransition.Start();

                menuTransition.Start();
            }
            if (sideBarExpand == true)
            {
                menuTransition.Start();
            }
        }
        bool sideBarExpand = false;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 5;
                if (sideBar.Width <= 80)
                {
                    sideBarExpand = false;
                    sidebarTransition.Stop();

                    menuContainer.Width = sideBar.Width;
                    pnThoat.Width = sideBar.Width;
                }
            }
            else
            {
                sideBar.Width += 5;
                if (sideBar.Width >= 263)
                {
                    sideBarExpand = true;
                    sidebarTransition.Stop();

                    menuContainer.Width = sideBar.Width;
                    pnThoat.Width = sideBar.Width;

                }
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

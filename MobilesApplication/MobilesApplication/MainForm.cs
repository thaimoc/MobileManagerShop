using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Entities;
using MobilesApplication.Stock_Recieved;
using MobilesApplication.Salers;
using MobilesApplication.Member_Manisger;
using MobilesApplication.Wages_Manisger;

namespace MobilesApplication
{
    public partial class MainForm : Office2007Form
    {
        public delegate void SendUse(Member use);
        public SendUse Sender;

        private Member currentUse;

        public MainForm()
        {
            InitializeComponent();
            Sender = SetUse;
        }

        public void SetUse(Member use)
        {
            currentUse = use;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var i in MdiChildren)
                i.Close();
        }

        private void nvbHome_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (var i in MdiChildren)
                    i.Close();
            MenuForm frm = new MenuForm { MdiParent = this, WindowState = FormWindowState.Maximized };
            frm.Show();
        }

        private void nvbLogIn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (var i in MdiChildren)
                i.Close();
            LoginForm frm = new LoginForm { MdiParent = this };
            frm.Show();
        }

        private void nvbProducts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (currentUse != null)
            {
                ProductListForm frm = new ProductListForm { MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.SetCurrentMember(currentUse);
                frm.Show();
            }
            else
            {
                if (MessageBox.Show("You must login!", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    nvbLogIn_LinkClicked(null, null);
                }
            }
        }

        private void nvBarShoping_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (var i in MdiChildren)
                i.Close();
            if (currentUse != null)
            {
                OrderListForm frm = new OrderListForm { MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.setMember(currentUse);
                frm.Show();
            }
            else
            {
                if (MessageBox.Show("You must login before go to shoping!", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    nvbLogIn_LinkClicked(null, null);
                }

            }
        }

        private void nvbLogOut_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            currentUse = null;
            foreach (var i in MdiChildren)
                i.Close();
        }

        private void nvbRegister_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (var i in MdiChildren)
                i.Close();
            using (RegisterMemberForm frm = new RegisterMemberForm())
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                    currentUse = frm.currentMember;
            }
        }

        private void nvbMemberManisger_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (currentUse != null && currentUse.CategoryMemberID == 1)
            {
                foreach (var i in MdiChildren)
                    i.Close();
                MemberListForm frm = new MemberListForm { MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.SenMemberSelected(currentUse.UseName);
                frm.Show();
            }
            else
            {
                if (MessageBox.Show("You must login with admin account!", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    nvbLogIn_LinkClicked(null, null);
                }
            }
        }

        private void nvbStockReceived_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (currentUse != null && currentUse.CategoryMemberID == 1)
            {
                foreach (var i in MdiChildren)
                    i.Close();
                StockReceivedListForm frm = new StockReceivedListForm { MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.SetUseLogin(currentUse);
                frm.Show();
            }
            else
            {
                if (MessageBox.Show("You must login with admin account!", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    nvbLogIn_LinkClicked(null, null);
                }
            }
        }

        private void nvbWages_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (currentUse != null && currentUse.CategoryMemberID == 1)
            {
                foreach (var i in MdiChildren)
                    i.Close();
                WageListForm frm = new WageListForm { MdiParent = this, WindowState = FormWindowState.Maximized, currMember = currentUse };
                frm.Show();
            }
            else
            {
                if (MessageBox.Show("You must login with admin account!", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    nvbLogIn_LinkClicked(null, null);
                }
            }
        }

        private void nvbBills_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (currentUse != null && currentUse.CategoryMemberID == 1)
            {
                foreach (var i in MdiChildren)
                    i.Close();
                BillListForm frm = new BillListForm { MdiParent = this, WindowState = FormWindowState.Maximized};
                frm.SetUserLogIn(currentUse);
                frm.Show();
            }
            else
            {
                if (MessageBox.Show("You must login with admin account!", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    nvbLogIn_LinkClicked(null, null);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace MobilesApplication.Salers
{
    public partial class ChangePassWordForm : Office2007Form
    {
        public delegate void SendPassword(string pass);
        public SendPassword SendPass;
        public string pass = "";

        public ChangePassWordForm()
        {
            InitializeComponent();
            SendPass = setPassword;
        }

        public void setPassword(string pass)
        {
            this.pass = pass;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
        private void txtNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPass.Text.Length <= 3)
            {
                errorProvider.SetError(txtNewPass, "Old Password is not accepted less than 4 characters!");
                e.Cancel = true;
            }
            else if (txtNewPass.Text.Trim().Equals(string.Empty))
            {
                btnChange.Enabled = false;
            }
            else
            {
                errorProvider.SetError(txtNewPass, "");
            }
        }

        private void txtConfixPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfixPass.Text.Length > 0 && txtConfixPass.Text.CompareTo(txtNewPass.Text) != 0)
            {
                errorProvider.SetError(txtConfixPass, "Confix password is not corected!");                
                e.Cancel = true;

            }
            else if (txtConfixPass.Text.Trim().Equals(string.Empty))
            {
                btnChange.Enabled = false;
            }
            else
            {
                errorProvider.SetError(txtConfixPass, "");
                btnChange.Enabled = true;
            }

        }

        private void txtOldPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtOldPass.Text.Trim().Equals(string.Empty) || txtOldPass.Text.Length <= 3)
            {
                errorProvider.SetError(txtOldPass, "Old Password is empty, or less than 4 characters!");
                e.Cancel = true;
            }
            else if (txtOldPass.Text.Trim().Equals(string.Empty))
            {
                btnChange.Enabled = false;
            }
            else
            {
                errorProvider.SetError(txtOldPass, "");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (pass.CompareTo(txtOldPass.Text) == 0)
            {
                if (txtNewPass.Text.CompareTo(txtConfixPass.Text) == 0)
                {
                    pass = txtNewPass.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    errorProvider.SetError(txtConfixPass, "Confix password is not corected!");
                }
            }
            else
            {
                errorProvider.SetError(txtOldPass, "Password is not correct!");
                txtOldPass.Focus();
            }
        }

       
    }
}

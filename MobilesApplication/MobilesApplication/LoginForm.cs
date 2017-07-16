using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Entities;
using DAL.SqlServer;

namespace MobilesApplication
{
    public partial class LoginForm : Office2007Form
    {
        MemberRepository _repMember;
        public LoginForm()
        {
            InitializeComponent();
            _repMember = new MemberRepository();
        }

        private void btnXCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnXlogIn_Click(object sender, EventArgs e)
        {
            Member result = _repMember.GetByUseName(tbxUse.Text);
            if (result != null)
            {
                if (!tbxPass.Text.Equals(string.Empty) && tbxPass.Text.CompareTo(result.PassWord) == 0)
                {
                    MainForm frm = MdiParent as MainForm;
                    frm.SetUse(result);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    errorProvider.SetError(tbxPass, "Password is not corrected");
                    btnXlogIn.Enabled = false;
                }
            }
            else
            {
                errorProvider.SetError(tbxUse, "Use name is not exited!");
                btnXlogIn.Enabled = false;
            }
        }

        private void tbxUse_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!tbxUse.Text.Trim().Equals(string.Empty) && tbxUse.Text.Length <= 3)
            {
                errorProvider.SetError(tbxUse, "Use name is not accepted null or empty and is not accepted less than 4 characters!");
                e.Cancel = true;
                btnXlogIn.Enabled = false;
            }
            else if (tbxUse.Text.Trim().Equals(string.Empty))
            {
                errorProvider.SetError(tbxUse, "");
                btnXlogIn.Enabled = false;
            }
            else
            {
                errorProvider.SetError(tbxUse, "");
                btnXlogIn.Enabled = true;
            }

        }

        private void tbxPass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!tbxPass.Text.Trim().Equals(string.Empty) && tbxUse.Text.Length <= 3)
            {
                errorProvider.SetError(tbxPass, "Password is not accepted null or empty and is not accepted less than 4 characters!");
                e.Cancel = true;
                btnXlogIn.Enabled = false;
            }
            else if (tbxPass.Text.Trim().Equals(string.Empty))
            {
                errorProvider.SetError(tbxPass, "");
                btnXlogIn.Enabled = false;
            }
            else
            {
                errorProvider.SetError(tbxPass, "");
                btnXlogIn.Enabled = true;
            }
        }
    }
}

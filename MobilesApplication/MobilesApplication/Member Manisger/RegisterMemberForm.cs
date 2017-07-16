using System;
using System.ComponentModel;
using DevComponents.DotNetBar;
using BLL;
using Entities.IRepository;
using DAL.SqlServer;
using Entities;
using System.Windows.Forms;


namespace MobilesApplication.Member_Manisger
{
    public partial class RegisterMemberForm : Office2007Form
    {
        public Member currentMember;
        readonly MemberManager _memberManager;
        readonly IMemberRepository _repMember;
        public RegisterMemberForm()
        {
            InitializeComponent();
            _repMember = new MemberRepository();
            _memberManager = new MemberManager(_repMember);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsExited(string useName)
        {
            if (_memberManager.Find(mb => mb.UseName.ToLower().Equals(useName.ToLower())).Result.Count > 0)
                return true;
            return false;
        }

        private void tedUseName_Validating(object sender, CancelEventArgs e)
        {
            if (!tedUseName.Text.Trim().Equals(string.Empty))
            {
                if (tedUseName.Text.Length <= 4)
                {
                    tedUseName.ErrorText = "The usename's length must be more 4 character!";
                    e.Cancel = true;
                    btnSubmit.Enabled = false;
                }
                else if (IsExited(tedUseName.Text))
                {
                    tedUseName.ErrorText = "This usename had been exited!";
                    e.Cancel = true;
                    btnSubmit.Enabled = false;
                }
                else
                    btnSubmit.Enabled = IsCheckOK();
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void tedFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (tedFirstName.Text.Equals(string.Empty) || tedFirstName.Text.Trim().Equals(string.Empty))
            {
                tedFirstName.ErrorText = "First name is not accept null!";
                e.Cancel = true;
                return;
            }
            btnSubmit.Enabled = IsCheckOK();
        }

        private void tedLastName_Validating(object sender, CancelEventArgs e)
        {
            if (tedLastName.Text.Equals(string.Empty) || tedLastName.Text.Trim().Equals(string.Empty))
            {
                tedLastName.ErrorText = "Last name is not accept null!";
                e.Cancel = true;
                return;
            }
            btnSubmit.Enabled = IsCheckOK();
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtPass.Text.Equals(string.Empty) || txtPass.Text.Trim().Equals(string.Empty) || txtPass.Text.Length < 5)
            {
                errorProvider.SetError(txtPass, "Password is not accept null and is not accepted less than 4 characters");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPass, "");
                btnSubmit.Enabled = IsCheckOK();
            }
        }

        private void txtConfixPass_Validating(object sender, CancelEventArgs e)
        {
            if (!txtConfixPass.Text.Equals(string.Empty) && !txtConfixPass.Text.Equals(txtPass.Text))
            {
                errorProvider.SetError(txtConfixPass, "Confix Password is not corrected!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtConfixPass, "");
                btnSubmit.Enabled = IsCheckOK();
            }
        }

        private void tedNumHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar))
            {
                btnSubmit.Enabled = IsCheckOK();
            }
            else
                e.Handled = true;
        }

        private void cbbxCities_Validating(object sender, CancelEventArgs e)
        {
            if (cbbxCities.SelectedIndex == -1)
            {
                cbbxCities.ErrorText = "City is empty!";
                e.Cancel = true;
                return;
            }
            btnSubmit.Enabled = IsCheckOK();
        }

        private void dateEditBirthDate_Validating(object sender, CancelEventArgs e)
        {
            if (dateEditBirthDate.Text.Equals(string.Empty) || !TestBirthDate(dateEditBirthDate.DateTime))
            {
                dateEditBirthDate.ErrorText = "The birth date is not accepted less than 16 or more than 150, and is not accepted null!";
                e.Cancel = true;
                return;
            }
            btnSubmit.Enabled = IsCheckOK();
        }

        private static bool TestBirthDate(DateTime birth)//Kiem tra tuoi tren 16 duoi 150
        {
            DateTime temp = new DateTime(DateTime.Now.Year, birth.Month, birth.Day);
            int year = temp.Year - birth.Year;
            int totalDay = year * 365;
            int month = temp.Month - DateTime.Now.Month;
            totalDay += month * 30;
            totalDay += temp.Day - DateTime.Now.Day;
            if (totalDay >= 16 * 365 && totalDay < 150 * 365)
                return true;
            return false;
        }


        private void tedNumHouse_Validating(object sender, CancelEventArgs e)
        {
            if (tedNumHouse.Text.Equals(string.Empty))
            {
                tedNumHouse.ErrorText = "Number house is not accepted null!";
                e.Cancel = true;
                return;
            }
            
                btnSubmit.Enabled = IsCheckOK();
        }

        private void tedStreet_Validating(object sender, CancelEventArgs e)
        {
            if (tedStreet.Text.Equals(string.Empty))
            {
                tedStreet.ErrorText = "Street is not accepted null!";
                e.Cancel = true;
                return;
            }
            
                btnSubmit.Enabled = IsCheckOK();
        }

        private void tedUrban_Validating(object sender, CancelEventArgs e)
        {
            if (tedUrban.Text.Equals(string.Empty))
            {
                tedUrban.ErrorText = "Urban is not accepted null!";
                e.Cancel = true;
                return;
            }
            btnSubmit.Enabled = IsCheckOK();
        }

        private void tedTown_Validating(object sender, CancelEventArgs e)
        {
            if (tedTown.Text.Equals(string.Empty))
            {
                tedTown.ErrorText = "Town is not accepted null!";
                e.Cancel = true;
                return;
            }
            btnSubmit.Enabled = IsCheckOK();
        }

        private bool IsCheckOK()
        {
            if (tedUseName.Text.Length > 0 && tedFirstName.Text.Length > 0 && tedLastName.Text.Length > 0
                && txtPass.Text.Length > 0 && txtConfixPass.Text.Length > 0 && dateEditBirthDate.Text.Length > 0
                && tedNumHouse.Text.Length > 0 && tedStreet.Text.Length > 0 && tedUrban.Text.Length > 0
                && tedTown.Text.Length > 0 && cbbxCities.Text.Length > 0)
                return true;
            return false;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            currentMember = new Member { UseName=tedUseName.Text, PassWord = txtPass.Text, BirthDate = dateEditBirthDate.DateTime,
                FirstName = tedFirstName.Text, LastName = tedLastName.Text, NumHouse = int.Parse(tedNumHouse.Text),
                Street = tedStreet.Text, Urban = tedUrban.Text, Town = tedTown.Text, City = cbbxCities.Text,
                                         Gender = !swbtnGender.Value, CategoryMemberID = 3
            };
            string message = _memberManager.InsertOrUpdate(currentMember).GetErrorMessages();
            if (message.Length > 0)
                MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }


        
    }
}

using System;
using DevComponents.DotNetBar;
using Entities.IRepository;
using DAL.SqlServer;
using Entities;
using DevExpress.XtraBars.Helpers;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using System.Drawing;
using DevExpress.XtraEditors.Controls;

namespace MobilesApplication.Member_Manisger
{
    public partial class MemberListForm : Office2007Form
    {
        public delegate void SendMemberMessage(string useName);
        public SendMemberMessage memberMessage;
        
        private readonly IMemberRepository _repository;
        private readonly ICategoryMember _repositoryCate;
        private readonly MemberManager _manistger;
        
        public MemberListForm()
        {            
            InitializeComponent();
            SkinHelper.InitSkinPopupMenu(skins);
            repBirthDate.MaxValue = new DateTime(DateTime.Today.Year - 18, DateTime.Today.Month, DateTime.Today.Day);
            _repositoryCate = new CategoryMemberRepository();
            _repository = new MemberRepository();
            _manistger = new MemberManager(_repository);
            bitAll.PerformClick();
            memberMessage = SenMemberSelected;
        }

        public void SenMemberSelected(string useName)
        {
            membersBindingSource.DataSource = _repository.Find(m => m.UseName == useName);
        }

        private void bitNew_ItemClick()
        {
            gridView.AddNewRow();
        }


        private static void ShowEdit(bool enable)
        {
            if (enable)
            {
                
            }
            else
            {
               
            }
        }

        
        private void MemberListForm_Load(object sender, EventArgs e)
        {
            repAllCategories.DataSource = _repositoryCate.GetAll();
            refreshToolStripMenuItem.PerformClick();            
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridViewEdit.AddNewRow();
        }
        
        
        private void barDetails_CheckedChanged_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer.Panel2Collapsed = barDetails.Checked;
        }

        private void bitAll_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            membersBindingSource.DataSource = _repository.GetAll();
        }

        private void bitExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridViewEdit.DataRowCount <= 0)
            {
                MessageBoxEx.Show(this, "Please input data! Before you will save it!");
            }
            Member temp;
            for (int i = 0; i < gridViewEdit.DataRowCount; i++)
            {
                temp = gridViewEdit.GetRow(i) as Member;
                temp.CategoryMemberID = temp.CategoryInfo.ID;
                string s = _manistger.InsertOrUpdate(temp).GetErrorMessages();
                if(s.Length > 0) MessageBox.Show(s, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            saveToolStripMenuItem.Enabled = false;
            bitAll.PerformClick();
        }


        private static bool TestBirthDate(DateTime birth)//Kiem tra tuoi tren 18 duoi 150
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

        private void bitEditAllSelected_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<Member> temp = new List<Member>();
            for (int i = 0; i < gridView.RowCount; i++)
            {
                if (gridView.IsRowSelected(i))
                {
                     temp.Add(gridView.GetRow(i) as Member);
                }
            }
            membersBindingSource1.DataSource = temp;
        }


        private void bitDeleteAllSelected_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < gridView.RowCount; i++)
            {
                if (gridView.IsRowSelected(i))
                {
                    _manistger.Delete(gridView.GetRow(i) as Member);
                }
            }
            bitAll.PerformClick();
        }


        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    bitAll.PerformClick();
                    break;
                case Keys.Enter:
                    bitEditAllSelected.PerformClick();
                    break;
                case Keys.Delete:
                    Delete();                    
                    break;
            }
        }

        private void gridMembers_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (!Delete())
                    e.Handled = true;
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                barDetails.PerformClick();
                e.Handled = true;
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Edit)
            {
                bitEditAllSelected.PerformClick();
                e.Handled = true;
            }
        }

        private void gridViewEdit_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            GridColumn col = view.Columns["UseName"];
            string temp = (string)view.GetRowCellValue(e.RowHandle, col);

            if (temp == null || temp.Length <= 4)
            {
                e.Valid = false;
                view.SetColumnError(col, "The usename's length must be more 4 character!");                
            }

            col = view.Columns["PassWord"];
            temp = (string)view.GetRowCellValue(e.RowHandle, col);
            if (temp == null || temp.Length <= 3)
            {
                e.Valid = false;
                view.SetColumnError(col, "The password's length must be more 3 character!");
            }

            col = view.Columns["FirstName"];
            temp = (string)view.GetRowCellValue(e.RowHandle, col);
            if (temp == null || temp.Length <= 0)
            {
                e.Valid = false;
                view.SetColumnError(col, "The Frist name doesn't accept null!");
            }

            col = view.Columns["LastName"];
            temp = (string)view.GetRowCellValue(e.RowHandle, col);
            if (temp == null || temp.Length <= 0)
            {
                e.Valid = false;
                view.SetColumnError(col, "The Last name doesn't accept null!");
            }

            Member m = gridViewEdit.GetRow(e.RowHandle) as Member;

            col = view.Columns["BirthDate"];
            if (!TestBirthDate(m.BirthDate))
            {
                e.Valid = false;
                view.SetColumnError(col, "The age must less than 150 and more than 16!");
            }

            col = view.Columns["City"];
            if (m.Address == null || m.Address.Length <= 0)
            {
                e.Valid = false;
                view.SetColumnError(col, "The address filde doesn't accept null!");
            }

            col = view.Columns["CategoryInfo"];
            CategoryMember cat = view.GetRowCellValue(e.RowHandle, col) as CategoryMember;
            if (!(cat != null))
            {
                e.Valid = false;
                view.SetColumnError(col, "The CategoryInfo filde doesn't accept null!");
            }

            if (e.Valid == false)
                saveToolStripMenuItem.Enabled = false;
            else
                saveToolStripMenuItem.Enabled = true;
        }

        private bool Delete()
        {
            Member temp = gridView.GetRow(gridView.FocusedRowHandle) as Member;
            if (MessageBox.Show(String.Format("Do you want to delete use {0}", temp.UseName), "Warrning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                _manistger.Delete(temp);
                bitAll.PerformClick();
                return true;
            }
            return false;
            
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            membersBindingSource1.DataSource = new List<Member>();
        }

        private void repCities_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            if (e.State == DrawItemState.None)
            {
                e.Appearance.BackColor = e.Index % 2 == 0 ? Color.Green : Color.Red;
            }
        }

        private void gridViewEdit_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        

        

        


    }
}

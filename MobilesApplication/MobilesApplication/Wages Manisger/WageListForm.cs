using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using DevComponents.DotNetBar;
using Entities;
using Entities.IRepository;
using BLL;
using DAL.SqlServer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using MobilesApplication.Member_Manisger;
using System.Windows.Forms;

namespace MobilesApplication.Wages_Manisger
{
    public partial class WageListForm : Office2007Form
    {
        public Member currMember;

        private IMemberRepository _repMember;
        private IGeneralRepository<WageCoefficient> _repCoefficient;
        private IGeneralRepository<Wage> _repository;
        private WageMagager _manager;

        public WageListForm()
        {
            InitializeComponent();
            //SkinHelper.InitSkinGallery(galleryContainer);
        }

        private void WageListForm_Load(object sender, EventArgs e)
        {
             _repMember = new MemberRepository();
             repEmployees.DataSource = _repMember.Find(em => em.CategoryInfo.Location == "Admin" || em.CategoryInfo.Location == "Saler");
            
             _repCoefficient = new GeneralRepository<WageCoefficient>();
             repCoefficient.DataSource = _repCoefficient.Find(w => w.Deleted == false).ToList();

            _repository = new GeneralRepository<Wage>();
            _manager = new WageMagager(_repository);
            btnRefresh_Click(null, null);
        }

        private void barExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void command_PreviewExecuted(object sender, CancelEventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                styleManager.ManagerStyle = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());
            }
            else
                if (source.CommandParameter is Color)
                {
                    styleManager.ManagerColorTint = (Color)source.CommandParameter;
                }
        }

        private void colorPickerDropDown1_ColorPreview(object sender, ColorPreviewEventArgs e)
        {
            styleManager.ManagerColorTint = e.Color;
        }

        
        private void repCoefficient_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit item = sender as LookUpEdit;
            gridView.SetRowCellValue(gridView.FocusedRowHandle, colCoefficientsID, repCoefficient.GetDataSourceValue("Point", item.ItemIndex));
        }

        private void repEmployees_EditValueChanged(object sender, EventArgs e)
        {
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "AdminInfo", currMember);
        }


        private void gridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["DateEstablished"], DateTime.Today);
            view.SetRowCellValue(e.RowHandle, view.Columns["AdminID"], currMember.UseName);
            btnSave.Enabled = true;
        }

        private void gridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            GridColumn col = view.Columns["Premium"];
            bool save = true;
            float temp = (float)view.GetRowCellValue(e.RowHandle, col);
            if ( 0 > temp)
            {
                e.Valid = false;
                view.SetColumnError(col, "The premium is not less than 0.00!");
                save = false;
            }

            col = view.Columns["TotalDate"];
            int total = (int)view.GetRowCellValue(e.RowHandle, col);
            if (0 > total || total > 30)
            {
                e.Valid = false;
                view.SetColumnError(col, "The total date is not less than 0 and more than 30!");
                save = false;
            }

            col = view.Columns["EmployeeName"];
            string name = (string)view.GetRowCellValue(e.RowHandle, col);
            if (name == "Null")
            {
                e.Valid = false;
                view.SetColumnError(col, "The employee's name is not accepted null!");
                save = false;
            }

            col = view.Columns["Point"];
            float point = (float)view.GetRowCellValue(e.RowHandle, col);
            if (point <= 0)
            {
                e.Valid = false;
                view.SetColumnError(col, "The Point is not accepted less than 0.5!");
                save = false;
            }

            btnSave.Enabled = save;
        }

        private void gridView_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var li = _repository.GetAll().ToList();
            li.ForEach(i=>{
                i.WageCoefficientInfo = _repCoefficient.Find(c=>c.ID == i.CoefficientsID).FirstOrDefault();
                i.Point = i.WageCoefficientInfo.Point;
            });
            li.ForEach(i => {
                i.AdminInfo = _repMember.Find(m => m.UseName == i.AdminID).FirstOrDefault();
            });
            li.ForEach(i =>
            {
                i.EmployeeInfo = _repMember.Find(m => m.UseName == i.EmployeeID).FirstOrDefault();
            });
            wagesBindingSource.DataSource = li;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if(gridView.RowCount <= _repository.GetAll().ToList().Count)
                btnRefresh_Click(null, null);
            gridView.AddNewRow();            
        }

        private void btnShowEmpl_Click(object sender, EventArgs e)
        {
            using (MemberListForm frm = new MemberListForm())
            {
                frm.memberMessage((gridView.GetRow(gridView.FocusedRowHandle) as Wage).EmployeeID);
                frm.ShowDialog();
            }
        }

        private void btnShowAdm_Click(object sender, EventArgs e)
        {
            using (MemberListForm frm = new MemberListForm())
            {
                frm.memberMessage((gridView.GetRow(gridView.FocusedRowHandle) as Wage).AdminID);
                frm.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                Wage temp = gridView.GetRow(i) as Wage;
                temp.CoefficientsID = temp.WageCoefficientInfo.ID;
                temp.EmployeeID = temp.EmployeeInfo.UseName;
                temp.AdminID = temp.AdminInfo.UseName;

                string message = _manager.InsertOrUpdate(temp).GetErrorMessages();
                if (message.Length > 0) MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnRefresh_Click(null, null);
            btnSave.Enabled = false;
        }

        private void repEmployees_EditValueChanging(object sender, ChangingEventArgs e)
        {
            string useName = ((Member)e.NewValue).UseName;
            for (int i = 0; i < gridView.RowCount; i++)
            {
                Wage w = (Wage)gridView.GetRow(i);
                if (w != null)
                {
                    if (w.EmployeeInfo.UseName == useName &&
                        w.DateEstablished.Year == ((DateTime)gridView.GetRowCellValue(gridView.FocusedRowHandle, "DateEstablished")).Year
                        &&
                        w.DateEstablished.Month == ((DateTime)gridView.GetRowCellValue(gridView.FocusedRowHandle, "DateEstablished")).Month)
                    {
                        e.Cancel = true;
                        MessageBox.Show("This Wage had been exited!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }

        private void repDateEstab_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DateTime date = (DateTime)e.NewValue;
            string usEpl = ((Wage)gridView.GetRow(gridView.FocusedRowHandle)).EmployeeID;
            for (int i = 0; i < gridView.RowCount; i++)
            {
                Wage w = (Wage)gridView.GetRow(i);
                if (w != null)
                {

                    if (w.EmployeeID == usEpl && w.DateEstablished.Year == date.Year && w.DateEstablished.Month == date.Month)
                    {
                        e.Cancel = true;
                        MessageBox.Show("This Wage had been exited!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }

        private void gridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                btnNew_Click(null, null);
                e.Handled = true;
            }
        }

        private void btnShowWageCoefficient_Click(object sender, EventArgs e)
        {
            if (MdiParent != null)
            {
                WageCoefficientListForm frm = new WageCoefficientListForm { MdiParent = this.MdiParent, currMember = currMember };
                frm.Show();
            }
        }

        

        

        
    }
}

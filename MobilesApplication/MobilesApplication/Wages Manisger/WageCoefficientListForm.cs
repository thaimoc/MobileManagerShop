using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Entities;
using Entities.IRepository;
using BLL;
using DAL.SqlServer;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using MobilesApplication.Member_Manisger;

namespace MobilesApplication.Wages_Manisger
{
    public partial class WageCoefficientListForm : Office2007Form
    {

        public Member currMember;

        private IGeneralRepository<WageCoefficient> _repository;
        private WageCoefficientManager _manager;

        public WageCoefficientListForm()
        {
            InitializeComponent();
        }

        private void WageCoefficientListForm_Load(object sender, EventArgs e)
        {                   
            _repository = new GeneralRepository<WageCoefficient>();
            _manager = new WageCoefficientManager(_repository);

            refreshToolStripMenuItem.PerformClick();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wageCoefficientsBindingSource.DataSource = _repository.GetAll().ToList();//for new row (_repository.GetAll() => IQueryable<T> not accept new row)

        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["DateEstablished"], DateTime.Today);
            view.SetRowCellValue(e.RowHandle, view.Columns["AdminID"], currMember.UseName);
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            GridColumn col = view.Columns["Point"];
            float temp = (float)view.GetRowCellValue(e.RowHandle, col);
            if (temp == null ||temp > 4f || temp < 0.5f)
            {
                e.Valid = false;
                view.SetColumnError(col, "The point is not to accepte null and it's less than 4.0 and more than 0.5!");
                saveToolStripMenuItem.Enabled = false;
            }
            else if(_repository.Find(w => w.Point == temp && w.AdminID == currMember.UseName).ToList().Count > 0)
            {
                e.Valid = false;
                view.SetColumnError(col, "This point is exited!");
                saveToolStripMenuItem.Enabled = false;
            }
            else
                saveToolStripMenuItem.Enabled = true;

        }

        private void gridView1_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void showAdminInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberListForm frm = new MemberListForm();
            WageCoefficient temp = gridView1.GetRow(gridView1.FocusedRowHandle) as WageCoefficient;
            frm.memberMessage(temp.AdminID);
            frm.Show();            
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
                showAdminInfoToolStripMenuItem.Enabled = true;
            else
                showAdminInfoToolStripMenuItem.Enabled = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                WageCoefficient temp = gridView1.GetRow(i) as WageCoefficient;
                //temp.MemberInfo = currMember;
                //temp.WagesInfo = _repository.Find()




                
                string message = _manager.InsertOrUpdate(temp).GetErrorMessages();
                //if (message.Length > 0) MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            refreshToolStripMenuItem.PerformClick();
            saveToolStripMenuItem.Enabled = false;
        }


    }
}

using System;
using System.Drawing;
using System.Linq;
using DevComponents.DotNetBar;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using Entities;
using Entities.IRepository;
using DAL.SqlServer;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using BLL;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Card;
using System.Windows.Forms;
using System.Collections.Generic;
using MobilesApplication.Member_Manisger;

namespace MobilesApplication.Stock_Recieved
{
    public partial class StockReceivedListForm : Office2007Form 
    {
        private Member currMember;
        private IGeneralRepository<Product> _proRepository;
        private IGeneralRepository<StockReceived> _stockRepository;
        private IGeneralRepository<StockReceivedDetail> _stockDetails;
        private MemberRepository _memberRepository;
        private ProductManager _managerProducts;
        private StockReceivedManager _manager;
        private StockReceivedDetailManager _managerStockedDetails;
        private int stockId = 1;
        
        private List<int> listChanged;
        private bool isNew = false;

        public delegate void SendUser(Member mb);
        private SendUser SendUse;

        public StockReceivedListForm()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinRegistrator.Register();
            SkinHelper.InitSkinGallery(Skins);
        }

        public void SetUseLogin(Member mb)
        {
            currMember = mb;
        }        

        private void StockReceivedListForm_Load(object sender, EventArgs e)
        {
            
            _proRepository = new GeneralRepository<Product>();
            _stockRepository = new GeneralRepository<StockReceived>();
            _stockDetails = new GeneralRepository<StockReceivedDetail>();
            _memberRepository = new MemberRepository();
            _manager = new StockReceivedManager(_stockRepository);
            _managerStockedDetails = new StockReceivedDetailManager(_stockDetails);
            _managerProducts = new ProductManager(_proRepository);

            repAdmins.DataSource = _memberRepository.GetAll().Where(mb => mb.CategoryInfo.Location == "Admin").ToList();
            repProducts.DataSource = _proRepository.GetAll().ToList();
            listChanged = new List<int>();
            expandablePanel.PerformClick();
            btnAll.PerformClick();
        }

        private void gridViewProducts_CustomDrawRowPreview(object sender, RowObjectCustomDrawEventArgs e)
        {
            const int dx = 8;
            var r = e.Bounds;
            r.X += e.Bounds.Height + dx + 2;
            r.Width -= (e.Bounds.Height + dx + 3);
            string originalPath = @"images\" + gridViewProducts.GetRowCellValue(e.RowHandle, "Image");
            var tempImage = Image.FromFile(originalPath);

            e.Graphics.DrawImage(tempImage, e.Bounds.X + dx,
                    e.Bounds.Y, e.Bounds.Height, e.Bounds.Height);
            string draw = String.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", (string)gridViewProducts.GetRowCellValue(e.RowHandle, "Name"), (bool)gridViewProducts.GetRowCellValue(e.RowHandle, "Type") ? "Type: Phone" : "Type: Other",
                (string)gridViewProducts.GetRowCellValue(e.RowHandle, "UnitPrice"), "Price: " + ((Decimal)gridViewProducts.GetRowCellValue(e.RowHandle, "Price")),
                "Quantity: " + (int)gridViewProducts.GetRowCellValue(e.RowHandle, "Quantity"), "Description: " + (string)gridViewProducts.GetRowCellValue(e.RowHandle, "Description")
                );
            e.Appearance.DrawString(e.Cache, draw, r);
            e.Handled = true;
        }


        private void expandablePanel_Click(object sender, EventArgs e)
        {
            productsBindingSource.DataSource = _proRepository.GetAll().ToList();
        }

        #region Stock Received details design
        private void cardViewStockDetails_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var view = sender as ColumnView;
            var col = view.Columns["UnitPrice"];
            bool save = true;
            try
            {
                decimal temp = (decimal)view.GetRowCellValue(e.RowHandle, col);
                if (temp <= 0)
                {
                    e.Valid = false;
                    view.SetColumnError(col, "Unit price is not accepted null or empty or less than zezo!");
                    save = false;
                }
            }
            catch
            {
                e.Valid = false;
                view.SetColumnError(col, "Unit price is not accepted null!");
                save = false;
            }
            try
            {
                col = view.Columns["Count"];
                int count = (int)view.GetRowCellValue(e.RowHandle, col);
                if (count <= 0)
                {
                    e.Valid = false;
                    view.SetColumnError(col, "Count is not accepted less than zezo!");
                    save = false;
                }
            }
            catch
            {
                e.Valid = false;
                view.SetColumnError(col, "Count is not accepted null!");
                save = false;
            }

            try
            {
                col = view.Columns["ProductID"];
                int proId = (int)view.GetRowCellValue(e.RowHandle, col);
                if (proId <= 0)
                {
                    e.Valid = false;
                    view.SetColumnError(view.Columns["ProductName"], "Please choose product!");
                    save = false;
                }
            }
            catch
            {
                e.Valid = false;
                view.SetColumnError(view.Columns["ProductName"], "Please choose product!");
                save = false;
            }

            btnDetailsSave.Enabled = save;
        }

        private void cardViewStockDetails_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;

        }

        public List<int> ProIds()
        {
            var rs = new List<int>();
            for (int i = 0; i < cardViewStockDetails.DataRowCount; i++)
            {
                rs.Add((int)cardViewStockDetails.GetRowCellValue(i, "ProductID"));
            }
            return rs;
        }

        private void repProducts_EditValueChanging(object sender, ChangingEventArgs e)
        {
            int newId = (e.NewValue as Product).ID;
            if (!ProIds().Contains(newId))
                return;

            alertControl.Show(this, "Error!", "This product was exited in this card!");
            e.Cancel = true;
        }



        private void btnAllDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!isNew)
            {
                stockDetailsBindingSource.DataSource = _stockDetails.Find(dt => dt.StockRecievedID == stockId).ToList();
            }
        }

        private void btnDetailsSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!isNew)
            {
                _managerStockedDetails.Delete(stockId);
            }
            else
            {
                var stock = new StockReceived { AdminID = currMember.UseName, AdminInfo = currMember, DateEstablish = DateTime.Today, Deleted = false };
                stockId = _stockRepository.Add(stock);
                 
            }
            for (int i = 0; i < cardViewStockDetails.DataRowCount; i++)
            {
                var temp = cardViewStockDetails.GetRow(i) as StockReceivedDetail;
                temp.StockRecievedID = stockId;
                _managerStockedDetails.Insert(temp).GetErrorMessages();
            }
            if (isNew)
            {
                xtraTabPage1.PageEnabled = true;
                isNew = false;
                
                btnAll.PerformClick();
            }
            expandablePanel.PerformClick();
            btnDetailsSave.Enabled = false;
        }

        private void btnDeleteDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                cardViewStockDetails.DeleteRow(cardViewStockDetails.FocusedRowHandle);
            }
            catch { }
        }

        private void btnNewDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!isNew)
                return;

            btnAllDetails.PerformClick();

            cardViewStockDetails.AddNewRow();
            btnDetailsSave.Enabled = false;
        }

        private void cardViewStockDetails_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var view = sender as CardView;
            view.SetRowCellValue(e.RowHandle, view.Columns["Count"], 1);
            view.SetRowCellValue(e.RowHandle, view.Columns["StockRecievedID"], stockId);
        }

        private void btnPinterDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            var curent = _stockRepository.GetById(stockId);
            var details = _stockDetails.Find(dt => dt.StockRecievedID == stockId).ToList();
            var pros = new List<Product>();
            details.ForEach(i => pros.Add(i.ProductInfo));
            var fr = new XtraReportStockReceivedDetails(curent, pros);
            fr.ShowPreview();
        }

        #endregion


        #region Stock Received disign
        private void btnAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            stockReceivedsBindingSource.DataSource = _stockRepository.GetAll().ToList();
            listChanged.Clear();
        }

        #endregion

        private void layoutViewStockReceiveds_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var view = sender as LayoutView;
            var col = view.Columns["DateEstablish"];
            bool save = true;
            var dateS = (DateTime)view.GetRowCellValue(e.RowHandle, col);
            if (dateS > DateTime.Today)
            {
                e.Valid = false;
                view.SetColumnError(col, "Established is not accept less than to day!!");
                save = false;
            }

            btnSave.Enabled = save;
        }

        private void layoutViewStockReceiveds_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var view = sender as LayoutView;
            view.SetRowCellValue(e.RowHandle, view.Columns["AdminInfo"], currMember);
            view.SetRowCellValue(e.RowHandle, view.Columns["DateEstablish"], DateTime.Today);
        }

        private void layoutViewStockReceiveds_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            isNew = true;
            stockDetailsBindingSource.DataSource = _stockDetails.Find(dt => dt.StockRecievedID == -1).ToList();
            btnSave.Enabled = false;
            xtraTabControl1.SelectedTabPage = xtraTabPage2;
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            listChanged.ForEach(i =>
            {
                var temp = layoutViewStockReceiveds.GetRow(i) as StockReceived;
                _manager.InsertOrUpdate(((StockReceived)temp)).GetErrorMessages();
            });

            listChanged.Clear();
            btnSave.Enabled = false;
        }

        private void layoutViewStockReceiveds_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!listChanged.Contains(e.RowHandle))
                listChanged.Add(e.RowHandle);
        }

        private void layoutViewStockReceiveds_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (stockId == 0)
            {
                return;
            }
            try
            {
                stockId = (int)layoutViewStockReceiveds.GetRowCellValue(e.FocusedRowHandle, "ID");
            }
            catch { }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (stockId == 0)
            {
                var li = _stockRepository.GetAll().ToList();
                stockId = li[li.Count - 1].ID;
            }
            if (stockId != 0 && e.Page == xtraTabPage2)
            {
                rbDetailsOption.Visible = true;
                rbPageFile.Visible = false;
                rbpFind.Visible = false;
                if (isNew)
                {
                    btnNewDetails.PerformClick();
                }
                else
                {                    
                    btnAllDetails.PerformClick();
                }
            }
            if (e.Page != xtraTabPage1)
                return;

            rbDetailsOption.Visible = false;
            rbPageFile.Visible = true;
            rbpFind.Visible = true;

        }

        private void layoutViewStockReceiveds_BeforeLeaveRow(object sender, RowAllowEventArgs e)
        {
            if (isNew)
            {
                var dlg = MessageBox.Show("This row is new and not save! Do you want save it", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dlg == DialogResult.No)
                {
                    btnAll.PerformClick();
                }
                else
                {
                    stockId = 0;                    
                    btnSave.PerformClick();
                    var newStock = layoutViewStockReceiveds.GetRow(layoutViewStockReceiveds.DataRowCount - 1) as StockReceived;
                    _manager.InsertOrUpdate(newStock);
                    xtraTabControl1.SelectedTabPage = xtraTabPage2;
                    MessageBox.Show(stockId.ToString());
                    xtraTabPage1.PageEnabled = false;
                    e.Allow = false;
                }
            }
        }

        private void edbFindAdminUse_EditValueChanged(object sender, EventArgs e)
        {
            string temp = ((string)edbFindAdminUse.EditValue).ToLower();
            if (String.IsNullOrEmpty(temp))
                btnAll.PerformClick();
            else
            {
                stockReceivedsBindingSource.DataSource = _stockRepository.Find(st => st.AdminID.ToLower().Contains(temp));
            }
        }

        private void edFindAdminName_EditValueChanged(object sender, EventArgs e)
        {
            string temp = ((string)edFindAdminName.EditValue).ToLower();
            if (String.IsNullOrEmpty(temp))
                btnAll.PerformClick();
            else
            {
                var li = _stockRepository.GetAll().ToList();
                li.ForEach(i =>
                {
                    i.AdminInfo = _memberRepository.GetByUseName(i.AdminID);
                });
                stockReceivedsBindingSource.DataSource = li.FindAll(i => i.AdminName.ToLower().Contains(temp));
            }
        }

        private void edtimeEstablished_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var temp = (DateTime)edtimeEstablished.EditValue;
                stockReceivedsBindingSource.DataSource = _stockRepository.Find(st => st.DateEstablish.Year == temp.Year
                    && st.DateEstablish.Month == temp.Month
                    && st.DateEstablish.Day == temp.Day);
            }
            catch
            {
                    btnAll.PerformClick();
            }
        }

        private void chbDeleted_EditValueChanged(object sender, EventArgs e)
        {
            stockReceivedsBindingSource.DataSource = _stockRepository.Find(st => st.Deleted == (bool)chbDeleted.EditValue);
        }

        private void btnShowAdminInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new MemberListForm())
            {
                frm.memberMessage((string)layoutViewStockReceiveds.GetRowCellValue(layoutViewStockReceiveds.FocusedRowHandle, "AdminID"));
                frm.ShowDialog();
            }
        }

        




    }
}

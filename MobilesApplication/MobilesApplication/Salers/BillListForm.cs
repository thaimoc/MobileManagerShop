using System;
using DevComponents.DotNetBar;
using Entities.IRepository;
using Entities;
using DAL.SqlServer;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using MobilesApplication.Member_Manisger;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;

namespace MobilesApplication.Salers
{
    public partial class BillListForm : Office2007Form
    {
        private IGeneralRepository<Bill> _repBills;
        private IGeneralRepository<BillDetail> _repBillDetails;
        private IMemberRepository _repMembers;
        private IGeneralRepository<Order> _repOrders;
        private IGeneralRepository<OrderDetail> _repOrderDetails;
        private IGeneralRepository<Product> _repProducts;

        private List<Bill> bills = null;

        private Member currMember;
        private bool isNew = false;

        public delegate void UseLogIn(Member mb);
        public UseLogIn LogIn;

        Bill current;
        public BillListForm()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinRegistrator.Register();
            SkinHelper.InitSkinGallery(Skins);
            LogIn = SetUserLogIn;
        }

        public void SetUserLogIn(Member mb)
        {
            currMember = mb;
        }

        private void BillListForm_Load(object sender, EventArgs e)
        {
            _repBills = new GeneralRepository<Bill>();
            _repBillDetails = new GeneralRepository<BillDetail>();
            _repMembers = new MemberRepository();
            _repOrders = new GeneralRepository<Order>();
            _repOrderDetails = new GeneralRepository<OrderDetail>();
            _repProducts = new GeneralRepository<Product>();

            bills = new List<Bill>();

            repOrders.DataSource = _repOrders.Find(or => or.Deleted == false).ToList();
            btnAll.PerformClick();
            repCustomers.DataSource = _repMembers.GetAll().ToList();

        }

        private void repCustomers_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Member mb = e.NewValue as Member;
            layoutViewBills.SetRowCellValue(layoutViewBills.FocusedRowHandle, "CusID", mb.UseName);
            layoutViewBills.SetRowCellValue(layoutViewBills.FocusedRowHandle, "CusName", mb.FullName);
            if (current != null)
            {
                current.CusID = mb.UseName;
                current.CusName = mb.FullName;
                current.CusInfo = mb;
            }
        }

        private void btnAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            var li = _repBills.GetAll().ToList();
            li.ForEach(i =>
            {
                i.CusInfo = _repMembers.Find(m => m.UseName == i.CusID).First();
                i.CusName = i.CusInfo.FullName;
            });
            li.ForEach(i =>
            {
                i.SelerInfo = _repMembers.Find(m => m.UseName == i.SelID).First();
                i.SalerName = i.SelerInfo.FullName;
            });
            bindingSource.DataSource = li;
        }

        private void btnShowDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbonPageFind.Visible = false;
            btnDetailsAll.PerformClick();
            gridControl.MainView = cardViewBillDetails;
            ribbonPageGroupFile.Visible = false;
            ribbonPageGroupDetailOptions.Visible = true;
            btnShowBills.Enabled = true;
            btnShowDetails.Enabled = false;
        }

        private void btnShowBills_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbonPageFind.Visible = true;
            btnAll.PerformClick();
            gridControl.MainView = layoutViewBills;
            ribbonPageGroupFile.Visible = true;
            ribbonPageGroupDetailOptions.Visible = false;
            btnShowDetails.Enabled = true;
            btnShowBills.Enabled = false;
        }

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            layoutViewBills.AddNewRow();
            layoutViewBills.SetRowCellValue(layoutViewBills.FocusedRowHandle, "SelID", currMember.UseName);
            layoutViewBills.SetRowCellValue(layoutViewBills.FocusedRowHandle, "SalerName", currMember.FullName);
            layoutViewBills.SetRowCellValue(layoutViewBills.FocusedRowHandle, "RequireDate", DateTime.Today);

            current = new Bill
            {
                ID = 0,
                RequireDate = DateTime.Today,
                SelerInfo = currMember,
                SalerName = currMember.FullName,
                SelID = currMember.UseName
            };
        }

        private void btnDetailsAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!isNew)
                current = layoutViewBills.GetRow(layoutViewBills.FocusedRowHandle) as Bill;

            var li = _repBillDetails.Find(dt => dt.BillID == current.ID).ToList();
            li.ForEach(i =>
            {
                i.BillInfo = current;
                i.OrderInfo = _repOrders.Find(or => or.ID == i.OrderID).First();
                i.OrderInfo.CustomerInfo = _repMembers.Find(cus => cus.UseName == i.OrderInfo.CusID).First();
            });
            bindingSource.DataSource = li;
        }


        private void repOrders_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (isNew)
            {
                var detail = e.NewValue as Order;
                for (var i = 0; i < cardViewBillDetails.DataRowCount; i++)
                {
                    var billdetail = cardViewBillDetails.GetRow(i) as BillDetail;
                    if (billdetail.OrderID == detail.ID)
                    {
                        alertControl.Show(this, "Not Correct", "This bill is exited!");
                        e.Cancel = true;                        
                        return;
                    }
                }
                detail.CustomerInfo = _repMembers.Find(mb => mb.UseName == detail.CusID).First();
                cardViewBillDetails.SetRowCellValue(cardViewBillDetails.FocusedRowHandle, "CustomerName", detail.CustomerInfo.FullName);
                cardViewBillDetails.SetRowCellValue(cardViewBillDetails.FocusedRowHandle, "CustomerUse", detail.CusID);
                cardViewBillDetails.SetRowCellValue(cardViewBillDetails.FocusedRowHandle, "OrderID", detail.ID);
                              
            }
            else
            {
                alertControl.Show(this, "Not Correct", "This bill is exited! Don't change it!");
                e.Cancel = true;
            }
        }

        private void repDateRequire_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!isNew)
            {
                e.Cancel = true;
            }
        }

        private void btnDetailsNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            cardViewBillDetails.AddNewRow();
        }

        private void btnDetailsSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            cardViewBillDetails.RefreshData();
            cardViewBillDetails.RefreshData();

            if (current != null && current.ID == 0)
            {
                current.Deleted = false;
                current.ID = _repBills.Add(current);


                for (int i = 0; i < cardViewBillDetails.DataRowCount; i++)
                {
                    var detail = cardViewBillDetails.GetRow(i) as BillDetail;
                    detail.BillID = current.ID;
                    detail.OrderID = detail.OrderInfo.ID;
                    detail.BillInfo = current;

                    _repBillDetails.Add(detail);
                    var order = _repOrders.GetById(detail.OrderID);
                    order.Deleted = true;
                    _repOrders.Update(order);
                }
                repOrders.DataSource = _repOrders.Find(or => or.Deleted == false).ToList();
            }
            else
            {
                MessageBox.Show("This bill is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnDetailsAll.PerformClick();

            isNew = false;
            btnDetailsNew.Enabled = false;
            btnShowBills.Enabled = true;
            btnDetailsSave.Enabled = false;
        }

        private void layoutViewBills_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var view = sender as LayoutView;
            var col = view.Columns["CusID"];
            string cusId = view.GetRowCellValue(layoutViewBills.FocusedRowHandle, "CusID") as string;
            if (cusId == null || String.IsNullOrEmpty(cusId.Trim()))
            {
                e.Valid = false;
                view.SetColumnError(col, "Please choose customer!");
            }
        }

        private void layoutViewBills_BeforeLeaveRow(object sender, RowAllowEventArgs e)
        {
            if (layoutViewBills.IsNewItemRow(layoutViewBills.FocusedRowHandle))
            {

                if (MessageBox.Show("Do you want to save this new bill?", "Quession", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ribbonPageFind.Visible = false;
                    if (gridControl.MainView != cardViewBillDetails)
                    {
                        bindingSource.DataSource = _repBillDetails.Find(dt => dt.BillID == -1).ToList();

                        ribbonPageGroupDetailOptions.Visible = true;
                        btnDetailsAll.Enabled = false;
                        btnDetailsSave.Enabled = false;
                        btnShowDetails.Enabled = false;

                        gridControl.MainView = cardViewBillDetails;
                        ribbonPageGroupFile.Visible = false;
                    }
                    isNew = true;
                }
                else
                {
                    btnAll.PerformClick();
                }
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var bill = layoutViewBills.GetRow(layoutViewBills.FocusedRowHandle) as Bill;
            if (bill.Deleted)
                return;
            bill.Deleted = true;
            _repBills.Update(bill);
            btnAll.PerformClick();
        }

        private void btnPrinter_ItemClick(object sender, ItemClickEventArgs e)
        {
            var bill = layoutViewBills.GetRow(layoutViewBills.FocusedRowHandle) as Bill;
            if (bill.CusInfo == null)
                bill.CusInfo = _repMembers.GetByUseName(bill.CusID);
            if (bill.SelerInfo == null)
                bill.SelerInfo = _repMembers.GetByUseName(bill.SelID);
            var listDetails = _repBillDetails.Find(dt => dt.BillID == bill.ID).ToList();
            var listOrders = new List<Order>();
            listDetails.ForEach(i =>
            {
                var temp = _repOrders.GetById(i.OrderID);
                temp.CustomerInfo = _repMembers.GetByUseName(temp.CusID);
                listOrders.Add(temp);
            });

            listOrders.ForEach(i =>
            {
                i.CustomerInfo = _repMembers.GetByUseName(i.CusID);
                i.DetailsInfo = _repOrderDetails.Find(dt => dt.OrderID == i.ID).ToList();
                i.DetailsInfo.ForEach(j =>
                {
                    j.ProductInfo = _repProducts.GetById(j.ProID);
                });
            });



            var printer = new XtraReportBill(bill, listOrders);
            printer.ShowPreview();
        }

        private void layoutViewBills_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var temp = layoutViewBills.GetRow(layoutViewBills.FocusedRowHandle) as Bill;
            if (!bills.Contains(temp))
                bills.Add(temp);
            else
            {
                Bill t = bills.Find(b => b.ID == temp.ID);
                t = temp;
            }
            btnSave.Enabled = true;
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            bills.ForEach(i =>
            {
                _repBills.Update(i);
            });
            bills.Clear();
            btnSave.Enabled = false;
        }

        private void cardViewBillDetails_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            GridColumn col = view.Columns["OrderInfo"];
            Order temp = (Order)view.GetRowCellValue(e.RowHandle, col);
            if (temp == null)
            {
                e.Valid = false;
                view.SetColumnError(col, "Please choose Order!");
                btnDetailsSave.Enabled = false;
            }
            else
            {
                btnDetailsSave.Enabled = true;
            }
        }

        private void btnShowSeller_ItemClick(object sender, ItemClickEventArgs e)
        {
            var bl = layoutViewBills.GetRow(layoutViewBills.FocusedRowHandle) as Bill;
            using (MemberListForm frm = new MemberListForm())
            {
                frm.SenMemberSelected(bl.SelID);
                frm.ShowDialog();
            }
        }

        private void bntShowCus_ItemClick(object sender, ItemClickEventArgs e)
        {
            var bl = layoutViewBills.GetRow(layoutViewBills.FocusedRowHandle) as Bill;
            using (MemberListForm frm = new MemberListForm())
            {
                frm.SenMemberSelected(bl.CusID);
                frm.ShowDialog();
            }
        }

        private void edtCusName_EditValueChanged(object sender, EventArgs e)
        {
            var li = _repBills.GetAll().ToList();
            var list = new List<Bill>();
            li.ForEach(i =>
            {
                i.CusInfo = _repMembers.Find(m => m.UseName == i.CusID).First();
                i.CusName = i.CusInfo.FullName;
                if (i.CusName.ToLower().Contains(edtCusName.EditValue.ToString().ToLower()))
                    list.Add(i);
            });
            
            list.ForEach(i =>
            {
                i.SelerInfo = _repMembers.Find(m => m.UseName == i.SelID).First();
                i.SalerName = i.SelerInfo.FullName;
            });
            bindingSource.DataSource = list;
        }

        private void edtCusUse_EditValueChanged(object sender, EventArgs e)
        {
            var li = _repBills.Find(b=>b.CusID.ToLower().Contains(edtCusUse.EditValue.ToString().ToLower())).ToList();
            li.ForEach(i =>
            {
                i.CusInfo = _repMembers.Find(m => m.UseName == i.CusID).First();
                i.CusName = i.CusInfo.FullName;
            });

            li.ForEach(i =>
            {
                i.SelerInfo = _repMembers.Find(m => m.UseName == i.SelID).First();
                i.SalerName = i.SelerInfo.FullName;
            });
            bindingSource.DataSource = li;
        }

        private void edtSelUse_EditValueChanged(object sender, EventArgs e)
        {
            var li = _repBills.Find(b => b.SelID.ToLower().Contains(edtSelUse.EditValue.ToString().ToLower())).ToList();
            li.ForEach(i =>
            {
                i.CusInfo = _repMembers.Find(m => m.UseName == i.CusID).First();
                i.CusName = i.CusInfo.FullName;
            });

            li.ForEach(i =>
            {
                i.SelerInfo = _repMembers.Find(m => m.UseName == i.SelID).First();
                i.SalerName = i.SelerInfo.FullName;
            });
            bindingSource.DataSource = li;
        }

        private void edtSelName_EditValueChanged(object sender, EventArgs e)
        {
            var li = _repBills.GetAll().ToList();
            var list = new List<Bill>();
            li.ForEach(i =>
            {
                i.CusInfo = _repMembers.Find(m => m.UseName == i.CusID).First();
                i.CusName = i.CusInfo.FullName;
                i.SelerInfo = _repMembers.Find(m => m.UseName == i.SelID).First();
                i.SalerName = i.SelerInfo.FullName;
                if (i.SalerName.ToLower().Contains(edtSelName.EditValue.ToString().ToLower()))
                    list.Add(i);
            });
            bindingSource.DataSource = list;
        }
            
                

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Entities;
using Entities.IRepository;
using DAL.SqlServer;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraLayout.Utils;
using BLL;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

namespace MobilesApplication.Salers
{
    public partial class OrderListForm : Office2007Form
    {
        private Member currMember;
        private IGeneralRepository<Product> _repProducts;
        private IGeneralRepository<Order> _repOrders;
        private IGeneralRepository<OrderDetail> _repOrderDetails;
        private MemberRepository _repMember;

        private OrderManager _orderManager;
        private OrderDetialManager _orderDetailManager;
        private MemberManager _memberManger;

        private Order _orderCurrent;

        private delegate void LoginMember(Member mb);
        private LoginMember Login;

        public OrderListForm()
        {
            InitializeComponent();
            DesignProductView();
            DesignLayoutViewOrderDetails();
            Login = setMember;
        }

        public void setMember(Member mb)
        {
            currMember = mb;
        }
        
        private void OrderListForm_Load(object sender, EventArgs e)
        {
            _repMember = new MemberRepository();
            _repOrders = new GeneralRepository<Order>();
            _repOrderDetails = new GeneralRepository<OrderDetail>();
            _orderManager = new OrderManager(_repOrders);
            _orderDetailManager = new OrderDetialManager(_repOrderDetails);
            _repProducts = new GeneralRepository<Product>();
            _memberManger = new MemberManager(_repMember);
            btnRefreshPro.PerformClick();

            DefualtOrder();
        }

        private void DefualtOrder()
        {
            _orderCurrent = new Order { ID = 0, CusID = currMember.UseName, 
                DateRequire = DateTime.Today, CustomerInfo = currMember, 
                Deleted=false, DetailsInfo = new List<OrderDetail>() };
        }

        private void DesignProductView()
        {
            // Access corresponding card fields.
            LayoutViewField fieldProName = colProName.LayoutViewField;
            LayoutViewField fieldProQuantity = colProQuantity.LayoutViewField;
            LayoutViewField fieldProType = colProType.LayoutViewField;
            LayoutViewField fieldProPrice = colProPrice.LayoutViewField;
            LayoutViewField fieldProUnitPrice = colProUnitPrice.LayoutViewField;
            LayoutViewField fieldProImage = colProImage.LayoutViewField;
            //LayoutViewField fieldProDescription = colProDescription.LayoutViewField;

            // Position the FirstName field to the right of the Photo field.
            fieldProName.Move(new LayoutItemDragController(fieldProName, fieldProImage,
                InsertLocation.After, LayoutType.Horizontal));
            // Position the LastName field below the FirstName field.
            fieldProQuantity.Move(new LayoutItemDragController(fieldProQuantity, fieldProName,
                InsertLocation.After, LayoutType.Vertical));
            fieldProType.Move(new LayoutItemDragController(fieldProType, fieldProQuantity,
                InsertLocation.After, LayoutType.Vertical));
            fieldProPrice.Move(new LayoutItemDragController(fieldProPrice, fieldProType,
                InsertLocation.After, LayoutType.Vertical));
            fieldProUnitPrice.Move(new LayoutItemDragController(fieldProUnitPrice, fieldProPrice,
                InsertLocation.After, LayoutType.Vertical));
            //fieldProDescription.Move(new LayoutItemDragController(fieldProDescription, fieldProUnitPrice,
            //   InsertLocation.After, LayoutType.Vertical));
        }

        private void DesignLayoutViewOrderDetails()
        {
            // Access corresponding card fields.
            LayoutViewField fieldUnit = colOrderDetailsUnit.LayoutViewField;
            LayoutViewField fieldProName = colOrderDetailsProductName.LayoutViewField;
            LayoutViewField fieldProImage = colOrderDetailsProductImage.LayoutViewField;
            LayoutViewField fieldProtype = colOrderDetailsType.LayoutViewField;
            LayoutViewField fieldPrice = colOrderDetailsPrice.LayoutViewField;
            
            fieldUnit.Move(new LayoutItemDragController(fieldUnit, fieldProImage,
                InsertLocation.After, LayoutType.Horizontal));

            fieldProName.Move(new LayoutItemDragController(fieldProName, fieldUnit,
                InsertLocation.After, LayoutType.Vertical));
            fieldProtype.Move(new LayoutItemDragController(fieldProtype, fieldProName,
                InsertLocation.After, LayoutType.Vertical));
            fieldPrice.Move(new LayoutItemDragController(fieldPrice, fieldProtype,
                InsertLocation.After, LayoutType.Vertical));
        }
        
        private void layoutViewProducts_CustomDrawCardFieldValue(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column != colProImage) return;
            string cellValue = layoutViewProducts.GetRowCellDisplayText(e.RowHandle, colProImage);
            //if (cellValue == null) return;
            string originalPath = @"images/" + (String.IsNullOrEmpty(cellValue) ? "NoImage.png" : cellValue);
            Image tempImage = Image.FromFile(originalPath);
            e.Graphics.DrawImage(tempImage, e.Bounds.X-82,
                    e.Bounds.Y+15, e.Bounds.Height+110, e.Bounds.Height +110);
            return;
        }

        private void layoutViewOrderDetails_CustomDrawCardFieldValue(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column != colOrderDetailsProductImage) return;
            string cellValue = layoutViewProducts.GetRowCellDisplayText(e.RowHandle, colProImage);
            //if (cellValue == null) return;
            string originalPath = @"images/" + (String.IsNullOrEmpty(cellValue) ? "NoImage.png" : cellValue);
            Image tempImage = Image.FromFile(originalPath);
            e.Graphics.DrawImage(tempImage, e.Bounds.X - 40,
                    e.Bounds.Y + 15, e.Bounds.Height + 55, e.Bounds.Height + 55);
            return;
        }

        private void btnRefreshPro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridProducts.DataSource = _repProducts.GetAll().ToList();
        }

        private void btnNewOrderDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            proList.Clear();
            proListOrder.Clear();
            layoutViewOrderDetails.RefreshData();
            layoutViewOrderDetails_View();
            layoutViewOrderDetails.RefreshData();
            DefualtOrder();
        }


        private List<Product> proList = new List<Product>();
        private List<OrderDetailProduct> proListOrder = new List<OrderDetailProduct>();
        private OrderDetailProduct proNew;
        private void requireOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product temp = layoutViewProducts.GetRow(layoutViewProducts.FocusedRowHandle) as Product;
           
            if (proList.Contains(temp))
            {
                MessageBox.Show("This product had been exited in your card!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            proList.Add(temp);
            proNew = new OrderDetailProduct
            {
                ID = temp.ID,
                Name = temp.Name,
                Image = temp.Image,
                Price = temp.Price,
                Type = temp.Type,
                Description = temp.Description,
                UnitPrice = temp.UnitPrice,
                Unit = 1
            };
            proListOrder.Add(proNew);
            
            //btnNewOrderDetail.PerformClick();
            layoutViewOrderDetails.RefreshData();
            layoutViewOrderDetails_View();
            layoutViewOrderDetails.RefreshData();
        }


        private void layoutViewOrderDetails_View()
        {
            bindingSource.DataSource = proListOrder;            
        }

        private void layoutViewOrderDetails_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            GridColumn col = view.Columns["Unit"];
            int temp = (int)view.GetRowCellValue(e.RowHandle, col);
            if (temp < 1)
            {
                e.Valid = false;
                view.SetColumnError(col, "Unit is not accepted less than 1!");
            }

            int quantity = (int)view.GetRowCellValue(e.RowHandle, view.Columns["Quantity"]);
            if (temp > quantity)
            {
                e.Valid = false;
                view.SetColumnError(col, "Unit is not accepted less than product's quantity!");
            }
        }

        private void layoutViewOrderDetails_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }


        private void btnOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (layoutViewOrderDetails.DataRowCount <= 0)
            {
                MessageBox.Show("This order is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_orderCurrent == null)
                DefualtOrder();
            string message = _orderManager.InsertOrUpdate(_orderCurrent).GetErrorMessages();
            if(message.Length > 0)
                MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (_orderCurrent.ID > 0)
            {
                message = _orderDetailManager.Delete(_orderCurrent.ID).GetErrorMessages();
                if (message.Length > 0)
                    MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _orderCurrent.ID = _orderManager.Find(od => od.CusID == _orderCurrent.CusID
                && od.Deleted == false).Result.Last().ID;
            for (int i = 0; i < layoutViewOrderDetails.DataRowCount; i++)
            {
                OrderDetailProduct temp = layoutViewOrderDetails.GetRow(i) as OrderDetailProduct;
                for (int j = 1; j <= temp.Unit; j++)
                {
                    OrderDetail newElement = new OrderDetail {ProID = temp.ID, OrderID = _orderCurrent.ID };
                    message = _orderDetailManager.Insert(newElement).GetErrorMessages();
                    if (message.Length > 0)
                        MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnRefreshPro.PerformClick();
        }

        private void btnAddYourCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            requireOrderToolStripMenuItem.PerformClick();
        }

        private void btnDeleteFromCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OrderDetailProduct element = layoutViewOrderDetails.GetRow(layoutViewOrderDetails.FocusedRowHandle) as OrderDetailProduct;
            layoutViewOrderDetails.DeleteRow(layoutViewOrderDetails.FocusedRowHandle);
            for (int i = 0; i < proList.Count; i++)
            {
                if (proList[i].ID == element.ID)
                {
                    proList.RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < proListOrder.Count; i++)
            {
                if (proList[i].ID == element.ID)
                {
                    proListOrder.RemoveAt(i);
                    break;
                }
            }
        }

        private void btnPrinter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReportOder frm = new XtraReportOder(currMember, proListOrder);
            frm.ShowPreview();
        }

        private void btnShowCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridOrders.MainView != layoutViewCustomer)
            {
                bindingSourceMember.DataSource = _repMember.GetByUseName(currMember.UseName);
                gridOrders.DataSource = bindingSourceMember;
                gridOrders.MainView = layoutViewCustomer;
                btnShowCustomer.Caption = "Show My card";
            }
            else
            {
                gridOrders.DataSource = bindingSource;
                gridOrders.MainView = layoutViewOrderDetails;
                btnShowCustomer.Caption = "Show My Info";
            }
        }

        private void repCities_Click(object sender, EventArgs e)
        {

        }

        private void repPassword_Click(object sender, EventArgs e)
        {
            using (ChangePassWordForm frm = new ChangePassWordForm())
            {
                frm.setPassword(currMember.PassWord);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    layoutViewCustomer.SetRowCellValue(layoutViewCustomer.FocusedRowHandle, colMemberPasswords, frm.pass);
                }
            }
        }

        private void repPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void layoutViewCustomer_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            GridColumn col = view.Columns["UseName"];
            string temp = (string)view.GetRowCellValue(e.RowHandle, col);

            if (temp == null || temp.Length <= 4)
            {
                e.Valid = false;
                view.SetColumnError(col, "The usename's length must be more 4 character!");
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

            Member m = layoutViewCustomer.GetRow(e.RowHandle) as Member;

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

            
            if (e.Valid == false)
                btnSaveMyInfo.Enabled = false;
            else
                btnSaveMyInfo.Enabled = true;
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

        private void layoutViewCustomer_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void btnSaveMyInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Member temp = layoutViewCustomer.GetRow(layoutViewCustomer.FocusedRowHandle) as Member;
            string s = _memberManger.InsertOrUpdate(temp).GetErrorMessages();
            if (s.Length > 0)
            {
                MessageBox.Show(this, s, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            currMember = temp;
            MessageBox.Show("Updating your accout is successfull!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSaveMyInfo.Enabled = false;
        }

        private void bedId_EditValueChanged(object sender, EventArgs e)
        {
            if (bedId.EditValue.ToString().Equals(string.Empty))
            {
                btnRefreshPro.PerformClick();
                return;
            }
            try
            {
                int id = int.Parse(bedId.EditValue.ToString());
                gridProducts.DataSource = _repProducts.Find(p => p.ID == id).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bedName_EditValueChanged(object sender, EventArgs e)
        {
            if (bedName.EditValue.ToString().Equals(string.Empty))
            {
                btnRefreshPro.PerformClick();
                return;
            }
            try
            {
                gridProducts.DataSource = _repProducts.Find(p => p.Name.ToLower().Contains(bedName.EditValue.ToString().ToLower())).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bedPrice_EditValueChanged(object sender, EventArgs e)
        {
            if (bedPrice.EditValue.ToString().Equals(string.Empty))
            {
                btnRefreshPro.PerformClick();
                return;
            }
            try
            {
                decimal price = decimal.Parse(bedPrice.EditValue.ToString());
                gridProducts.DataSource = _repProducts.Find(p => p.Price <= price).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bckitemOther_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bckitemOther.Checked)
            {
                gridProducts.DataSource = _repProducts.Find(p => p.Type == false).ToList();
            }
            else
            {
                btnRefreshPro.PerformClick();
            }
        }

       
        
    }

    public class OrderDetailProduct:Product
    {
        public int Unit { get; set; }
    }
}

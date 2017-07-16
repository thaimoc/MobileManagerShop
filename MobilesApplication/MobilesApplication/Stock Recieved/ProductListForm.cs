using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using Entities;
using Entities.IRepository;
using BLL;
using DAL.SqlServer;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using Alias = System.Windows.Forms;
using DevExpress.XtraCharts;

namespace MobilesApplication.Stock_Recieved
{
    public partial class ProductListForm : Office2007Form
    {
        private Member currMember;
        private IGeneralRepository<Product> _repository;
        private ProductManager _manager;
        public delegate void SendMember(Member mb);
        private readonly SendMember SetMember;

        public ProductListForm()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinRegistrator.Register();
            SkinHelper.InitSkinGallery(Skins);
            SetMember = SetCurrentMember;
        }

        public void SetCurrentMember(Member mb)
        {
            currMember = mb;
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            if (currMember != null && currMember.CategoryMemberID == 1)
            {
                rbpFile.Visible = true;
                gridControl.UseEmbeddedNavigator = true;
            }
            _repository = new GeneralRepository<Product>();
            _manager = new ProductManager(_repository);
            btnAll.PerformClick();
        }

        private void btnAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            productbindingSource.DataSource = _repository.GetAll().ToList();
        }

        private void gridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            GridColumn col = view.Columns["Name"];
            bool save = true;
            string temp = (string)view.GetRowCellValue(e.RowHandle, col);
            if (temp == null || String.IsNullOrEmpty(temp.Trim()))
            {
                e.Valid = false;
                view.SetColumnError(col, "Product's name is not accepted null or empty!");
                save = false;
            }

            if(newRow && temp != null && _repository.Find(p=>p.Name.ToLower() == temp.ToLower()).ToList().Count > 1)
            {
                e.Valid = false;
                view.SetColumnError(col, "Product's name is exited!");                
                save = false;
            }

            col = view.Columns["Quantity"];
            int quantity = (int)view.GetRowCellValue(e.RowHandle, col);
            if (quantity == null || quantity < 0)
            {
                e.Valid = false;
                view.SetColumnError(col, "Product's quantiry is not accepted less than zezo!");
                save = false;
            }

            col = view.Columns["Type"];
            bool type = (bool)view.GetRowCellValue(e.RowHandle, col);
            if (type == null)
            {
                e.Valid = false;
                view.SetColumnError(col, "Product's type is not accepted null!");
                save = false;
            }

            col = view.Columns["Price"];
            decimal price = (decimal)view.GetRowCellValue(e.RowHandle, col);
            if (price == null || price < 0)
            {
                e.Valid = false;
                view.SetColumnError(col, "Product's price is not accepted less than zezo!");
                save = false;
            }
            btnSave.Enabled = save;
        }

        private void gridView_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
        bool newRow = false;
        private void gridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["Quantity"], 0);
            view.SetRowCellValue(e.RowHandle, view.Columns["Price"], 0);
            view.SetRowCellValue(e.RowHandle, view.Columns["Type"], true);
            newRow = true;
            btnSave.Enabled = true;
        }

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView.AddNewRow();
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                Product temp = gridView.GetRow(i) as Product;

                string message = _manager.InsertOrUpdate(temp).GetErrorMessages();
                if (message.Length > 0) MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnSave.Enabled = false;
        }

        private void repImages_Click(object sender, EventArgs e)
        {
            DialogResult dlg = openFileDialog.ShowDialog();
            if (dlg == Alias.DialogResult.OK)
            {
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "Image", openFileDialog.FileName.Substring(1 + openFileDialog.FileName.LastIndexOf('\\')));
            }
        }

        private void gridView_CustomDrawRowPreview(object sender, RowObjectCustomDrawEventArgs e)
        {
            const int dx = 8;
            Rectangle r = e.Bounds;
            r.X += e.Bounds.Height + dx + 2;
            r.Width -= (e.Bounds.Height + dx + 3);
            string file = (string)gridView.GetRowCellValue(e.RowHandle, "Image");
            string originalPath = @"images/" + (String.IsNullOrEmpty(file)? "NoImage.png" : file);
            Image tempImage = Image.FromFile(originalPath);

            e.Graphics.DrawImage(tempImage, e.Bounds.X + dx,
                    e.Bounds.Y, e.Bounds.Height, e.Bounds.Height );
            e.Appearance.DrawString(e.Cache, gridView.GetRowPreviewDisplayText(e.RowHandle), r);
            e.Handled = true;
        }

        private void btnPrinter_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraReportProducts rpot = new XtraReportProducts(_repository);
            rpot.ShowPreview();
        }

        private void btnChartColumn_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (ColumnsChartProductListForm frm = new ColumnsChartProductListForm(ViewType.Bar))
            {
                frm.ShowDialog();
            }
        }

        private void btnChartPie_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (ColumnsChartProductListForm frm = new ColumnsChartProductListForm(ViewType.Pie3D))
            {
                frm.ShowDialog();
            }
        }

        private void btnChartWave_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (ColumnsChartProductListForm frm = new ColumnsChartProductListForm(ViewType.Area))
            {
                frm.ShowDialog();
            }
        }

        private void bntVawe_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (ColumnsChartProductListForm frm = new ColumnsChartProductListForm(ViewType.Line))
            {
                frm.ShowDialog();
            }
        } 




    }
}

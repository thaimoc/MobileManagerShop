namespace MobilesApplication.Salers
{
    partial class BillListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillListForm));
            this.cardViewBillDetails = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colBillOrderDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillDetailsOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillOrdedetailCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillDetailCustomerUse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillDetailsDateRequire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillDetailChooseOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repOrders = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutViewBills = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colBill = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBillCusID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBillsSalerID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBillRequireDate = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repDateRequire = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.layoutViewField_layoutViewColumn4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBillDeleted = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn5 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBillCusName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBillSalerName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBillChangeCustomer = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repCustomers = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutViewField_layoutViewColumn1_3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAll = new DevExpress.XtraBars.BarButtonItem();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrinter = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowDetails = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowBills = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetailsAll = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetailsNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetailsSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowSeller = new DevExpress.XtraBars.BarButtonItem();
            this.bntShowCus = new DevExpress.XtraBars.BarButtonItem();
            this.Skins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.edtCusName = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.edtCusUse = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.edtSelUse = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.edtSelName = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupFile = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupDetailOptions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageFind = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.alertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cardViewBillDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateRequire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateRequire.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // cardViewBillDetails
            // 
            this.cardViewBillDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillOrderDetails,
            this.colBillDetailsOrderID,
            this.colBillOrdedetailCustomerName,
            this.colBillDetailCustomerUse,
            this.colBillDetailsDateRequire,
            this.colBillDetailChooseOrder});
            this.cardViewBillDetails.FocusedCardTopFieldIndex = 0;
            this.cardViewBillDetails.GridControl = this.gridControl;
            this.cardViewBillDetails.Name = "cardViewBillDetails";
            this.cardViewBillDetails.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.cardViewBillDetails_ValidateRow);
            // 
            // colBillOrderDetails
            // 
            this.colBillOrderDetails.Caption = "Bill ID";
            this.colBillOrderDetails.FieldName = "BillID";
            this.colBillOrderDetails.Name = "colBillOrderDetails";
            this.colBillOrderDetails.Visible = true;
            this.colBillOrderDetails.VisibleIndex = 0;
            // 
            // colBillDetailsOrderID
            // 
            this.colBillDetailsOrderID.Caption = "Order ID";
            this.colBillDetailsOrderID.FieldName = "OrderID";
            this.colBillDetailsOrderID.Name = "colBillDetailsOrderID";
            this.colBillDetailsOrderID.Visible = true;
            this.colBillDetailsOrderID.VisibleIndex = 1;
            // 
            // colBillOrdedetailCustomerName
            // 
            this.colBillOrdedetailCustomerName.Caption = "Customer Name";
            this.colBillOrdedetailCustomerName.FieldName = "CustomerName";
            this.colBillOrdedetailCustomerName.Name = "colBillOrdedetailCustomerName";
            this.colBillOrdedetailCustomerName.Visible = true;
            this.colBillOrdedetailCustomerName.VisibleIndex = 2;
            // 
            // colBillDetailCustomerUse
            // 
            this.colBillDetailCustomerUse.Caption = "Customer Use";
            this.colBillDetailCustomerUse.FieldName = "CustomerUse";
            this.colBillDetailCustomerUse.Name = "colBillDetailCustomerUse";
            this.colBillDetailCustomerUse.Visible = true;
            this.colBillDetailCustomerUse.VisibleIndex = 3;
            // 
            // colBillDetailsDateRequire
            // 
            this.colBillDetailsDateRequire.Caption = "Require Date";
            this.colBillDetailsDateRequire.FieldName = "DateRequire";
            this.colBillDetailsDateRequire.Name = "colBillDetailsDateRequire";
            this.colBillDetailsDateRequire.Visible = true;
            this.colBillDetailsDateRequire.VisibleIndex = 4;
            // 
            // colBillDetailChooseOrder
            // 
            this.colBillDetailChooseOrder.Caption = "Change Order";
            this.colBillDetailChooseOrder.ColumnEdit = this.repOrders;
            this.colBillDetailChooseOrder.FieldName = "OrderInfo";
            this.colBillDetailChooseOrder.Name = "colBillDetailChooseOrder";
            this.colBillDetailChooseOrder.Visible = true;
            this.colBillDetailChooseOrder.VisibleIndex = 5;
            // 
            // repOrders
            // 
            this.repOrders.AutoHeight = false;
            this.repOrders.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repOrders.Name = "repOrders";
            this.repOrders.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repOrders_EditValueChanging);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.cardViewBillDetails;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl.Location = new System.Drawing.Point(0, 143);
            this.gridControl.MainView = this.layoutViewBills;
            this.gridControl.MenuManager = this.ribbonControl1;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCustomers,
            this.repOrders,
            this.repDateRequire});
            this.gridControl.Size = new System.Drawing.Size(937, 323);
            this.gridControl.TabIndex = 3;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutViewBills,
            this.cardViewBillDetails});
            // 
            // layoutViewBills
            // 
            this.layoutViewBills.CardMinSize = new System.Drawing.Size(323, 200);
            this.layoutViewBills.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colBill,
            this.colBillCusID,
            this.colBillsSalerID,
            this.colBillRequireDate,
            this.colBillDeleted,
            this.colBillCusName,
            this.colBillSalerName,
            this.colBillChangeCustomer});
            this.layoutViewBills.GridControl = this.gridControl;
            this.layoutViewBills.Name = "layoutViewBills";
            this.layoutViewBills.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            this.layoutViewBills.TemplateCard = this.layoutViewCard1;
            this.layoutViewBills.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.layoutViewBills_CellValueChanged);
            this.layoutViewBills.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.layoutViewBills_BeforeLeaveRow);
            this.layoutViewBills.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.layoutViewBills_ValidateRow);
            // 
            // colBill
            // 
            this.colBill.Caption = "ID";
            this.colBill.FieldName = "ID";
            this.colBill.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.colBill.Name = "colBill";
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 185;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(303, 20);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(109, 13);
            this.layoutViewField_layoutViewColumn1.TextToControlDistance = 5;
            // 
            // colBillCusID
            // 
            this.colBillCusID.Caption = "Cusmtomer Use Name";
            this.colBillCusID.FieldName = "CusID";
            this.colBillCusID.LayoutViewField = this.layoutViewField_layoutViewColumn2;
            this.colBillCusID.Name = "colBillCusID";
            this.colBillCusID.OptionsColumn.AllowEdit = false;
            // 
            // layoutViewField_layoutViewColumn2
            // 
            this.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 185;
            this.layoutViewField_layoutViewColumn2.Location = new System.Drawing.Point(0, 20);
            this.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2";
            this.layoutViewField_layoutViewColumn2.Size = new System.Drawing.Size(303, 20);
            this.layoutViewField_layoutViewColumn2.TextSize = new System.Drawing.Size(109, 13);
            this.layoutViewField_layoutViewColumn2.TextToControlDistance = 5;
            // 
            // colBillsSalerID
            // 
            this.colBillsSalerID.Caption = "Saler Use Name";
            this.colBillsSalerID.FieldName = "SelID";
            this.colBillsSalerID.LayoutViewField = this.layoutViewField_layoutViewColumn3;
            this.colBillsSalerID.Name = "colBillsSalerID";
            this.colBillsSalerID.OptionsColumn.AllowEdit = false;
            // 
            // layoutViewField_layoutViewColumn3
            // 
            this.layoutViewField_layoutViewColumn3.EditorPreferredWidth = 185;
            this.layoutViewField_layoutViewColumn3.Location = new System.Drawing.Point(0, 40);
            this.layoutViewField_layoutViewColumn3.Name = "layoutViewField_layoutViewColumn3";
            this.layoutViewField_layoutViewColumn3.Size = new System.Drawing.Size(303, 20);
            this.layoutViewField_layoutViewColumn3.TextSize = new System.Drawing.Size(109, 13);
            this.layoutViewField_layoutViewColumn3.TextToControlDistance = 5;
            // 
            // colBillRequireDate
            // 
            this.colBillRequireDate.Caption = "Require Date";
            this.colBillRequireDate.ColumnEdit = this.repDateRequire;
            this.colBillRequireDate.FieldName = "RequireDate";
            this.colBillRequireDate.LayoutViewField = this.layoutViewField_layoutViewColumn4;
            this.colBillRequireDate.Name = "colBillRequireDate";
            this.colBillRequireDate.OptionsColumn.AllowEdit = false;
            // 
            // repDateRequire
            // 
            this.repDateRequire.AutoHeight = false;
            this.repDateRequire.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDateRequire.Name = "repDateRequire";
            this.repDateRequire.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repDateRequire.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repDateRequire_EditValueChanging);
            // 
            // layoutViewField_layoutViewColumn4
            // 
            this.layoutViewField_layoutViewColumn4.EditorPreferredWidth = 185;
            this.layoutViewField_layoutViewColumn4.Location = new System.Drawing.Point(0, 60);
            this.layoutViewField_layoutViewColumn4.Name = "layoutViewField_layoutViewColumn4";
            this.layoutViewField_layoutViewColumn4.Size = new System.Drawing.Size(303, 20);
            this.layoutViewField_layoutViewColumn4.TextSize = new System.Drawing.Size(109, 13);
            this.layoutViewField_layoutViewColumn4.TextToControlDistance = 5;
            // 
            // colBillDeleted
            // 
            this.colBillDeleted.Caption = "Deleted";
            this.colBillDeleted.FieldName = "Deleted";
            this.colBillDeleted.LayoutViewField = this.layoutViewField_layoutViewColumn5;
            this.colBillDeleted.Name = "colBillDeleted";
            // 
            // layoutViewField_layoutViewColumn5
            // 
            this.layoutViewField_layoutViewColumn5.EditorPreferredWidth = 185;
            this.layoutViewField_layoutViewColumn5.Location = new System.Drawing.Point(0, 80);
            this.layoutViewField_layoutViewColumn5.Name = "layoutViewField_layoutViewColumn5";
            this.layoutViewField_layoutViewColumn5.Size = new System.Drawing.Size(303, 20);
            this.layoutViewField_layoutViewColumn5.TextSize = new System.Drawing.Size(109, 13);
            this.layoutViewField_layoutViewColumn5.TextToControlDistance = 5;
            // 
            // colBillCusName
            // 
            this.colBillCusName.Caption = "Customer Name";
            this.colBillCusName.FieldName = "CusName";
            this.colBillCusName.LayoutViewField = this.layoutViewField_layoutViewColumn1_1;
            this.colBillCusName.Name = "colBillCusName";
            this.colBillCusName.OptionsColumn.AllowEdit = false;
            // 
            // layoutViewField_layoutViewColumn1_1
            // 
            this.layoutViewField_layoutViewColumn1_1.EditorPreferredWidth = 185;
            this.layoutViewField_layoutViewColumn1_1.Location = new System.Drawing.Point(0, 100);
            this.layoutViewField_layoutViewColumn1_1.Name = "layoutViewField_layoutViewColumn1_1";
            this.layoutViewField_layoutViewColumn1_1.Size = new System.Drawing.Size(303, 20);
            this.layoutViewField_layoutViewColumn1_1.TextSize = new System.Drawing.Size(109, 13);
            this.layoutViewField_layoutViewColumn1_1.TextToControlDistance = 5;
            // 
            // colBillSalerName
            // 
            this.colBillSalerName.Caption = "Saler Name";
            this.colBillSalerName.FieldName = "SalerName";
            this.colBillSalerName.LayoutViewField = this.layoutViewField_layoutViewColumn1_2;
            this.colBillSalerName.Name = "colBillSalerName";
            this.colBillSalerName.OptionsColumn.AllowEdit = false;
            // 
            // layoutViewField_layoutViewColumn1_2
            // 
            this.layoutViewField_layoutViewColumn1_2.EditorPreferredWidth = 185;
            this.layoutViewField_layoutViewColumn1_2.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_layoutViewColumn1_2.Name = "layoutViewField_layoutViewColumn1_2";
            this.layoutViewField_layoutViewColumn1_2.Size = new System.Drawing.Size(303, 20);
            this.layoutViewField_layoutViewColumn1_2.TextSize = new System.Drawing.Size(109, 13);
            this.layoutViewField_layoutViewColumn1_2.TextToControlDistance = 5;
            // 
            // colBillChangeCustomer
            // 
            this.colBillChangeCustomer.Caption = "ChangeCustomer";
            this.colBillChangeCustomer.ColumnEdit = this.repCustomers;
            this.colBillChangeCustomer.FieldName = "CustomerInfo";
            this.colBillChangeCustomer.LayoutViewField = this.layoutViewField_layoutViewColumn1_3;
            this.colBillChangeCustomer.Name = "colBillChangeCustomer";
            // 
            // repCustomers
            // 
            this.repCustomers.AutoHeight = false;
            this.repCustomers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCustomers.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UseName", 70, "Customer Use"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CusName", 70, "Customer Name")});
            this.repCustomers.Name = "repCustomers";
            this.repCustomers.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repCustomers_EditValueChanging);
            // 
            // layoutViewField_layoutViewColumn1_3
            // 
            this.layoutViewField_layoutViewColumn1_3.EditorPreferredWidth = 185;
            this.layoutViewField_layoutViewColumn1_3.Location = new System.Drawing.Point(0, 140);
            this.layoutViewField_layoutViewColumn1_3.Name = "layoutViewField_layoutViewColumn1_3";
            this.layoutViewField_layoutViewColumn1_3.Size = new System.Drawing.Size(303, 20);
            this.layoutViewField_layoutViewColumn1_3.TextSize = new System.Drawing.Size(109, 13);
            this.layoutViewField_layoutViewColumn1_3.TextToControlDistance = 5;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_layoutViewColumn2,
            this.layoutViewField_layoutViewColumn3,
            this.layoutViewField_layoutViewColumn4,
            this.layoutViewField_layoutViewColumn5,
            this.layoutViewField_layoutViewColumn1_1,
            this.layoutViewField_layoutViewColumn1_2,
            this.layoutViewField_layoutViewColumn1_3});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnAll,
            this.btnNew,
            this.btnSave,
            this.btnDelete,
            this.btnPrinter,
            this.btnShowDetails,
            this.btnShowBills,
            this.btnDetailsAll,
            this.btnDetailsNew,
            this.btnDetailsSave,
            this.btnShowSeller,
            this.bntShowCus,
            this.Skins,
            this.edtCusName,
            this.edtCusUse,
            this.edtSelUse,
            this.edtSelName});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 20;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPageFind});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemTextEdit5});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(937, 143);
            // 
            // btnAll
            // 
            this.btnAll.Caption = "All";
            this.btnAll.Id = 1;
            this.btnAll.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAll.LargeGlyph")));
            this.btnAll.Name = "btnAll";
            this.btnAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAll_ItemClick);
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New";
            this.btnNew.Id = 2;
            this.btnNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNew.LargeGlyph")));
            this.btnNew.Name = "btnNew";
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Enabled = false;
            this.btnSave.Id = 3;
            this.btnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSave.LargeGlyph")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 4;
            this.btnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.LargeGlyph")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnPrinter
            // 
            this.btnPrinter.Caption = "Print";
            this.btnPrinter.Id = 5;
            this.btnPrinter.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrinter.LargeGlyph")));
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrinter_ItemClick);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Caption = "Show Order";
            this.btnShowDetails.Id = 6;
            this.btnShowDetails.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnShowDetails.LargeGlyph")));
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowDetails_ItemClick);
            // 
            // btnShowBills
            // 
            this.btnShowBills.Caption = "Show Bills";
            this.btnShowBills.Enabled = false;
            this.btnShowBills.Id = 7;
            this.btnShowBills.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnShowBills.LargeGlyph")));
            this.btnShowBills.Name = "btnShowBills";
            this.btnShowBills.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowBills_ItemClick);
            // 
            // btnDetailsAll
            // 
            this.btnDetailsAll.Caption = "All";
            this.btnDetailsAll.Id = 8;
            this.btnDetailsAll.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDetailsAll.LargeGlyph")));
            this.btnDetailsAll.Name = "btnDetailsAll";
            this.btnDetailsAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetailsAll_ItemClick);
            // 
            // btnDetailsNew
            // 
            this.btnDetailsNew.Caption = "New";
            this.btnDetailsNew.Id = 9;
            this.btnDetailsNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDetailsNew.LargeGlyph")));
            this.btnDetailsNew.Name = "btnDetailsNew";
            this.btnDetailsNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetailsNew_ItemClick);
            // 
            // btnDetailsSave
            // 
            this.btnDetailsSave.Caption = "Save";
            this.btnDetailsSave.Id = 10;
            this.btnDetailsSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDetailsSave.LargeGlyph")));
            this.btnDetailsSave.Name = "btnDetailsSave";
            this.btnDetailsSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetailsSave_ItemClick);
            // 
            // btnShowSeller
            // 
            this.btnShowSeller.Caption = "Show Seller Info";
            this.btnShowSeller.Id = 12;
            this.btnShowSeller.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnShowSeller.LargeGlyph")));
            this.btnShowSeller.Name = "btnShowSeller";
            this.btnShowSeller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowSeller_ItemClick);
            // 
            // bntShowCus
            // 
            this.bntShowCus.Caption = "Show Customer\'s Info";
            this.bntShowCus.Id = 13;
            this.bntShowCus.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bntShowCus.LargeGlyph")));
            this.bntShowCus.Name = "bntShowCus";
            this.bntShowCus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntShowCus_ItemClick);
            // 
            // Skins
            // 
            this.Skins.Caption = "ribbonGalleryBarItem1";
            this.Skins.Id = 14;
            this.Skins.Name = "Skins";
            // 
            // edtCusName
            // 
            this.edtCusName.Caption = "Customer Name";
            this.edtCusName.Edit = this.repositoryItemTextEdit1;
            this.edtCusName.Id = 15;
            this.edtCusName.Name = "edtCusName";
            this.edtCusName.Width = 250;
            this.edtCusName.EditValueChanged += new System.EventHandler(this.edtCusName_EditValueChanged);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // edtCusUse
            // 
            this.edtCusUse.Caption = "   Customer Use";
            this.edtCusUse.Edit = this.repositoryItemTextEdit2;
            this.edtCusUse.Id = 16;
            this.edtCusUse.Name = "edtCusUse";
            this.edtCusUse.Width = 250;
            this.edtCusUse.EditValueChanged += new System.EventHandler(this.edtCusUse_EditValueChanged);
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // edtSelUse
            // 
            this.edtSelUse.Caption = "   Seller Use";
            this.edtSelUse.Edit = this.repositoryItemTextEdit4;
            this.edtSelUse.Id = 18;
            this.edtSelUse.Name = "edtSelUse";
            this.edtSelUse.Width = 250;
            this.edtSelUse.EditValueChanged += new System.EventHandler(this.edtSelUse_EditValueChanged);
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // edtSelName
            // 
            this.edtSelName.Caption = "Seller Name";
            this.edtSelName.Edit = this.repositoryItemTextEdit5;
            this.edtSelName.Id = 19;
            this.edtSelName.Name = "edtSelName";
            this.edtSelName.Width = 250;
            this.edtSelName.EditValueChanged += new System.EventHandler(this.edtSelName_EditValueChanged);
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupFile,
            this.ribbonPageGroup2,
            this.ribbonPageGroupDetailOptions,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Bill\'s Option";
            // 
            // ribbonPageGroupFile
            // 
            this.ribbonPageGroupFile.ItemLinks.Add(this.btnAll);
            this.ribbonPageGroupFile.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroupFile.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroupFile.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroupFile.ItemLinks.Add(this.btnPrinter);
            this.ribbonPageGroupFile.Name = "ribbonPageGroupFile";
            this.ribbonPageGroupFile.Text = "Fille";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnShowDetails);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnShowBills);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnShowSeller);
            this.ribbonPageGroup2.ItemLinks.Add(this.bntShowCus);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Option View";
            // 
            // ribbonPageGroupDetailOptions
            // 
            this.ribbonPageGroupDetailOptions.ItemLinks.Add(this.btnDetailsAll);
            this.ribbonPageGroupDetailOptions.ItemLinks.Add(this.btnDetailsNew);
            this.ribbonPageGroupDetailOptions.ItemLinks.Add(this.btnDetailsSave);
            this.ribbonPageGroupDetailOptions.Name = "ribbonPageGroupDetailOptions";
            this.ribbonPageGroupDetailOptions.Text = "Details Options";
            this.ribbonPageGroupDetailOptions.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.Skins);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Skins";
            // 
            // ribbonPageFind
            // 
            this.ribbonPageFind.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPageFind.Name = "ribbonPageFind";
            this.ribbonPageFind.Text = "Bill\'s Searching";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.edtCusName);
            this.ribbonPageGroup1.ItemLinks.Add(this.edtCusUse);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Searching";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.edtSelUse);
            this.ribbonPageGroup3.ItemLinks.Add(this.edtSelName);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Searching";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // BillListForm
            // 
            this.ClientSize = new System.Drawing.Size(937, 466);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl1);
            this.DoubleBuffered = true;
            this.Name = "BillListForm";
            this.Text = "BillListForm";
            this.Load += new System.EventHandler(this.BillListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardViewBillDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateRequire.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateRequire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnAll;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnPrinter;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupFile;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutViewBills;
        private DevExpress.XtraGrid.Views.Card.CardView cardViewBillDetails;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBill;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBillCusID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBillsSalerID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBillRequireDate;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBillDeleted;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBillCusName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBillSalerName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBillChangeCustomer;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colBillOrderDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDetailsOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colBillOrdedetailCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDetailCustomerUse;
        private DevExpress.XtraBars.BarButtonItem btnShowDetails;
        private DevExpress.XtraBars.BarButtonItem btnShowBills;
        private DevExpress.XtraBars.BarButtonItem btnDetailsAll;
        private DevExpress.XtraBars.BarButtonItem btnDetailsNew;
        private DevExpress.XtraBars.BarButtonItem btnDetailsSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDetailOptions;
        private DevExpress.XtraBars.BarButtonItem btnShowSeller;
        private DevExpress.XtraBars.BarButtonItem bntShowCus;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDetailsDateRequire;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDetailChooseOrder;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repOrders;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateRequire;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraBars.RibbonGalleryBarItem Skins;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageFind;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarEditItem edtCusName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarEditItem edtCusUse;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarEditItem edtSelUse;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraBars.BarEditItem edtSelName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
    }
}
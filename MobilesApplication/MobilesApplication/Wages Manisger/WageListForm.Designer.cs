namespace MobilesApplication.Wages_Manisger
{
    partial class WageListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WageListForm));
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.wagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPremium = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCoefficient = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCoefficientsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateEstablished = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDateEstab = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEmployees = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar = new DevComponents.DotNetBar.Bar();
            this.barFile = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.barExit = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.btnNew = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnShowEmpl = new DevComponents.DotNetBar.ButtonItem();
            this.btnShowAdm = new DevComponents.DotNetBar.ButtonItem();
            this.btnShowWageCoefficient = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.command = new DevComponents.DotNetBar.Command(this.components);
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
            this.colorPickerDropDown1 = new DevComponents.DotNetBar.ColorPickerDropDown();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCoefficient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateEstab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateEstab.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.wagesBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControl_EmbeddedNavigator_ButtonClick);
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEmployees,
            this.repCoefficient,
            this.repDateEstab});
            this.gridControl.Size = new System.Drawing.Size(1102, 394);
            this.gridControl.TabIndex = 0;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.gridView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.gridView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.gridView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.gridView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gridView.Appearance.Empty.Options.UseBackColor = true;
            this.gridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.gridView.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.gridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.gridView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.gridView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.gridView.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.gridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.gridView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.gridView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.gridView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.gridView.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.gridView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.gridView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.gridView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.gridView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.gridView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.gridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.gridView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.gridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.gridView.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.gridView.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView.Appearance.HorzLine.Options.UseBorderColor = true;
            this.gridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.gridView.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.gridView.Appearance.Preview.Options.UseBackColor = true;
            this.gridView.Appearance.Preview.Options.UseFont = true;
            this.gridView.Appearance.Preview.Options.UseForeColor = true;
            this.gridView.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.Row.Options.UseBackColor = true;
            this.gridView.Appearance.Row.Options.UseForeColor = true;
            this.gridView.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
            this.gridView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.gridView.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.gridView.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView.Appearance.VertLine.Options.UseBorderColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPremium,
            this.colTotalDate,
            this.gridColumn5,
            this.colCoefficientsID,
            this.colDeleted,
            this.gridColumn2,
            this.colIsPay,
            this.colDateEstablished,
            this.colEmployeeID,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView.OptionsView.EnableAppearanceOddRow = true;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView_InitNewRow);
            this.gridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView_InvalidRowException);
            this.gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_ValidateRow);
            // 
            // colPremium
            // 
            this.colPremium.FieldName = "Premium";
            this.colPremium.Name = "colPremium";
            this.colPremium.Visible = true;
            this.colPremium.VisibleIndex = 0;
            this.colPremium.Width = 56;
            // 
            // colTotalDate
            // 
            this.colTotalDate.FieldName = "TotalDate";
            this.colTotalDate.Name = "colTotalDate";
            this.colTotalDate.Visible = true;
            this.colTotalDate.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Coefficient Change";
            this.gridColumn5.ColumnEdit = this.repCoefficient;
            this.gridColumn5.FieldName = "WageCoefficientInfo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 112;
            // 
            // repCoefficient
            // 
            this.repCoefficient.AutoHeight = false;
            this.repCoefficient.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCoefficient.DisplayMember = "Point";
            this.repCoefficient.Name = "repCoefficient";
            this.repCoefficient.EditValueChanged += new System.EventHandler(this.repCoefficient_EditValueChanged);
            // 
            // colCoefficientsID
            // 
            this.colCoefficientsID.Caption = "Point";
            this.colCoefficientsID.FieldName = "Point";
            this.colCoefficientsID.Name = "colCoefficientsID";
            this.colCoefficientsID.Visible = true;
            this.colCoefficientsID.VisibleIndex = 3;
            this.colCoefficientsID.Width = 56;
            // 
            // colDeleted
            // 
            this.colDeleted.FieldName = "Deleted";
            this.colDeleted.Name = "colDeleted";
            this.colDeleted.Visible = true;
            this.colDeleted.VisibleIndex = 4;
            this.colDeleted.Width = 76;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Total money";
            this.gridColumn2.FieldName = "Total";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 85;
            // 
            // colIsPay
            // 
            this.colIsPay.FieldName = "IsPay";
            this.colIsPay.Name = "colIsPay";
            this.colIsPay.Visible = true;
            this.colIsPay.VisibleIndex = 6;
            this.colIsPay.Width = 54;
            // 
            // colDateEstablished
            // 
            this.colDateEstablished.ColumnEdit = this.repDateEstab;
            this.colDateEstablished.FieldName = "DateEstablished";
            this.colDateEstablished.Name = "colDateEstablished";
            this.colDateEstablished.Visible = true;
            this.colDateEstablished.VisibleIndex = 7;
            this.colDateEstablished.Width = 117;
            // 
            // repDateEstab
            // 
            this.repDateEstab.AutoHeight = false;
            this.repDateEstab.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDateEstab.Name = "repDateEstab";
            this.repDateEstab.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repDateEstab.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repDateEstab_EditValueChanging);
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "Employee";
            this.colEmployeeID.FieldName = "EmployeeName";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 8;
            this.colEmployeeID.Width = 192;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Admin";
            this.gridColumn1.FieldName = "AdminName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            this.gridColumn1.Width = 158;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Change Employee";
            this.gridColumn3.ColumnEdit = this.repEmployees;
            this.gridColumn3.FieldName = "EmployeeInfo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            this.gridColumn3.Width = 103;
            // 
            // repEmployees
            // 
            this.repEmployees.AutoHeight = false;
            this.repEmployees.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEmployees.DisplayMember = "UseName";
            this.repEmployees.Name = "repEmployees";
            this.repEmployees.EditValueChanged += new System.EventHandler(this.repEmployees_EditValueChanged);
            this.repEmployees.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repEmployees_EditValueChanging);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Change Admin";
            this.gridColumn4.ColumnEdit = this.repEmployees;
            this.gridColumn4.FieldName = "AdminInfo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            // 
            // bar
            // 
            this.bar.AntiAlias = true;
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.barFile,
            this.buttonItem2,
            this.buttonItem6});
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1102, 25);
            this.bar.Stretch = true;
            this.bar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar.TabIndex = 1;
            this.bar.TabStop = false;
            this.bar.Text = "bar1";
            // 
            // barFile
            // 
            this.barFile.Name = "barFile";
            this.barFile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnRefresh,
            this.barExit});
            this.barFile.Text = "File";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // barExit
            // 
            this.barExit.Image = ((System.Drawing.Image)(resources.GetObject("barExit.Image")));
            this.barExit.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.barExit.Name = "barExit";
            this.barExit.Text = "Exit";
            this.barExit.Click += new System.EventHandler(this.barExit_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNew,
            this.btnSave,
            this.btnShowEmpl,
            this.btnShowAdm,
            this.btnShowWageCoefficient});
            this.buttonItem2.Text = "Edit";
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowEmpl
            // 
            this.btnShowEmpl.Image = ((System.Drawing.Image)(resources.GetObject("btnShowEmpl.Image")));
            this.btnShowEmpl.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnShowEmpl.Name = "btnShowEmpl";
            this.btnShowEmpl.Text = "Show Employee Info";
            this.btnShowEmpl.Click += new System.EventHandler(this.btnShowEmpl_Click);
            // 
            // btnShowAdm
            // 
            this.btnShowAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAdm.Image")));
            this.btnShowAdm.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnShowAdm.Name = "btnShowAdm";
            this.btnShowAdm.Text = "Show Admin Info";
            this.btnShowAdm.Click += new System.EventHandler(this.btnShowAdm_Click);
            // 
            // btnShowWageCoefficient
            // 
            this.btnShowWageCoefficient.Image = ((System.Drawing.Image)(resources.GetObject("btnShowWageCoefficient.Image")));
            this.btnShowWageCoefficient.Name = "btnShowWageCoefficient";
            this.btnShowWageCoefficient.Text = "Show Wage Coefficient";
            this.btnShowWageCoefficient.Click += new System.EventHandler(this.btnShowWageCoefficient_Click);
            // 
            // buttonItem6
            // 
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem3,
            this.buttonItem4,
            this.buttonItem5,
            this.buttonItem7,
            this.buttonItem8,
            this.buttonItem9,
            this.buttonItem10,
            this.buttonItem11,
            this.buttonItem12,
            this.buttonItem13,
            this.colorPickerDropDown1});
            this.buttonItem6.Text = "View";
            // 
            // buttonItem3
            // 
            this.buttonItem3.Command = this.command;
            this.buttonItem3.CommandParameter = "Office2007Blue";
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "Office 2007 Blue";
            // 
            // command
            // 
            this.command.Name = "command";
            this.command.PreviewExecuted += new System.ComponentModel.CancelEventHandler(this.command_PreviewExecuted);
            // 
            // buttonItem4
            // 
            this.buttonItem4.Command = this.command;
            this.buttonItem4.CommandParameter = "Office2007Silver";
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Text = "Office 2007 Silver";
            // 
            // buttonItem5
            // 
            this.buttonItem5.Command = this.command;
            this.buttonItem5.CommandParameter = "Office2007Black";
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.Text = "Office 2007 Black";
            // 
            // buttonItem7
            // 
            this.buttonItem7.Command = this.command;
            this.buttonItem7.CommandParameter = "Office2007VistaGlass";
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.Text = "Office 2007 Vista Glass";
            // 
            // buttonItem8
            // 
            this.buttonItem8.Command = this.command;
            this.buttonItem8.CommandParameter = "Office2010Silver";
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.Text = "Office 2010 Silver";
            // 
            // buttonItem9
            // 
            this.buttonItem9.Command = this.command;
            this.buttonItem9.CommandParameter = "Office2010Blue";
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.Text = "Office 2010 Blue";
            // 
            // buttonItem10
            // 
            this.buttonItem10.Command = this.command;
            this.buttonItem10.CommandParameter = "Office2010Black";
            this.buttonItem10.Name = "buttonItem10";
            this.buttonItem10.Text = "Office 2010 Black";
            // 
            // buttonItem11
            // 
            this.buttonItem11.Command = this.command;
            this.buttonItem11.CommandParameter = "Windows7Blue";
            this.buttonItem11.Name = "buttonItem11";
            this.buttonItem11.Text = "Windows7 Blue";
            // 
            // buttonItem12
            // 
            this.buttonItem12.Command = this.command;
            this.buttonItem12.CommandParameter = "VisualStudio2010Blue";
            this.buttonItem12.Name = "buttonItem12";
            this.buttonItem12.Text = "VisualStudio 2010 Blue";
            // 
            // buttonItem13
            // 
            this.buttonItem13.Command = this.command;
            this.buttonItem13.CommandParameter = "Metro";
            this.buttonItem13.Name = "buttonItem13";
            this.buttonItem13.Text = "Metro";
            // 
            // colorPickerDropDown1
            // 
            this.colorPickerDropDown1.Command = this.command;
            this.colorPickerDropDown1.Name = "colorPickerDropDown1";
            this.colorPickerDropDown1.Text = "Custom";
            this.colorPickerDropDown1.ColorPreview += new DevComponents.DotNetBar.ColorPreviewEventHandler(this.colorPickerDropDown1_ColorPreview);
            // 
            // WageListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 394);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.gridControl);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "WageListForm";
            this.Text = "Wages";
            this.Load += new System.EventHandler(this.WageListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCoefficient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateEstab.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateEstab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevComponents.DotNetBar.Bar bar;
        private DevComponents.DotNetBar.ButtonItem barFile;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem barExit;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem btnNew;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnShowEmpl;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.ButtonItem btnShowAdm;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem9;
        private DevComponents.DotNetBar.ButtonItem buttonItem10;
        private DevComponents.DotNetBar.ButtonItem buttonItem11;
        private DevComponents.DotNetBar.ButtonItem buttonItem12;
        private DevComponents.DotNetBar.ButtonItem buttonItem13;
        private DevComponents.DotNetBar.Command command;
        private DevComponents.DotNetBar.ColorPickerDropDown colorPickerDropDown1;
        private DevExpress.XtraGrid.Columns.GridColumn colPremium;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCoefficientsID;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPay;
        private DevExpress.XtraGrid.Columns.GridColumn colDateEstablished;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repEmployees;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCoefficient;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.BindingSource wagesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateEstab;
        private DevComponents.DotNetBar.ButtonItem btnShowWageCoefficient;
    }
}
namespace Husnain
{
    partial class FMAccountsVouchersRec
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
            this.BrandRegistrationTabs = new DevExpress.XtraTab.XtraTabControl();
            this.VouchersView = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.GCVouchers = new DevExpress.XtraGrid.GridControl();
            this.ViewVouchers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colvcnum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvcDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvcType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AddVouchersTab = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.CalAmount = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.Clear = new DevExpress.XtraEditors.SimpleButton();
            this.Add = new DevExpress.XtraEditors.SimpleButton();
            this.Exit = new DevExpress.XtraEditors.SimpleButton();
            this.txtNarration = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbFrom = new DevExpress.XtraEditors.LabelControl();
            this.LPFrom = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ViewSLFrom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeadDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtYear = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMonth = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.CBVcType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.VcDate = new DevExpress.XtraEditors.DateEdit();
            this.lbAction = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BrandRegistrationTabs)).BeginInit();
            this.BrandRegistrationTabs.SuspendLayout();
            this.VouchersView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewVouchers)).BeginInit();
            this.AddVouchersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNarration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LPFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSLFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBVcType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VcDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VcDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandRegistrationTabs
            // 
            this.BrandRegistrationTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrandRegistrationTabs.Location = new System.Drawing.Point(0, 0);
            this.BrandRegistrationTabs.Name = "BrandRegistrationTabs";
            this.BrandRegistrationTabs.SelectedTabPage = this.VouchersView;
            this.BrandRegistrationTabs.Size = new System.Drawing.Size(948, 342);
            this.BrandRegistrationTabs.TabIndex = 0;
            this.BrandRegistrationTabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.VouchersView,
            this.AddVouchersTab});
            // 
            // VouchersView
            // 
            this.VouchersView.Controls.Add(this.groupControl2);
            this.VouchersView.Name = "VouchersView";
            this.VouchersView.Size = new System.Drawing.Size(942, 314);
            this.VouchersView.Text = "Vouchers";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.searchControl1);
            this.groupControl2.Controls.Add(this.GCVouchers);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(942, 314);
            this.groupControl2.TabIndex = 1;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.GCVouchers;
            this.searchControl1.Location = new System.Drawing.Point(357, -3);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.GCVouchers;
            this.searchControl1.Properties.FilterCondition = DevExpress.Data.Filtering.FilterCondition.Like;
            this.searchControl1.Size = new System.Drawing.Size(442, 20);
            this.searchControl1.TabIndex = 3;
            // 
            // GCVouchers
            // 
            this.GCVouchers.Cursor = System.Windows.Forms.Cursors.Default;
            this.GCVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCVouchers.Location = new System.Drawing.Point(2, 21);
            this.GCVouchers.MainView = this.ViewVouchers;
            this.GCVouchers.Name = "GCVouchers";
            this.GCVouchers.Size = new System.Drawing.Size(938, 291);
            this.GCVouchers.TabIndex = 0;
            this.GCVouchers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewVouchers});
            this.GCVouchers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GCBrands_KeyDown);
            this.GCVouchers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GCBrands_MouseDoubleClick);
            // 
            // ViewVouchers
            // 
            this.ViewVouchers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colvcnum,
            this.colvcDate,
            this.colvcType,
            this.colNarration,
            this.colAmount,
            this.colFromAccount,
            this.colFromAccountId,
            this.colToAccount,
            this.colToAccountId});
            this.ViewVouchers.GridControl = this.GCVouchers;
            this.ViewVouchers.Name = "ViewVouchers";
            this.ViewVouchers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.ViewVouchers.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.ViewVouchers.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.ViewVouchers.OptionsBehavior.AllowIncrementalSearch = true;
            this.ViewVouchers.OptionsBehavior.Editable = false;
            this.ViewVouchers.OptionsBehavior.FocusLeaveOnTab = true;
            this.ViewVouchers.OptionsBehavior.ReadOnly = true;
            this.ViewVouchers.OptionsCustomization.AllowColumnMoving = false;
            this.ViewVouchers.OptionsCustomization.AllowGroup = false;
            this.ViewVouchers.OptionsCustomization.AllowQuickHideColumns = false;
            this.ViewVouchers.OptionsView.ShowGroupPanel = false;
            // 
            // colvcnum
            // 
            this.colvcnum.AppearanceCell.Options.UseTextOptions = true;
            this.colvcnum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvcnum.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colvcnum.AppearanceHeader.Options.UseTextOptions = true;
            this.colvcnum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvcnum.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colvcnum.Caption = "Vc #";
            this.colvcnum.FieldName = "vcnum";
            this.colvcnum.Name = "colvcnum";
            this.colvcnum.Visible = true;
            this.colvcnum.VisibleIndex = 5;
            this.colvcnum.Width = 64;
            // 
            // colvcDate
            // 
            this.colvcDate.AppearanceCell.Options.UseTextOptions = true;
            this.colvcDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvcDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colvcDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colvcDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvcDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colvcDate.Caption = "Date";
            this.colvcDate.DisplayFormat.FormatString = "d";
            this.colvcDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colvcDate.FieldName = "vcDate";
            this.colvcDate.Name = "colvcDate";
            this.colvcDate.Visible = true;
            this.colvcDate.VisibleIndex = 3;
            this.colvcDate.Width = 71;
            // 
            // colvcType
            // 
            this.colvcType.AppearanceCell.Options.UseTextOptions = true;
            this.colvcType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvcType.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colvcType.AppearanceHeader.Options.UseTextOptions = true;
            this.colvcType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvcType.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colvcType.Caption = "Type";
            this.colvcType.FieldName = "vcType";
            this.colvcType.Name = "colvcType";
            this.colvcType.Visible = true;
            this.colvcType.VisibleIndex = 4;
            this.colvcType.Width = 87;
            // 
            // colNarration
            // 
            this.colNarration.Caption = "Narration";
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 1;
            this.colNarration.Width = 187;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceCell.Options.UseTextOptions = true;
            this.colAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAmount.Caption = "Amount";
            this.colAmount.DisplayFormat.FormatString = "n2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            this.colAmount.Width = 94;
            // 
            // colFromAccount
            // 
            this.colFromAccount.Caption = "From";
            this.colFromAccount.FieldName = "FromAccount";
            this.colFromAccount.Name = "colFromAccount";
            this.colFromAccount.Visible = true;
            this.colFromAccount.VisibleIndex = 0;
            this.colFromAccount.Width = 225;
            // 
            // colFromAccountId
            // 
            this.colFromAccountId.Caption = "From Id";
            this.colFromAccountId.FieldName = "FromAccountId";
            this.colFromAccountId.Name = "colFromAccountId";
            // 
            // colToAccount
            // 
            this.colToAccount.Caption = "To";
            this.colToAccount.FieldName = "ToAccount";
            this.colToAccount.Name = "colToAccount";
            this.colToAccount.Width = 194;
            // 
            // colToAccountId
            // 
            this.colToAccountId.Caption = "To Id";
            this.colToAccountId.FieldName = "ToAccountId";
            this.colToAccountId.Name = "colToAccountId";
            // 
            // AddVouchersTab
            // 
            this.AddVouchersTab.Controls.Add(this.panelControl1);
            this.AddVouchersTab.Name = "AddVouchersTab";
            this.AddVouchersTab.Size = new System.Drawing.Size(942, 314);
            this.AddVouchersTab.Text = "Add Vouchers";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl4);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(942, 314);
            this.panelControl1.TabIndex = 16;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.labelControl9);
            this.groupControl4.Controls.Add(this.CalAmount);
            this.groupControl4.Controls.Add(this.labelControl8);
            this.groupControl4.Controls.Add(this.Clear);
            this.groupControl4.Controls.Add(this.Add);
            this.groupControl4.Controls.Add(this.Exit);
            this.groupControl4.Controls.Add(this.txtNarration);
            this.groupControl4.Location = new System.Drawing.Point(3, 164);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(939, 137);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "Transfer Section";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(9, 59);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(66, 17);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Amount:";
            // 
            // CalAmount
            // 
            this.CalAmount.EnterMoveNextControl = true;
            this.CalAmount.Location = new System.Drawing.Point(81, 58);
            this.CalAmount.Name = "CalAmount";
            this.CalAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CalAmount.Properties.Mask.EditMask = "d";
            this.CalAmount.Properties.NullText = "0";
            this.CalAmount.Size = new System.Drawing.Size(182, 20);
            this.CalAmount.TabIndex = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(9, 33);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 17);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Narration:";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(615, 82);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(182, 33);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(615, 32);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(182, 44);
            this.Add.TabIndex = 2;
            this.Add.Text = "Transfer and Save";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(799, 32);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(66, 83);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtNarration
            // 
            this.txtNarration.EnterMoveNextControl = true;
            this.txtNarration.Location = new System.Drawing.Point(81, 32);
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtNarration.Properties.Appearance.Options.UseBackColor = true;
            this.txtNarration.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNarration.Size = new System.Drawing.Size(472, 20);
            this.txtNarration.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbFrom);
            this.groupControl1.Controls.Add(this.LPFrom);
            this.groupControl1.Location = new System.Drawing.Point(3, 95);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(939, 63);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Account Details";
            // 
            // lbFrom
            // 
            this.lbFrom.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbFrom.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbFrom.Location = new System.Drawing.Point(5, 27);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(70, 13);
            this.lbFrom.TabIndex = 13;
            this.lbFrom.Text = "From Account:";
            // 
            // LPFrom
            // 
            this.LPFrom.EnterMoveNextControl = true;
            this.LPFrom.Location = new System.Drawing.Point(81, 24);
            this.LPFrom.Name = "LPFrom";
            this.LPFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LPFrom.Properties.NullText = "Select Account...";
            this.LPFrom.Properties.View = this.ViewSLFrom;
            this.LPFrom.Size = new System.Drawing.Size(784, 20);
            this.LPFrom.TabIndex = 0;
            // 
            // ViewSLFrom
            // 
            this.ViewSLFrom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountId,
            this.colAccountTitle,
            this.colHeadDetail});
            this.ViewSLFrom.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ViewSLFrom.Name = "ViewSLFrom";
            this.ViewSLFrom.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ViewSLFrom.OptionsView.ShowGroupPanel = false;
            // 
            // colAccountId
            // 
            this.colAccountId.Caption = "AccountId";
            this.colAccountId.DisplayFormat.FormatString = "n0";
            this.colAccountId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAccountId.FieldName = "AccountId";
            this.colAccountId.Name = "colAccountId";
            this.colAccountId.OptionsEditForm.VisibleIndex = 2;
            this.colAccountId.Visible = true;
            this.colAccountId.VisibleIndex = 2;
            this.colAccountId.Width = 163;
            // 
            // colAccountTitle
            // 
            this.colAccountTitle.Caption = "Accounts";
            this.colAccountTitle.FieldName = "AccountTitle";
            this.colAccountTitle.Name = "colAccountTitle";
            this.colAccountTitle.Visible = true;
            this.colAccountTitle.VisibleIndex = 0;
            this.colAccountTitle.Width = 643;
            // 
            // colHeadDetail
            // 
            this.colHeadDetail.Caption = "Account Head";
            this.colHeadDetail.FieldName = "HeadDetail";
            this.colHeadDetail.Name = "colHeadDetail";
            this.colHeadDetail.Visible = true;
            this.colHeadDetail.VisibleIndex = 1;
            this.colHeadDetail.Width = 186;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.txtYear);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.txtMonth);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.txtDay);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.CBVcType);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.VcDate);
            this.groupControl3.Controls.Add(this.lbAction);
            this.groupControl3.Location = new System.Drawing.Point(3, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(939, 86);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Voucher Details";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(303, 51);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 17);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "Year:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(371, 51);
            this.txtYear.Name = "txtYear";
            this.txtYear.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtYear.Properties.Appearance.Options.UseBackColor = true;
            this.txtYear.Properties.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(182, 20);
            this.txtYear.TabIndex = 20;
            this.txtYear.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(9, 54);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 17);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Month:";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(81, 50);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMonth.Properties.Appearance.Options.UseBackColor = true;
            this.txtMonth.Properties.ReadOnly = true;
            this.txtMonth.Size = new System.Drawing.Size(182, 20);
            this.txtMonth.TabIndex = 18;
            this.txtMonth.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(559, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 17);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Day:";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(615, 25);
            this.txtDay.Name = "txtDay";
            this.txtDay.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDay.Properties.Appearance.Options.UseBackColor = true;
            this.txtDay.Properties.ReadOnly = true;
            this.txtDay.Size = new System.Drawing.Size(182, 20);
            this.txtDay.TabIndex = 16;
            this.txtDay.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(285, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Payment Type:";
            // 
            // CBVcType
            // 
            this.CBVcType.EditValue = "Select Payment Type...";
            this.CBVcType.EnterMoveNextControl = true;
            this.CBVcType.Location = new System.Drawing.Point(371, 25);
            this.CBVcType.Name = "CBVcType";
            this.CBVcType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBVcType.Properties.Items.AddRange(new object[] {
            "CASH PAYMENT",
            "CASH RECEIPT",
            "BANK PAYMENT",
            "BANK RECEIPT",
            "JOURNAL"});
            this.CBVcType.Properties.NullText = "Select Payment Term...";
            this.CBVcType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBVcType.Size = new System.Drawing.Size(182, 20);
            this.CBVcType.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(-2, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 17);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "VC Date:";
            // 
            // VcDate
            // 
            this.VcDate.EditValue = null;
            this.VcDate.EnterMoveNextControl = true;
            this.VcDate.Location = new System.Drawing.Point(81, 25);
            this.VcDate.Name = "VcDate";
            this.VcDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VcDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VcDate.Size = new System.Drawing.Size(182, 20);
            this.VcDate.TabIndex = 0;
            this.VcDate.EditValueChanged += new System.EventHandler(this.VcDate_EditValueChanged);
            // 
            // lbAction
            // 
            this.lbAction.Location = new System.Drawing.Point(553, 284);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(0, 13);
            this.lbAction.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FMAccountsVouchersRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 342);
            this.Controls.Add(this.BrandRegistrationTabs);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMAccountsVouchersRec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Vouchers (Received Amount)";
            this.Load += new System.EventHandler(this.BrandRegistration_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrandRegistration_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.BrandRegistrationTabs)).EndInit();
            this.BrandRegistrationTabs.ResumeLayout(false);
            this.VouchersView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCVouchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewVouchers)).EndInit();
            this.AddVouchersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNarration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LPFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSLFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBVcType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VcDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VcDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl BrandRegistrationTabs;
        private DevExpress.XtraTab.XtraTabPage VouchersView;
        private DevExpress.XtraTab.XtraTabPage AddVouchersTab;
        private DevExpress.XtraGrid.GridControl GCVouchers;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewVouchers;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton Add;
        private DevExpress.XtraEditors.LabelControl lbAction;
        private DevExpress.XtraEditors.SimpleButton Clear;
        private DevExpress.XtraEditors.SimpleButton Exit;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colvcnum;
        private DevExpress.XtraGrid.Columns.GridColumn colvcDate;
        private DevExpress.XtraGrid.Columns.GridColumn colvcType;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colFromAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colToAccountId;
        private DevExpress.XtraEditors.SearchLookUpEdit LPFrom;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewSLFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colHeadDetail;
        private DevExpress.XtraEditors.LabelControl lbFrom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit VcDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit CBVcType;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtYear;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMonth;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDay;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.CalcEdit CalAmount;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtNarration;
        private DevExpress.XtraGrid.Columns.GridColumn colFromAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colToAccount;
    }
}
namespace Husnain
{
    partial class BrandRegistration
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
            this.BrandViews = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.GCBrands = new DevExpress.XtraGrid.GridControl();
            this.ViewBrands = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManfId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManfucturer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSearchActiveText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrandRegistrationTab = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Exit = new DevExpress.XtraEditors.SimpleButton();
            this.Update = new DevExpress.XtraEditors.SimpleButton();
            this.lbAction = new DevExpress.XtraEditors.LabelControl();
            this.Clear = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBrandId = new DevExpress.XtraEditors.TextEdit();
            this.lbBrandIdText = new DevExpress.XtraEditors.LabelControl();
            this.Delete = new DevExpress.XtraEditors.SimpleButton();
            this.txtNewBrand = new DevExpress.XtraEditors.TextEdit();
            this.Add = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CheckBrandActive = new DevExpress.XtraEditors.CheckEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LPFrom = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ViewSLFrom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeadDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BrandRegistrationTabs)).BeginInit();
            this.BrandRegistrationTabs.SuspendLayout();
            this.BrandViews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCBrands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBrands)).BeginInit();
            this.BrandRegistrationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBrandActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LPFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSLFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandRegistrationTabs
            // 
            this.BrandRegistrationTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrandRegistrationTabs.Location = new System.Drawing.Point(0, 0);
            this.BrandRegistrationTabs.Name = "BrandRegistrationTabs";
            this.BrandRegistrationTabs.SelectedTabPage = this.BrandViews;
            this.BrandRegistrationTabs.Size = new System.Drawing.Size(805, 391);
            this.BrandRegistrationTabs.TabIndex = 0;
            this.BrandRegistrationTabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.BrandViews,
            this.BrandRegistrationTab});
            // 
            // BrandViews
            // 
            this.BrandViews.Controls.Add(this.groupControl2);
            this.BrandViews.Name = "BrandViews";
            this.BrandViews.Size = new System.Drawing.Size(799, 363);
            this.BrandViews.Text = "Brand";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.searchControl1);
            this.groupControl2.Controls.Add(this.GCBrands);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(799, 363);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Brands";
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.GCBrands;
            this.searchControl1.Location = new System.Drawing.Point(357, -3);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.GCBrands;
            this.searchControl1.Properties.FilterCondition = DevExpress.Data.Filtering.FilterCondition.Like;
            this.searchControl1.Size = new System.Drawing.Size(442, 20);
            this.searchControl1.TabIndex = 3;
            // 
            // GCBrands
            // 
            this.GCBrands.Cursor = System.Windows.Forms.Cursors.Default;
            this.GCBrands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCBrands.Location = new System.Drawing.Point(2, 21);
            this.GCBrands.MainView = this.ViewBrands;
            this.GCBrands.Name = "GCBrands";
            this.GCBrands.Size = new System.Drawing.Size(795, 340);
            this.GCBrands.TabIndex = 0;
            this.GCBrands.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewBrands});
            this.GCBrands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GCBrands_KeyDown);
            this.GCBrands.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GCBrands_MouseDoubleClick);
            // 
            // ViewBrands
            // 
            this.ViewBrands.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBrandName,
            this.colManfId,
            this.colBrandId,
            this.colActive,
            this.colManfucturer,
            this.colSearchActiveText});
            this.ViewBrands.GridControl = this.GCBrands;
            this.ViewBrands.Name = "ViewBrands";
            this.ViewBrands.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.ViewBrands.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.ViewBrands.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.ViewBrands.OptionsBehavior.AllowIncrementalSearch = true;
            this.ViewBrands.OptionsBehavior.Editable = false;
            this.ViewBrands.OptionsBehavior.FocusLeaveOnTab = true;
            this.ViewBrands.OptionsBehavior.ReadOnly = true;
            this.ViewBrands.OptionsCustomization.AllowColumnMoving = false;
            this.ViewBrands.OptionsCustomization.AllowGroup = false;
            this.ViewBrands.OptionsCustomization.AllowQuickHideColumns = false;
            this.ViewBrands.OptionsView.ShowGroupPanel = false;
            // 
            // colBrandName
            // 
            this.colBrandName.Caption = "Brand Name";
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 0;
            this.colBrandName.Width = 336;
            // 
            // colManfId
            // 
            this.colManfId.Caption = "ManfId";
            this.colManfId.FieldName = "ManfId";
            this.colManfId.Name = "colManfId";
            this.colManfId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colManfId.OptionsEditForm.VisibleIndex = 1;
            // 
            // colBrandId
            // 
            this.colBrandId.AppearanceCell.Options.UseTextOptions = true;
            this.colBrandId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrandId.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBrandId.AppearanceHeader.Options.UseTextOptions = true;
            this.colBrandId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrandId.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBrandId.Caption = "ID";
            this.colBrandId.FieldName = "BrandId";
            this.colBrandId.Name = "colBrandId";
            this.colBrandId.OptionsEditForm.VisibleIndex = 3;
            this.colBrandId.Visible = true;
            this.colBrandId.VisibleIndex = 3;
            this.colBrandId.Width = 49;
            // 
            // colActive
            // 
            this.colActive.Caption = "Active";
            this.colActive.FieldName = "BActive";
            this.colActive.Name = "colActive";
            this.colActive.OptionsEditForm.VisibleIndex = 2;
            this.colActive.Width = 96;
            // 
            // colManfucturer
            // 
            this.colManfucturer.Caption = "Manufacturer";
            this.colManfucturer.FieldName = "Manufacturer";
            this.colManfucturer.Name = "colManfucturer";
            this.colManfucturer.Visible = true;
            this.colManfucturer.VisibleIndex = 1;
            this.colManfucturer.Width = 337;
            // 
            // colSearchActiveText
            // 
            this.colSearchActiveText.AppearanceCell.Options.UseTextOptions = true;
            this.colSearchActiveText.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSearchActiveText.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSearchActiveText.AppearanceHeader.Options.UseTextOptions = true;
            this.colSearchActiveText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSearchActiveText.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSearchActiveText.Caption = "Active";
            this.colSearchActiveText.FieldName = "colSearchActiveText";
            this.colSearchActiveText.Name = "colSearchActiveText";
            this.colSearchActiveText.UnboundExpression = "Iif([BActive],\'YES\',\'NO\')";
            this.colSearchActiveText.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colSearchActiveText.Visible = true;
            this.colSearchActiveText.VisibleIndex = 2;
            this.colSearchActiveText.Width = 57;
            // 
            // BrandRegistrationTab
            // 
            this.BrandRegistrationTab.Controls.Add(this.groupControl3);
            this.BrandRegistrationTab.Name = "BrandRegistrationTab";
            this.BrandRegistrationTab.Size = new System.Drawing.Size(799, 363);
            this.BrandRegistrationTab.Text = "Brand Registration";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.panelControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(799, 363);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Brand Registration";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.LPFrom);
            this.panelControl1.Controls.Add(this.Exit);
            this.panelControl1.Controls.Add(this.Update);
            this.panelControl1.Controls.Add(this.lbAction);
            this.panelControl1.Controls.Add(this.Clear);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtBrandId);
            this.panelControl1.Controls.Add(this.lbBrandIdText);
            this.panelControl1.Controls.Add(this.Delete);
            this.panelControl1.Controls.Add(this.txtNewBrand);
            this.panelControl1.Controls.Add(this.Add);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.CheckBrandActive);
            this.panelControl1.Location = new System.Drawing.Point(9, 38);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(783, 270);
            this.panelControl1.TabIndex = 4;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(547, 133);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 105);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(234, 163);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(307, 21);
            this.Update.TabIndex = 5;
            this.Update.Text = "Update";
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // lbAction
            // 
            this.lbAction.Location = new System.Drawing.Point(234, 225);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(0, 13);
            this.lbAction.TabIndex = 9;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(234, 219);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(307, 21);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(163, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Manufecturer:";
            // 
            // txtBrandId
            // 
            this.txtBrandId.Location = new System.Drawing.Point(234, 26);
            this.txtBrandId.Name = "txtBrandId";
            this.txtBrandId.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBrandId.Properties.Appearance.Options.UseBackColor = true;
            this.txtBrandId.Properties.ReadOnly = true;
            this.txtBrandId.Size = new System.Drawing.Size(365, 20);
            this.txtBrandId.TabIndex = 0;
            this.txtBrandId.TabStop = false;
            // 
            // lbBrandIdText
            // 
            this.lbBrandIdText.Location = new System.Drawing.Point(163, 29);
            this.lbBrandIdText.Name = "lbBrandIdText";
            this.lbBrandIdText.Size = new System.Drawing.Size(45, 13);
            this.lbBrandIdText.TabIndex = 4;
            this.lbBrandIdText.Text = "Brand Id:";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(234, 191);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(307, 21);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // txtNewBrand
            // 
            this.txtNewBrand.EnterMoveNextControl = true;
            this.txtNewBrand.Location = new System.Drawing.Point(234, 54);
            this.txtNewBrand.Name = "txtNewBrand";
            this.txtNewBrand.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNewBrand.Size = new System.Drawing.Size(365, 20);
            this.txtNewBrand.TabIndex = 1;
            this.txtNewBrand.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtNewBrand_PreviewKeyDown);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(234, 135);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(307, 21);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(163, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Brand Name:";
            // 
            // CheckBrandActive
            // 
            this.CheckBrandActive.EnterMoveNextControl = true;
            this.CheckBrandActive.Location = new System.Drawing.Point(163, 109);
            this.CheckBrandActive.Name = "CheckBrandActive";
            this.CheckBrandActive.Properties.Caption = "Active:";
            this.CheckBrandActive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CheckBrandActive.Size = new System.Drawing.Size(88, 19);
            this.CheckBrandActive.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LPFrom
            // 
            this.LPFrom.EnterMoveNextControl = true;
            this.LPFrom.Location = new System.Drawing.Point(234, 80);
            this.LPFrom.Name = "LPFrom";
            this.LPFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LPFrom.Properties.NullText = "Select Account...";
            this.LPFrom.Properties.View = this.ViewSLFrom;
            this.LPFrom.Size = new System.Drawing.Size(365, 20);
            this.LPFrom.TabIndex = 11;
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
            // BrandRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 391);
            this.Controls.Add(this.BrandRegistrationTabs);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrandRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Brand Registration";
            this.Load += new System.EventHandler(this.BrandRegistration_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrandRegistration_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.BrandRegistrationTabs)).EndInit();
            this.BrandRegistrationTabs.ResumeLayout(false);
            this.BrandViews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCBrands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBrands)).EndInit();
            this.BrandRegistrationTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBrandActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LPFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSLFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl BrandRegistrationTabs;
        private DevExpress.XtraTab.XtraTabPage BrandViews;
        private DevExpress.XtraTab.XtraTabPage BrandRegistrationTab;
        private DevExpress.XtraGrid.GridControl GCBrands;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewBrands;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNewBrand;
        private DevExpress.XtraEditors.SimpleButton Delete;
        private DevExpress.XtraEditors.SimpleButton Add;
        private DevExpress.XtraEditors.CheckEdit CheckBrandActive;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbBrandIdText;
        private DevExpress.XtraEditors.TextEdit txtBrandId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbAction;
        private DevExpress.XtraEditors.SimpleButton Update;
        private DevExpress.XtraEditors.SimpleButton Clear;
        private DevExpress.XtraEditors.SimpleButton Exit;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colManfId;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandId;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colManfucturer;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colSearchActiveText;
        private DevExpress.XtraEditors.SearchLookUpEdit LPFrom;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewSLFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colHeadDetail;
    }
}
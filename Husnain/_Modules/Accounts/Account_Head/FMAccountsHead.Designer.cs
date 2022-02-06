namespace Husnain
{
    partial class FMAccountsHead
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
            this.AccountsHeadViews = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.GCBrands = new DevExpress.XtraGrid.GridControl();
            this.ViewAccountsHead = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHeadDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeadId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSearchActiveText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShowPL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccountsHeadRegistrationTab = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.CheckPL = new DevExpress.XtraEditors.CheckEdit();
            this.Exit = new DevExpress.XtraEditors.SimpleButton();
            this.Update = new DevExpress.XtraEditors.SimpleButton();
            this.lbAction = new DevExpress.XtraEditors.LabelControl();
            this.Clear = new DevExpress.XtraEditors.SimpleButton();
            this.txtHeadId = new DevExpress.XtraEditors.TextEdit();
            this.lbBrandIdText = new DevExpress.XtraEditors.LabelControl();
            this.Delete = new DevExpress.XtraEditors.SimpleButton();
            this.txtNewHead = new DevExpress.XtraEditors.TextEdit();
            this.Add = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CheckHeadActive = new DevExpress.XtraEditors.CheckEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BrandRegistrationTabs)).BeginInit();
            this.BrandRegistrationTabs.SuspendLayout();
            this.AccountsHeadViews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCBrands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAccountsHead)).BeginInit();
            this.AccountsHeadRegistrationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeadId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewHead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckHeadActive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandRegistrationTabs
            // 
            this.BrandRegistrationTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrandRegistrationTabs.Location = new System.Drawing.Point(0, 0);
            this.BrandRegistrationTabs.Name = "BrandRegistrationTabs";
            this.BrandRegistrationTabs.SelectedTabPage = this.AccountsHeadViews;
            this.BrandRegistrationTabs.Size = new System.Drawing.Size(805, 391);
            this.BrandRegistrationTabs.TabIndex = 0;
            this.BrandRegistrationTabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.AccountsHeadViews,
            this.AccountsHeadRegistrationTab});
            // 
            // AccountsHeadViews
            // 
            this.AccountsHeadViews.Controls.Add(this.groupControl2);
            this.AccountsHeadViews.Name = "AccountsHeadViews";
            this.AccountsHeadViews.Size = new System.Drawing.Size(799, 363);
            this.AccountsHeadViews.Text = "Accounts Head";
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
            this.GCBrands.MainView = this.ViewAccountsHead;
            this.GCBrands.Name = "GCBrands";
            this.GCBrands.Size = new System.Drawing.Size(795, 340);
            this.GCBrands.TabIndex = 0;
            this.GCBrands.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewAccountsHead});
            this.GCBrands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GCBrands_KeyDown);
            this.GCBrands.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GCBrands_MouseDoubleClick);
            // 
            // ViewAccountsHead
            // 
            this.ViewAccountsHead.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHeadDetails,
            this.colHeadId,
            this.colActive,
            this.colSearchActiveText,
            this.colShowPL});
            this.ViewAccountsHead.GridControl = this.GCBrands;
            this.ViewAccountsHead.Name = "ViewAccountsHead";
            this.ViewAccountsHead.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.ViewAccountsHead.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.ViewAccountsHead.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.ViewAccountsHead.OptionsBehavior.AllowIncrementalSearch = true;
            this.ViewAccountsHead.OptionsBehavior.Editable = false;
            this.ViewAccountsHead.OptionsBehavior.FocusLeaveOnTab = true;
            this.ViewAccountsHead.OptionsBehavior.ReadOnly = true;
            this.ViewAccountsHead.OptionsCustomization.AllowColumnMoving = false;
            this.ViewAccountsHead.OptionsCustomization.AllowGroup = false;
            this.ViewAccountsHead.OptionsCustomization.AllowQuickHideColumns = false;
            this.ViewAccountsHead.OptionsView.ShowGroupPanel = false;
            // 
            // colHeadDetails
            // 
            this.colHeadDetails.Caption = "Head Detail";
            this.colHeadDetails.FieldName = "HeadDetail";
            this.colHeadDetails.Name = "colHeadDetails";
            this.colHeadDetails.Visible = true;
            this.colHeadDetails.VisibleIndex = 0;
            this.colHeadDetails.Width = 479;
            // 
            // colHeadId
            // 
            this.colHeadId.AppearanceCell.Options.UseTextOptions = true;
            this.colHeadId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHeadId.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHeadId.AppearanceHeader.Options.UseTextOptions = true;
            this.colHeadId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHeadId.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHeadId.Caption = "Head Account Id";
            this.colHeadId.FieldName = "HeadId";
            this.colHeadId.Name = "colHeadId";
            this.colHeadId.OptionsEditForm.VisibleIndex = 3;
            this.colHeadId.Visible = true;
            this.colHeadId.VisibleIndex = 1;
            this.colHeadId.Width = 143;
            // 
            // colActive
            // 
            this.colActive.Caption = "Active";
            this.colActive.FieldName = "HActive";
            this.colActive.Name = "colActive";
            this.colActive.OptionsEditForm.VisibleIndex = 2;
            this.colActive.Width = 96;
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
            this.colSearchActiveText.UnboundExpression = "Iif([HActive],\'YES\',\'NO\')";
            this.colSearchActiveText.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colSearchActiveText.Visible = true;
            this.colSearchActiveText.VisibleIndex = 2;
            this.colSearchActiveText.Width = 70;
            // 
            // colShowPL
            // 
            this.colShowPL.Caption = "Profit/Loss";
            this.colShowPL.FieldName = "PL";
            this.colShowPL.Name = "colShowPL";
            this.colShowPL.Width = 87;
            // 
            // AccountsHeadRegistrationTab
            // 
            this.AccountsHeadRegistrationTab.Controls.Add(this.groupControl3);
            this.AccountsHeadRegistrationTab.Name = "AccountsHeadRegistrationTab";
            this.AccountsHeadRegistrationTab.Size = new System.Drawing.Size(799, 363);
            this.AccountsHeadRegistrationTab.Text = "Accounts Head Registration";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.panelControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(799, 363);
            this.groupControl3.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.CheckPL);
            this.panelControl1.Controls.Add(this.Exit);
            this.panelControl1.Controls.Add(this.Update);
            this.panelControl1.Controls.Add(this.lbAction);
            this.panelControl1.Controls.Add(this.Clear);
            this.panelControl1.Controls.Add(this.txtHeadId);
            this.panelControl1.Controls.Add(this.lbBrandIdText);
            this.panelControl1.Controls.Add(this.Delete);
            this.panelControl1.Controls.Add(this.txtNewHead);
            this.panelControl1.Controls.Add(this.Add);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.CheckHeadActive);
            this.panelControl1.Location = new System.Drawing.Point(9, 38);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(783, 270);
            this.panelControl1.TabIndex = 4;
            // 
            // CheckPL
            // 
            this.CheckPL.EnterMoveNextControl = true;
            this.CheckPL.Location = new System.Drawing.Point(234, 80);
            this.CheckPL.Name = "CheckPL";
            this.CheckPL.Properties.Caption = "Show Profit and Loss:";
            this.CheckPL.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.CheckPL.Size = new System.Drawing.Size(131, 19);
            this.CheckPL.TabIndex = 2;
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
            // txtHeadId
            // 
            this.txtHeadId.Location = new System.Drawing.Point(234, 26);
            this.txtHeadId.Name = "txtHeadId";
            this.txtHeadId.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtHeadId.Properties.Appearance.Options.UseBackColor = true;
            this.txtHeadId.Properties.ReadOnly = true;
            this.txtHeadId.Size = new System.Drawing.Size(365, 20);
            this.txtHeadId.TabIndex = 0;
            this.txtHeadId.TabStop = false;
            // 
            // lbBrandIdText
            // 
            this.lbBrandIdText.Location = new System.Drawing.Point(114, 29);
            this.lbBrandIdText.Name = "lbBrandIdText";
            this.lbBrandIdText.Size = new System.Drawing.Size(111, 13);
            this.lbBrandIdText.TabIndex = 4;
            this.lbBrandIdText.Text = "Account Head Number:";
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
            // txtNewHead
            // 
            this.txtNewHead.EnterMoveNextControl = true;
            this.txtNewHead.Location = new System.Drawing.Point(234, 54);
            this.txtNewHead.Name = "txtNewHead";
            this.txtNewHead.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNewHead.Size = new System.Drawing.Size(365, 20);
            this.txtNewHead.TabIndex = 1;
            this.txtNewHead.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtNewBrand_PreviewKeyDown);
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
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Desctiption:";
            // 
            // CheckHeadActive
            // 
            this.CheckHeadActive.EnterMoveNextControl = true;
            this.CheckHeadActive.Location = new System.Drawing.Point(371, 80);
            this.CheckHeadActive.Name = "CheckHeadActive";
            this.CheckHeadActive.Properties.Caption = "Active:";
            this.CheckHeadActive.Size = new System.Drawing.Size(88, 19);
            this.CheckHeadActive.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FMAccountsHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 391);
            this.Controls.Add(this.BrandRegistrationTabs);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMAccountsHead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Account Head";
            this.Load += new System.EventHandler(this.BrandRegistration_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrandRegistration_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.BrandRegistrationTabs)).EndInit();
            this.BrandRegistrationTabs.ResumeLayout(false);
            this.AccountsHeadViews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCBrands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAccountsHead)).EndInit();
            this.AccountsHeadRegistrationTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeadId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewHead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckHeadActive.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl BrandRegistrationTabs;
        private DevExpress.XtraTab.XtraTabPage AccountsHeadViews;
        private DevExpress.XtraTab.XtraTabPage AccountsHeadRegistrationTab;
        private DevExpress.XtraGrid.GridControl GCBrands;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewAccountsHead;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNewHead;
        private DevExpress.XtraEditors.SimpleButton Delete;
        private DevExpress.XtraEditors.SimpleButton Add;
        private DevExpress.XtraEditors.CheckEdit CheckHeadActive;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbBrandIdText;
        private DevExpress.XtraEditors.TextEdit txtHeadId;
        private DevExpress.XtraEditors.LabelControl lbAction;
        private DevExpress.XtraEditors.SimpleButton Update;
        private DevExpress.XtraEditors.SimpleButton Clear;
        private DevExpress.XtraEditors.SimpleButton Exit;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Columns.GridColumn colHeadDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colHeadId;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colSearchActiveText;
        private DevExpress.XtraGrid.Columns.GridColumn colShowPL;
        private DevExpress.XtraEditors.CheckEdit CheckPL;
    }
}
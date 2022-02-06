namespace Husnain
{
    partial class BrandsCategories
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
            this.BrandCategoriesTabs = new DevExpress.XtraTab.XtraTabControl();
            this.ProductsCategoriesViews = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.GCBrandsCategories = new DevExpress.XtraGrid.GridControl();
            this.ViewBrands = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBrandCat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandCatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBCActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActiveText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductsCategoriesTab = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Exit = new DevExpress.XtraEditors.SimpleButton();
            this.txtBrandCateId = new DevExpress.XtraEditors.TextEdit();
            this.lbBrandIdText = new DevExpress.XtraEditors.LabelControl();
            this.Update = new DevExpress.XtraEditors.SimpleButton();
            this.lbAction = new DevExpress.XtraEditors.LabelControl();
            this.Clear = new DevExpress.XtraEditors.SimpleButton();
            this.Delete = new DevExpress.XtraEditors.SimpleButton();
            this.txtNewBrandCate = new DevExpress.XtraEditors.TextEdit();
            this.Add = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CheckBrandActive = new DevExpress.XtraEditors.CheckEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BrandCategoriesTabs)).BeginInit();
            this.BrandCategoriesTabs.SuspendLayout();
            this.ProductsCategoriesViews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCBrandsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBrands)).BeginInit();
            this.ProductsCategoriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandCateId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewBrandCate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBrandActive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandCategoriesTabs
            // 
            this.BrandCategoriesTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrandCategoriesTabs.Location = new System.Drawing.Point(0, 0);
            this.BrandCategoriesTabs.Name = "BrandCategoriesTabs";
            this.BrandCategoriesTabs.SelectedTabPage = this.ProductsCategoriesViews;
            this.BrandCategoriesTabs.Size = new System.Drawing.Size(805, 323);
            this.BrandCategoriesTabs.TabIndex = 0;
            this.BrandCategoriesTabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.ProductsCategoriesViews,
            this.ProductsCategoriesTab});
            // 
            // ProductsCategoriesViews
            // 
            this.ProductsCategoriesViews.Controls.Add(this.groupControl2);
            this.ProductsCategoriesViews.Name = "ProductsCategoriesViews";
            this.ProductsCategoriesViews.Size = new System.Drawing.Size(799, 295);
            this.ProductsCategoriesViews.Text = "Products Categories";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.searchControl1);
            this.groupControl2.Controls.Add(this.GCBrandsCategories);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(799, 295);
            this.groupControl2.TabIndex = 1;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.GCBrandsCategories;
            this.searchControl1.Location = new System.Drawing.Point(357, -3);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.GCBrandsCategories;
            this.searchControl1.Properties.FilterCondition = DevExpress.Data.Filtering.FilterCondition.Like;
            this.searchControl1.Size = new System.Drawing.Size(442, 20);
            this.searchControl1.TabIndex = 4;
            // 
            // GCBrandsCategories
            // 
            this.GCBrandsCategories.Cursor = System.Windows.Forms.Cursors.Default;
            this.GCBrandsCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCBrandsCategories.Location = new System.Drawing.Point(2, 21);
            this.GCBrandsCategories.MainView = this.ViewBrands;
            this.GCBrandsCategories.Name = "GCBrandsCategories";
            this.GCBrandsCategories.Size = new System.Drawing.Size(795, 272);
            this.GCBrandsCategories.TabIndex = 0;
            this.GCBrandsCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewBrands});
            this.GCBrandsCategories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GCBrands_KeyDown);
            this.GCBrandsCategories.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GCBrands_MouseDoubleClick);
            // 
            // ViewBrands
            // 
            this.ViewBrands.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBrandCat,
            this.colBrandCatId,
            this.colBCActive,
            this.colActiveText});
            this.ViewBrands.GridControl = this.GCBrandsCategories;
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
            // colBrandCat
            // 
            this.colBrandCat.Caption = "Categories";
            this.colBrandCat.FieldName = "BrandCat";
            this.colBrandCat.Name = "colBrandCat";
            this.colBrandCat.Visible = true;
            this.colBrandCat.VisibleIndex = 0;
            this.colBrandCat.Width = 324;
            // 
            // colBrandCatId
            // 
            this.colBrandCatId.AppearanceCell.Options.UseTextOptions = true;
            this.colBrandCatId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrandCatId.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBrandCatId.AppearanceHeader.Options.UseTextOptions = true;
            this.colBrandCatId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrandCatId.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBrandCatId.Caption = " ID";
            this.colBrandCatId.FieldName = "BrandCatID";
            this.colBrandCatId.Name = "colBrandCatId";
            this.colBrandCatId.OptionsEditForm.VisibleIndex = 3;
            this.colBrandCatId.Visible = true;
            this.colBrandCatId.VisibleIndex = 2;
            this.colBrandCatId.Width = 54;
            // 
            // colBCActive
            // 
            this.colBCActive.Caption = "Active";
            this.colBCActive.FieldName = "BCActive";
            this.colBCActive.Name = "colBCActive";
            this.colBCActive.OptionsEditForm.VisibleIndex = 2;
            this.colBCActive.Width = 70;
            // 
            // colActiveText
            // 
            this.colActiveText.AppearanceCell.Options.UseTextOptions = true;
            this.colActiveText.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActiveText.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colActiveText.AppearanceHeader.Options.UseTextOptions = true;
            this.colActiveText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActiveText.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colActiveText.Caption = "Active";
            this.colActiveText.FieldName = "colActiveText";
            this.colActiveText.Name = "colActiveText";
            this.colActiveText.UnboundExpression = "Iif([BCActive],\'YES\',\'NO\')";
            this.colActiveText.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colActiveText.Visible = true;
            this.colActiveText.VisibleIndex = 1;
            this.colActiveText.Width = 52;
            // 
            // ProductsCategoriesTab
            // 
            this.ProductsCategoriesTab.Controls.Add(this.groupControl3);
            this.ProductsCategoriesTab.Name = "ProductsCategoriesTab";
            this.ProductsCategoriesTab.Size = new System.Drawing.Size(799, 295);
            this.ProductsCategoriesTab.Text = "Products Categories Registration";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.panelControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(799, 295);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Brand Registration";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Exit);
            this.panelControl1.Controls.Add(this.txtBrandCateId);
            this.panelControl1.Controls.Add(this.lbBrandIdText);
            this.panelControl1.Controls.Add(this.Update);
            this.panelControl1.Controls.Add(this.lbAction);
            this.panelControl1.Controls.Add(this.Clear);
            this.panelControl1.Controls.Add(this.Delete);
            this.panelControl1.Controls.Add(this.txtNewBrandCate);
            this.panelControl1.Controls.Add(this.Add);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.CheckBrandActive);
            this.panelControl1.Location = new System.Drawing.Point(9, 38);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(783, 218);
            this.panelControl1.TabIndex = 4;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(547, 69);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 105);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtBrandCateId
            // 
            this.txtBrandCateId.Location = new System.Drawing.Point(690, 15);
            this.txtBrandCateId.Name = "txtBrandCateId";
            this.txtBrandCateId.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBrandCateId.Properties.Appearance.Options.UseBackColor = true;
            this.txtBrandCateId.Properties.ReadOnly = true;
            this.txtBrandCateId.Size = new System.Drawing.Size(88, 20);
            this.txtBrandCateId.TabIndex = 0;
            this.txtBrandCateId.TabStop = false;
            // 
            // lbBrandIdText
            // 
            this.lbBrandIdText.Location = new System.Drawing.Point(605, 18);
            this.lbBrandIdText.Name = "lbBrandIdText";
            this.lbBrandIdText.Size = new System.Drawing.Size(75, 13);
            this.lbBrandIdText.TabIndex = 4;
            this.lbBrandIdText.Text = "Brand Cate. Id:";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(234, 99);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(307, 21);
            this.Update.TabIndex = 4;
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
            this.Clear.Location = new System.Drawing.Point(234, 155);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(307, 21);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(234, 127);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(307, 21);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // txtNewBrandCate
            // 
            this.txtNewBrandCate.EnterMoveNextControl = true;
            this.txtNewBrandCate.Location = new System.Drawing.Point(234, 15);
            this.txtNewBrandCate.Name = "txtNewBrandCate";
            this.txtNewBrandCate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNewBrandCate.Size = new System.Drawing.Size(365, 20);
            this.txtNewBrandCate.TabIndex = 1;
            this.txtNewBrandCate.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtNewBrand_PreviewKeyDown);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(234, 71);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(307, 21);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(153, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Category Name:";
            // 
            // CheckBrandActive
            // 
            this.CheckBrandActive.EnterMoveNextControl = true;
            this.CheckBrandActive.Location = new System.Drawing.Point(154, 41);
            this.CheckBrandActive.Name = "CheckBrandActive";
            this.CheckBrandActive.Properties.Caption = "Active:";
            this.CheckBrandActive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CheckBrandActive.Size = new System.Drawing.Size(97, 19);
            this.CheckBrandActive.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BrandsCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 323);
            this.Controls.Add(this.BrandCategoriesTabs);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrandsCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Products Categories";
            this.Load += new System.EventHandler(this.BrandRegistration_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrandRegistration_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.BrandCategoriesTabs)).EndInit();
            this.BrandCategoriesTabs.ResumeLayout(false);
            this.ProductsCategoriesViews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCBrandsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBrands)).EndInit();
            this.ProductsCategoriesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandCateId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewBrandCate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBrandActive.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl BrandCategoriesTabs;
        private DevExpress.XtraTab.XtraTabPage ProductsCategoriesViews;
        private DevExpress.XtraTab.XtraTabPage ProductsCategoriesTab;
        private DevExpress.XtraGrid.GridControl GCBrandsCategories;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewBrands;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNewBrandCate;
        private DevExpress.XtraEditors.SimpleButton Delete;
        private DevExpress.XtraEditors.SimpleButton Add;
        private DevExpress.XtraEditors.CheckEdit CheckBrandActive;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbBrandIdText;
        private DevExpress.XtraEditors.TextEdit txtBrandCateId;
        private DevExpress.XtraEditors.LabelControl lbAction;
        private DevExpress.XtraEditors.SimpleButton Update;
        private DevExpress.XtraEditors.SimpleButton Clear;
        private DevExpress.XtraEditors.SimpleButton Exit;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandCat;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandCatId;
        private DevExpress.XtraGrid.Columns.GridColumn colBCActive;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveText;
    }
}
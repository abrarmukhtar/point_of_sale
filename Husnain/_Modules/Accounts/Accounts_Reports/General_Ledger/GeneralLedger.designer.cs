namespace Husnain
{
    partial class GeneralLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralLedger));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.opening = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Closing = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LPFrom = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ViewSLFrom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeadDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtfrom = new DevExpress.XtraEditors.DateEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opening.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LPFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSLFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.opening);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.Closing);
            this.groupControl3.Location = new System.Drawing.Point(259, 96);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(251, 100);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Balance Section";
            // 
            // opening
            // 
            this.opening.Location = new System.Drawing.Point(61, 62);
            this.opening.Name = "opening";
            this.opening.Size = new System.Drawing.Size(156, 20);
            this.opening.TabIndex = 9;
            this.opening.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 39);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Closing";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 65);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Opening";
            // 
            // Closing
            // 
            this.Closing.Location = new System.Drawing.Point(61, 36);
            this.Closing.Name = "Closing";
            this.Closing.Size = new System.Drawing.Size(156, 20);
            this.Closing.TabIndex = 0;
            this.Closing.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.LPFrom);
            this.groupControl1.Location = new System.Drawing.Point(2, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(508, 90);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Account Selection";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Account Title:";
            // 
            // LPFrom
            // 
            this.LPFrom.EnterMoveNextControl = true;
            this.LPFrom.Location = new System.Drawing.Point(82, 42);
            this.LPFrom.Name = "LPFrom";
            this.LPFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LPFrom.Properties.NullText = "Select Account...";
            this.LPFrom.Properties.View = this.ViewSLFrom;
            this.LPFrom.Size = new System.Drawing.Size(392, 20);
            this.LPFrom.TabIndex = 1;
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
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Options.UseImage = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(196, 36);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 67);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Generate";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.dtTo);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.dtfrom);
            this.groupControl2.Location = new System.Drawing.Point(2, 96);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(251, 100);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Period Section";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 65);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(12, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "To";
            // 
            // dtTo
            // 
            this.dtTo.EditValue = null;
            this.dtTo.EnterMoveNextControl = true;
            this.dtTo.Location = new System.Drawing.Point(46, 62);
            this.dtTo.Name = "dtTo";
            this.dtTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTo.Size = new System.Drawing.Size(186, 20);
            this.dtTo.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "From";
            // 
            // dtfrom
            // 
            this.dtfrom.EditValue = null;
            this.dtfrom.EnterMoveNextControl = true;
            this.dtfrom.Location = new System.Drawing.Point(46, 36);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfrom.Size = new System.Drawing.Size(186, 20);
            this.dtfrom.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.simpleButton1);
            this.groupControl4.Location = new System.Drawing.Point(2, 202);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(508, 132);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "Generate Report";
            // 
            // GeneralLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 338);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Name = "GeneralLedger";
            this.Text = "GeneralLedger";
            this.Load += new System.EventHandler(this.GeneralLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opening.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LPFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSLFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dtTo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtfrom;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit opening;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit Closing;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit LPFrom;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewSLFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colHeadDetail;
        private DevExpress.XtraEditors.GroupControl groupControl4;

    }
}
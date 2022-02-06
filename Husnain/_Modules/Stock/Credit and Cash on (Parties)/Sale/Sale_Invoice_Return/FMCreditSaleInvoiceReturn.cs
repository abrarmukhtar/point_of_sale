using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Reflection;
using DevExpress.Data.Filtering;
using System.Linq.Expressions;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Columns;
namespace Husnain
{





    public delegate void MethodInvoker();

    public partial class FMCreditSaleInvoiceReturn : DevExpress.XtraEditors.XtraForm
    {


        public FMCreditSaleInvoiceReturn()
        {

            InitializeComponent();



        }

        string filterString;
        DataSet ds = new DataSet();
        public string Term = "";
        public bool WalkIn = false;
        private void createDataTable()
        {
            DataTable dt = new DataTable("ParentTable");

            DataColumn col;
            col = new DataColumn();
            col.DataType = typeof(Decimal);
            col.ColumnName = "colProductID";
            col.Caption = "Product Code";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);


            col = new DataColumn();
            col.DataType = typeof(string);
            col.ColumnName = "colProductName";
            col.Caption = "Product Name";
            col.AutoIncrement = false;
            col.AllowDBNull = false;
            col.ReadOnly = false;
            col.Unique = true;
            dt.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(decimal);
            col.ColumnName = "colPurchPrice";
            col.Caption = "Purch. Rs.";
            col.DefaultValue = "0.00";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(decimal);
            col.ColumnName = "colSalePrice";
            col.Caption = "Sale Rs.";
            col.DefaultValue = "0.00";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);

            //col = new DataColumn();
            //col.DataType = typeof(int);
            //col.ColumnName = "colPacking";
            //col.AllowDBNull = false;
            //col.Caption = "Packing";
            //col.DefaultValue = "0";
            //col.AutoIncrement = false;
            //col.ReadOnly = false;
            //col.Unique = false;
            //dt.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "colStock";
            col.AllowDBNull = false;
            col.Caption = "Stock";
            col.DefaultValue = "0";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);

            //col = new DataColumn();
            //col.DataType = typeof(int);
            //col.ColumnName = "colPacked";
            //col.Caption = "Packed";
            //col.DefaultValue = "0";
            //col.AutoIncrement = false;
            //col.ReadOnly = false;
            //col.Unique = false;
            //dt.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(DateTime);
            col.AllowDBNull = false;
            col.DefaultValue = DateTime.Now.AddYears(4);
            col.ColumnName = "colExpiry";
            col.Caption = "Expiry";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "colQty";
            col.Caption = "Qty";
            col.DefaultValue = "0";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);


            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "colBonus";
            col.AllowDBNull = false;
            col.Caption = "B. Qty";
            col.DefaultValue = "0";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(decimal);
            col.ColumnName = "colDiscountRate";
            col.AllowDBNull = false;
            col.Caption = "Disc. %";
            col.DefaultValue = "0.00";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);

            //col = new DataColumn();
            //col.DataType = typeof(decimal);
            //col.ColumnName = "colDiscount";
            //col.AllowDBNull = false;
            //col.Caption = "Discount";
            //col.DefaultValue = "0.00";
            //col.AutoIncrement = false;
            //col.ReadOnly = false;
            //col.Unique = false;
            //dt.Columns.Add(col);

            
            col = new DataColumn();
            col.DataType = typeof(decimal);
            col.ColumnName = "colCrInvDetId";
            col.AllowDBNull = true;
            col.Caption = "Sale Invoic";
            col.DefaultValue = "0";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);


            ds.Tables.Add(dt);

        }


        

        private void test_EditValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                GridLookUpEdit editor = sender as GridLookUpEdit;

                GridView gridview = editor.Properties.View;

                //if (editor.EditValue == null || editor.EditValue.ToString() == "" || editor.Text == editor.Properties.NullText)
                //{
                //    editor.EditValue = null;
                //    this.GCViewStockItems.SetFocusedRowCellValue(colPurchPrice, 0.00);
                //    this.GCViewStockItems.SetFocusedRowCellValue(colSalePrice, 0.00);


                //}
                //else
                //{
                //this code for without using Linq to sql
                //this.GCViewStockItems.SetFocusedRowCellValue(colPurchPrice, gridview.GetFocusedRowCellValue("PurchPrice"));
                //this.GCViewStockItems.SetFocusedRowCellValue(colSalePrice, gridview.GetFocusedRowCellValue("SalePrice"));

                //geting sale and purch price using Linq to Sql


                //geting sale and purch price using Linq to Sql

                using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                {
                    foreach (spGetAllProductsInclSalesResult dr in dbContext.spGetAllProductsInclSales(Convert.ToDecimal(txtStockCode.EditValue)))
                    {

                        this.GCViewStockItems.SetFocusedRowCellValue(colPurchPrice, dr.PurchCost);
                        this.GCViewStockItems.SetFocusedRowCellValue(colSalePrice, dr.SaleCost);
                        this.GCViewStockItems.SetFocusedRowCellValue(colStock, dr.Quantity);
                        this.GCViewStockItems.SetFocusedRowCellValue(colDiscountRate, dr.DiscountRate);
                        this.GCViewStockItems.SetFocusedRowCellValue(colCrInvDetId, dr.CrInvDetId);

                    }


                    //   this.GCViewStockItems.SetFocusedRowCellValue(colPacked, dr.Packing);
                }


                
                //using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                //{
                //    Brand_Category_Product dr = (from s in dbContext.Brand_Category_Products where s.ProductId == decimal.Parse(editor.EditValue.ToString()) select s).Single();
                //    this.GCViewStockItems.SetFocusedRowCellValue(colPurchPrice, dr.PurchPrice);
                //    this.GCViewStockItems.SetFocusedRowCellValue(colSalePrice, dr.SalePrice);
                //    //    this.GCViewStockItems.SetFocusedRowCellValue(colPacked, dr.Packing);


                //    foreach (spGetAllProductsInclSalesResult s in dbContext.spGetAllProductsInclSales( Convert.ToDecimal(txtStockCode.EditValue)))
                //    {
                //        if (s.ProductId == Convert.ToDecimal(editor.EditValue))
                //        {
                //            this.GCViewStockItems.SetFocusedRowCellValue(colStock, s.Stock);
                //        }

                //    }
                  
                //}


                //}

            }
            catch (Exception ex)
            {
                GeneralAlerts.RedefinedExceptions(ex);
            }

        }


        private void repositoryItemGridLookUpEdit1_Popup(object sender, EventArgs e)
        {
            filterGridControl(sender, "ProductId", "ProductName");
        }

        private void repositoryItemGridLookUpEdit2_Popup(object sender, EventArgs e)
        {
            // filterGridControl(sender);
        }

        private void FillAccountandProducts()
        {
            using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
            {

                
                txtStockCode.Properties.DisplayMember = "CrInvId";
                txtStockCode.Properties.ValueMember = "CrInvId";
                if (WalkIn == false)
                {
                    LPTo.Properties.DisplayMember = "AccountTitle";
                    LPTo.Properties.ValueMember = "AccountId";
                    LPTo.Properties.DataSource = dbContext.spGetAccounts();

                    ColSearchWalkIn.Visible = false;
                    colSearchPhoneNo.Visible = false;

                    txtStockCode.Properties.DataSource = dbContext.GetMasterSaleParties(Term);
                    
                }
                else
                {
                    colSearchToAccount.Visible = false;
                    txtStockCode.Properties.DataSource = dbContext.GetMasterSaleWalkIn(Term);

                }

             //   this.repositoryItemGridLookUpEdit1.DataSource = dbContext.spGetAllProducts();

            }
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;


            this.repositoryItemGridLookUpEdit1.EditValueChanged += new EventHandler(test_EditValueChanged);



            this.repositoryItemGridLookUpEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(repositoryItemsGridLookEdit_EditValueChanginng);

            BeginInvoke(new MethodInvoker(() => FillAccountandProducts()));

            createDataTable();
            
            GCStockItems.DataSource = ds.Tables[0];

            ReturnDate.DateTime = DateTime.Now.AddDays(15);

            StockDate.DateTime = DateTime.Now;
            GCViewStockItems.AddNewRow();

        }


        private void filterGridControl(object sender, string opV1, string opv2)
        {

            try
            {
                //    using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                //    {
                //    GridLookUpEdit editor = sender as GridLookUpEdit;

                //        GridView gridview = this.repositoryItemGridLookUpEdit1View.DataSource as GridView;

                //FieldInfo fi = gridview.GetType().GetField("extraFilter", BindingFlags.NonPublic | BindingFlags.Instance);
                //filterString = editor.AutoSearchText;
                //BinaryOperator op1 = new BinaryOperator("ProductId", editor.AutoSearchText + "%", BinaryOperatorType.Like);
                //BinaryOperator op2 = new BinaryOperator("ProductName", "%" + editor.AutoSearchText + "%", BinaryOperatorType.Like);
                //string filterCondition = "";
                //filterCondition = new GroupOperator(GroupOperatorType.Or, new CriteriaOperator[] { op1, op2 }).ToString();

                //fi.SetValue(gridview, filterCondition);
                //MethodInfo mi = gridview.GetType().GetMethod("ApplyColumnFilterEx", BindingFlags.NonPublic | BindingFlags.Instance);

                //mi.Invoke(gridview, null);

                //        }

                GridLookUpEdit editor = sender as GridLookUpEdit;

                GridView gridview = editor.Properties.View;

                FieldInfo fi = (gridview.GetType()).GetField("extraFilter", BindingFlags.NonPublic | BindingFlags.Instance);

                filterString = editor.AutoSearchText;

                BinaryOperator op1 = new BinaryOperator(opV1, editor.AutoSearchText + "%", BinaryOperatorType.Like);
                BinaryOperator op2 = new BinaryOperator(opv2, "%" + editor.AutoSearchText + "%", BinaryOperatorType.Like);
                string filterCondition = "";
                filterCondition = new GroupOperator((GroupOperatorType.Or), new CriteriaOperator[] { op1, op2 }).ToString();

                fi.SetValue(gridview, filterCondition);
                MethodInfo mi = (gridview.GetType()).GetMethod("ApplyColumnsFilterEx", BindingFlags.NonPublic | BindingFlags.Instance);

                mi.Invoke(gridview, null);



            }
            catch (Exception ex)
            {
                GeneralAlerts.RedefinedExceptions(ex);
            }



        }

        private void repositoryItemsGridLookEdit_EditValueChanginng(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //this.Invoke((MethodInvoker) delegate {
            //    filterGridControl(sender);
            //});


            this.BeginInvoke(new MethodInvoker(() => filterGridControl(sender, "ProductId", "ProductName")));

        }
        private void GCViewStockItems_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

            if (e.Column.Name == "colSr")
            {
                e.Value = e.ListSourceRowIndex + 1;

            }


            GridView view = sender as GridView;



            if (e.Column.FieldName == "colTotal" && e.IsGetData == true)
            {

                e.Value = getTotalValue(view, e.ListSourceRowIndex);

            }
            else if (e.Column.FieldName == "colNetTotal" && e.IsGetData == true)
            {
                //   XtraMessageBox.Show("before "+ e.Column.FieldName.ToString());
                e.Value = getNetTotal(view, e.ListSourceRowIndex);

            }
            else if (e.Column.FieldName == "colDiscount" && e.IsGetData == true)
            {
                e.Value = getDiscount(view, e.ListSourceRowIndex);

            }




        }




        private decimal getTotalValue(GridView gridview, int rowIndex)
        {

            decimal purchPrice = 0.00m;
            decimal qty = 0;
            //decimal packing = 0;
            //decimal packedss = 0;
            //packing = decimal.Parse(gridview.GetListSourceRowCellValue(rowIndex, colPacking).ToString());

            //packedss = decimal.Parse(gridview.GetListSourceRowCellValue(rowIndex, colPacked).ToString());
            //qty = packing * packedss;
            qty = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colQty));
            purchPrice = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colSalePrice));

            return purchPrice * qty;
        }
        private decimal getDiscount(GridView gridview, int rowIndex)
        {
            if (gridview.RowCount == 0)
            {
                return 0.00m;
            }
            else
            {
                if (gridview.GetListSourceRowCellValue(rowIndex, colDiscountRate).ToString() == "")
                {
                    gridview.SetFocusedRowCellValue(colDiscountRate, 0);
                    return 0.00m;

                }
                else
                {
                    if (gridview.GetListSourceRowCellValue(rowIndex, colDiscountRate) == null || gridview.GetListSourceRowCellValue(rowIndex, colDiscountRate).ToString() == "0")
                    {
                        return 0.00m;
                    }
                    else
                    {
                        decimal disc = 0.00m;
                        //decimal purchPrice = 0.00m;
                        //decimal qty = 0;
                        //decimal packing = 0;
                        //decimal packedss = 0;
                        decimal amount = 0.00m;
                        //packing = decimal.Parse(gridview.GetListSourceRowCellValue(rowIndex, colPacking).ToString());

                        //packedss = decimal.Parse(gridview.GetListSourceRowCellValue(rowIndex, colPacked).ToString());
                        //qty = packing * packedss;

                        //purchPrice = decimal.Parse(gridview.GetListSourceRowCellValue(rowIndex, colPurchPrice).ToString());

                        //amount = purchPrice * qty;
                        amount = getTotalValue(gridview, rowIndex);

                        disc = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colDiscountRate));
                        return amount * (disc / 100.00m);
                    }

                }
            }
            //return 0;
        }
        private decimal getNetTotal(GridView gridview, int rowIndex)
        {
            if (gridview.RowCount == 0)
            {
                return 0.00m;
            }
            else
            {
                if (gridview.GetListSourceRowCellValue(rowIndex, colDiscountRate).ToString() == "")
                {
                    gridview.SetFocusedRowCellValue(colDiscountRate, 0.00m);

                    return 0.00m;

                }
                else
                {

                    decimal amount = 0.00m;
                    decimal discount = 0.00m;
                    amount = getTotalValue(gridview, rowIndex);
                    discount = getDiscount(gridview, rowIndex);

                    return amount - discount;
                }
            }

        }


        //this is code indivisual calculates all unbound fields
        //private decimal getTotalQty(GridView gridview, int rowIndex)
        //{

        //    if (gridview.RowCount == 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        if (gridview.GetListSourceRowCellValue(rowIndex, colPacking).ToString() == "")
        //        {
        //            gridview.SetFocusedRowCellValue(colPacking, 0);
        //            return 0;

        //        }
        //        else
        //        {
        //            if (gridview.GetListSourceRowCellValue(rowIndex, colPacking) == null || gridview.GetListSourceRowCellValue(rowIndex, colPacking).ToString() == "0")
        //            {
        //                return 0;
        //            }
        //            else
        //            {
        //                decimal packing = 0;
        //                decimal packedss = 0;
        //                //decimal qty = 0;
        //                packing = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPacking));
        //                packedss = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPacked));

        //                return packing * packedss;
        //            }
        //        }
        //    }
        //}


        //private decimal getTotalValue(GridView gridview, int rowIndex)
        //{

        //    decimal purchPrice = 0.00m;
        //    decimal qty = 0;
        //    //decimal packing = 0;
        //    //decimal packedss = 0;
        //    //packing = decimal.Parse(gridview.GetListSourceRowCellValue(rowIndex, colPacking).ToString());

        //    //packedss = decimal.Parse(gridview.GetListSourceRowCellValue(rowIndex, colPacked).ToString());
        //    //qty = packing * packedss;


        //    decimal packing = 0;
        //    decimal packedss = 0;
        //    //decimal qty = 0;
        //    packing = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPacking));
        //    packedss =Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPacked));
        //    purchPrice = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPurchPrice));

        //    qty  = (packing * packedss);

        //    //= Convert.ToDecimal(getTotalQty(gridview, rowIndex));


        //    //XtraMessageBox.Show((purchPrice * qty).ToString());
        //    return purchPrice * qty;


        //}

        //private decimal getDiscount(GridView gridview, int rowIndex)
        //{
        //    if (gridview.RowCount == 0)
        //    {
        //        return 0.00m;
        //    }
        //    else
        //    {
        //        if (gridview.GetListSourceRowCellValue(rowIndex, colDiscountRate).ToString() == "")
        //        {
        //            gridview.SetFocusedRowCellValue(colDiscountRate, 0);
        //            return 0.00m;

        //        }
        //        else
        //        {
        //            if (gridview.GetListSourceRowCellValue(rowIndex, colDiscountRate) == null || gridview.GetListSourceRowCellValue(rowIndex, colDiscountRate).ToString() == "0")
        //            {
        //                return 0.00m;
        //            }
        //            else
        //            {

        //                decimal disc = 0.00m;
        //                decimal packing = 0;
        //                decimal packedss = 0;
        //                decimal qty = 0;
        //                decimal purchPrice = 0.00m;
        //                decimal amount = 0.00m;
        //                //decimal qty = 0;
        //                packing = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPacking));
        //                packedss = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPacked));

        //                qty = (packing * packedss);

        //                //= Convert.ToDecimal(getTotalQty(gridview, rowIndex));

        //                purchPrice = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPurchPrice));


        //                amount = (purchPrice * qty);

        //                disc = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colDiscountRate));
        //                return amount * (disc / 100.00m);
        //            }
        //        }
        //    }
        //}


        //private decimal getNetTotal(GridView gridview, int rowIndex)
        //{

        //            decimal disc = 0.00m;
        //            decimal packing = 0;
        //            decimal packedss = 0;
        //            decimal qty = 0;
        //            decimal purchPrice = 0.00m;
        //            decimal amount = 0.00m;
        //            decimal discount = 0.00m;
        //            //decimal qty = 0;
        //            packing = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPacking));
        //            packedss =Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPacked));

        //            qty = (packing * packedss);

        //            //= Convert.ToDecimal(getTotalQty(gridview, rowIndex));

        //            purchPrice = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPurchPrice));


        //            amount = (purchPrice * qty);

        //            disc = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colDiscountRate));


        //            discount = amount * (disc / 100.00m);

        //            return amount - discount;

        //}

        private void GCViewStockItems_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {


            //decimal prodid = 0;
            //decimal purchp = 0.00m;
            //decimal salep = 0.00m;
            ////XtraMessageBox.Show(ro.GetFocusedRowCellValue(colProductName).ToString());
            //if (ro.GetFocusedRowCellValue(colProductName).ToString() == "" && ro.GetFocusedRowCellValue(colPacking).ToString() == "0") //|| ro.GetFocusedRowCellValue(colProductName).ToString()== "Enter Code or Name of Product")
            //{
            //    ro.DeleteSelectedRows();
            //    ro.AddNewRow();

            //    //XtraMessageBox.Show(ro.GetFocusedDataSourceRowIndex().ToString());
            //    //  GCViewStockItems.DeleteRow(ro.GetFocusedDataSourceRowIndex()+1);
            //    //XtraMessageBox.Show(//ro.GetFocusedRowCellValue(colProductName).ToString());
            //}
            //else if (ro.GetFocusedRowCellValue(colProductName).ToString() != "" && ro.GetFocusedRowCellValue(colPacking).ToString() == "0")
            //{
            //    prodid = Convert.ToDecimal(ro.GetFocusedRowCellValue(colProductName));
            //    purchp = Convert.ToDecimal(ro.GetFocusedRowCellValue(colPurchPrice));
            //    salep = Convert.ToDecimal(ro.GetFocusedRowCellValue(colSalePrice));

            //    ro.DeleteSelectedRows();
            //    ro.AddNewRow();

            //    ro.SetFocusedRowCellValue(colProductName, prodid);
            //    ro.SetFocusedRowCellValue(colPurchPrice, purchp);
            //    ro.SetFocusedRowCellValue(colSalePrice, salep);

            //    if (ro.IsNewItemRow(e.RowHandle))
            //    {

            //        BeginInvoke(new Action(() =>
            //        {
            //            ro.FocusedColumn = colPacking;
            //            ro.ShowEditor();
            //        }));
            //    }



            //    //    //  ro.FocusedColumn = ro.VisibleColumns[4];
            //    //    // XtraMessageBox.Show(ro.VisibleColumns[4].Name.ToString());
            //    //    //ro.FocusedColumn
            //    //}

            //}



        }

        private void txtTotal_EditValueChanged(object sender, EventArgs e)
        {

            if (this.txtCharges.Text == "")
            {
                this.txtCharges.Text = "0.00";

            }
            else if (this.txtDiscount.Text == "")
            {
                this.txtDiscount.Text = "0.00";
            }

            if (txtTotal.Text == "0.00")
            {
                this.txtCharges.Text = "0.00";
                this.txtDiscount.Text = "0.00";
                this.txtNetTotal.Text = "0.00";
            }
            else
            {
                decimal total = 0.0m, disRs = 0.0m, charges = 0.0m;
                try
                {
                    total = Convert.ToDecimal(this.txtTotal.Text);
                    disRs = Convert.ToDecimal(this.txtDiscount.Text);
                    charges = Convert.ToDecimal(this.txtCharges.Text);
                }
                catch (Exception ex)
                {
                    //GeneralAlerts.RedefinedExceptions(ex);
                }
                this.txtNetTotal.Text = string.Format("{0:N2}", Math.Round((total + charges) - disRs));
            }
        }

        private void GCStockItems_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void ClearGrid()
        {
            ds.Tables[0].Rows.Clear();
            this.txtNetTotal.Text = string.Format("{0:N2}", 0.00m);
            this.txtTotal.Text = string.Format("{0:N2}", 0.00m);
        }
        private void New_Click(object sender, EventArgs e)
        {

            if (XtraMessageBox.Show(PublicFunctions.ClearDialogeBoxText, PublicFunctions.ClearDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
            {

                ClearGrid();



                this.StockDate.Text = "";
                this.txtStockCode.Text = "";
                this.LPTo.EditValue = null;
                
                this.txtRemarks.Text = "";
                this.txtCharges.Text = "0.00";
                this.txtDiscount.Text = "0.00";
                FillAccountandProducts();
            }
            else
            { }


        }

        private void Save_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtStockCode.Text != "")
                {
                    if (StockDate.Text == "" || Term == "")
                    {
                        XtraMessageBox.Show("Date, Accounts details");
                    }
                    else
                    {
                        decimal? CreditSaleMasterId = 0;
                         if (XtraMessageBox.Show(PublicFunctions.SaveDialogeBoxText, PublicFunctions.SaveDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                            {
                                
                                using (System.Transactions.TransactionScope scop = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required))
                                {


                                    using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                                    {
                                        string WalkIn = null;
                                        string PhNo = null;
                                        Nullable<decimal> ToAccount = null;

                                        if (LPTo.Visible == true)
                                        {
                                            ToAccount = decimal.Parse(LPTo.EditValue.ToString());
                                        }
                                        else
                                        {
                                            ToAccount = null;
                                            WalkIn = txtWalkingName.Text;

                                            PhNo = txtPhoneNo.Text;

                                        }

                                        dbContext.sp_Master_Credit_Sale_Return_Insert(ref CreditSaleMasterId, Convert.ToDecimal(txtStockCode.EditValue), null, DateTime.Now.Date, 0, 0, Term, Convert.ToDecimal(this.txtTotal.Text), Convert.ToDecimal(this.txtCharges.Text), Convert.ToDecimal(this.txtDiscount.Text), Convert.ToDecimal(this.txtNetTotal.Text), txtRemarks.Text, ReturnDate.DateTime, ToAccount, WalkIn, PhNo);
                                        
                                        decimal ProdTotal = 0;


                                        
                                        for (int i = 0; i <= this.GCViewStockItems.RowCount - 2; i++)
                                        {
                                            DataRow r = this.GCViewStockItems.GetDataRow(i);

                                            dbContext.sp_Master_Credit_Sale_Details_Return_Insert(CreditSaleMasterId, decimal.Parse(r[colCrInvDetId.Name].ToString()),decimal.Parse(r[colProductName.Name].ToString()), decimal.Parse(r[colQty.Name].ToString()), decimal.Parse(r[colBonus.Name].ToString()), decimal.Parse(r[colPurchPrice.Name].ToString()), decimal.Parse(r[colSalePrice.Name].ToString()), decimal.Parse(getTotalValue(this.GCViewStockItems, i).ToString()), decimal.Parse(r[colDiscountRate.Name].ToString()), decimal.Parse(getDiscount(GCViewStockItems, i).ToString()), decimal.Parse(getNetTotal(GCViewStockItems, i).ToString()), null);

                                            ProdTotal = ProdTotal + (decimal.Parse(r[colPurchPrice.Name].ToString()) * decimal.Parse(r[colQty.Name].ToString()));
                                        }


                                        string remarks = "";
                                        if (txtRemarks.Text == "")
                                        { }
                                        else
                                        {
                                            remarks = " NOTE: " + txtRemarks.Text;
                                        }

                                        
                                        //dbContext.sp_Accounts_Ledgers_Insert(null, StockDate.DateTime.Date, "SALE RETURN DIFFERENT PRODUCTS AGAINST INVID"+ txtStockCode.Text + " From " + LPTo.Text + " " + remarks, CreditSaleMasterId.ToString(), "CRSALERET", Convert.ToDecimal(txtNetTotal.Text),0, true);
                                        
                                        //dbContext.sp_Accounts_Ledgers_Insert(null, StockDate.DateTime.Date, "SALE RETURN DIFFERENT PRODUCTS AGAINST INVID"+ txtStockCode.Text +" " + remarks, CreditSaleMasterId.ToString(), "CRSALERET",0, Convert.ToDecimal(txtNetTotal.Text), true);
                                        
                                        
                                    }

                                    scop.Complete();


                                }

                                XtraMessageBox.Show("Sale Return successfully Saved", "Saved");
                             
                            }
                            else
                            { }
                        

                    }
                }
            }
            catch (Exception ex)
            {
                GeneralAlerts.RedefinedExceptions(ex);

            }

        }

        private void Print_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtStockCode.Text == "")
                { }
                else
                {
                    CreditSaleInvoice2 stdreg = new CreditSaleInvoice2();

                    ReportPrintTool tool = new ReportPrintTool(stdreg);


                    stdreg.Parameters["InvFrom"].Value = txtStockCode.Text;
                    stdreg.Parameters["InvFrom"].Visible = false;

                    stdreg.Parameters["InvTo"].Value = txtStockCode.Text;
                    stdreg.Parameters["InvTo"].Visible = false;

                    //stdsb.Parameters["RegNo2"].Value = studentRegistrationNoTextEdit.Text;
                    //stdsb.Parameters["RegNo2"].Visible = false;

                    // stdreg.dlAccounts.Text = "this ";


                    tool.AutoShowParametersPanel = false;

                    tool.ShowRibbonPreviewDialog();

                }
            }
            catch (Exception ex)
            {
                GeneralAlerts.RedefinedExceptions(ex);

            }
        }

        private void GCViewStockItems_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            XtraMessageBox.Show("0");
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GCViewStockItems_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "colNetTotal")
            {
                this.txtTotal.Text = string.Format("{0:N2}", e.Column.SummaryText.Substring(4));
            }
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(PublicFunctions.ExitDialogeBoxText, PublicFunctions.ExitDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
            {
                this.Close();
            }
            else
            { }
        }

        //private void LPFrom_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (LPFrom.Text == "")
        //    { }
        //    else
        //    {
        //        ClearGrid();

        //        using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
        //        {
        //            this.repositoryItemGridLookUpEdit1.DataSource = dbContext.spGetAllProductsInclSales(Convert.ToDecimal(LPFrom.EditValue),Convert.ToDecimal(txtStockCode.EditValue));
        //        }
        //    }
        //}

        private void GCViewStockItems_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridColumn qtyColumn = GCViewStockItems.Columns[colQty.Name];
            GridColumn stockColumn = GCViewStockItems.Columns[colStock.Name];

            int pac = Convert.ToInt32(GCViewStockItems.GetRowCellValue(GCViewStockItems.FocusedRowHandle, qtyColumn));
            int stk = Convert.ToInt32(GCViewStockItems.GetRowCellValue(GCViewStockItems.FocusedRowHandle, stockColumn));

            if (pac <= 0)
            {
                e.Valid = false;
                e.ErrorText = "Quantity should be 1 or more than 1 ";
            }
            else if (pac > stk)
            {
                e.Valid = false;
                e.ErrorText = "Your given quantity is exceed from Stock that is " + stk.ToString();
            }
        }

        private void txtStockCode_EditValueChanged(object sender, EventArgs e)
        {
            if (txtStockCode.Text == "")
            { }
            else
            {
                using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                {


                    //this.repositoryItemGridLookUpEdit1.DataSource = dbContext.spGetAllPurchaseDetails(Convert.ToDecimal(txtStockCode.EditValue));

                    this.repositoryItemGridLookUpEdit1.DataSource = dbContext.spGetAllProductsInclSales(Convert.ToDecimal(txtStockCode.EditValue));

                    if (WalkIn == false)
                    {
                        GetMasterSalePartiesResult GetMasterSale = dbContext.GetMasterSaleParties(Term).Single(s => s.CrInvId == Convert.ToDecimal(txtStockCode.EditValue));
                        LPTo.EditValue = null;
                        // LPFrom.EditValue = Convert.ToDecimal(GetMasterSale.FromAccountId);
                        LPTo.EditValue = Convert.ToDecimal(GetMasterSale.ToAccountId);
                        StockDate.DateTime = Convert.ToDateTime(GetMasterSale.InvDate);
                        //Term = Convert.ToString(GetMasterSale.Term);
                        txtTotal.Text = Convert.ToString(GetMasterSale.TotalCost);
                        txtRemarks.Text = Convert.ToString(GetMasterSale.note);
                        ReturnDate.DateTime = Convert.ToDateTime(GetMasterSale.ReturnDate);

                   
                    }
                    else
                    {
                        GetMasterSaleWalkInResult GetMasterSaleWalkIn = dbContext.GetMasterSaleWalkIn(Term).Single(s => s.CrInvId == Convert.ToDecimal(txtStockCode.EditValue));
                        
                        txtWalkingName.Text = "";
                        // LPFrom.EditValue = Convert.ToDecimal(GetMasterSale.FromAccountId);
                        txtWalkingName.Text = Convert.ToString(GetMasterSaleWalkIn.WalkIn);
                        txtPhoneNo.Text = Convert.ToString(GetMasterSaleWalkIn.PhoneNo);
                        StockDate.DateTime = Convert.ToDateTime(GetMasterSaleWalkIn.InvDate);
                        //Term = Convert.ToString(GetMasterSale.Term);
                        txtTotal.Text = Convert.ToString(GetMasterSaleWalkIn.TotalCost);
                        txtRemarks.Text = Convert.ToString(GetMasterSaleWalkIn.note);
                        ReturnDate.DateTime = Convert.ToDateTime(GetMasterSaleWalkIn.ReturnDate);

                   
                    }
                   
                    

                    //ds.Tables[0].Clear();
                    //this.repositoryItemGridLookUpEdit1.DataSource = dbContext.spGetAllProductsInclSales(Convert.ToDecimal(txtStockCode.EditValue));

                    //spGetAllProductsInclSalesResult sp;
                    
                    //foreach (GetMasterCreditSaleDetailsResult s in dbContext.GetMasterCreditSaleDetails(Convert.ToDecimal(txtStockCode.EditValue)))
                    //{
                    //    sp = dbContext.spGetAllProductsInclSales( Convert.ToDecimal(txtStockCode.EditValue)).Single(x => x.ProductId == s.ProdId);

                    //    ds.Tables[0].Rows.Add(s.colProductName, s.colProductName, s.colPurchCost, s.colSaleCost, sp.Stock, s.colExpiry, s.Quantity, s.colBonus, s.colDiscountRate);

                    //}
                  
                    //this.GCStockItems.DataSource = ds.Tables[0];

                    //txtCharges.Text = string.Format("{0:N2}", GetMasterSale.OtherCharges).ToString();
                    //txtDiscount.Text = string.Format("{0:N2}", GetMasterSale.OtherDiscount).ToString();
                  

                  

                  

                   
                   


                }
            }

        }
    }
}
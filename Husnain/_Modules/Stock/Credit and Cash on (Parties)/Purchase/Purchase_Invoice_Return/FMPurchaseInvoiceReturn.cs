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


    public partial class FMPurchaseInvoiceReturn : DevExpress.XtraEditors.XtraForm
    {


        public FMPurchaseInvoiceReturn()
        {

            InitializeComponent();



        }

        string filterString;
        DataSet ds = new DataSet();
        public string Term = "";        
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
            col.Unique =true;
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

            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "colPacking";
            col.AllowDBNull = false;
            col.Caption = "Packing";
            col.DefaultValue = "0";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "colPacked";
            col.Caption = "Packed";
            col.DefaultValue = "0";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);

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

            //col = new DataColumn();
            //col.DataType = typeof(int);
            //col.ColumnName = "colQty";
            //col.Caption = "Qty";
            //col.DefaultValue = "0";
            //col.AutoIncrement = false;
            //col.ReadOnly = false;
            //col.Unique = false;
            //dt.Columns.Add(col);


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

            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "colPurchStock";
            col.AllowDBNull = true;
            col.Caption = "PurchStock";
            col.DefaultValue = "0";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(decimal);
            col.ColumnName = "colStockDetId";
            col.AllowDBNull = true;
            col.Caption = "StockDet";
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

                using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                {
                  foreach(  spGetAllPurchaseDetailsResult dr in  dbContext.spGetAllPurchaseDetails(Convert.ToDecimal(txtStockCode.EditValue)))
                  {

                      this.GCViewStockItems.SetFocusedRowCellValue(colPurchPrice, dr.PurchCost);
                      this.GCViewStockItems.SetFocusedRowCellValue(colSalePrice, dr.SaleCost);
                      this.GCViewStockItems.SetFocusedRowCellValue(colPacked, dr.packed);
                      this.GCViewStockItems.SetFocusedRowCellValue(colPurchStock, dr.Packing);
                      this.GCViewStockItems.SetFocusedRowCellValue(colDiscountRate, dr.DiscountRate);
                      this.GCViewStockItems.SetFocusedRowCellValue(colStockDetId, dr.StockDetId);

                  }
                    
                                    
                    //   this.GCViewStockItems.SetFocusedRowCellValue(colPacked, dr.Packing);
                }


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
                LPFrom.Properties.DisplayMember = "AccountTitle";
                LPFrom.Properties.ValueMember = "AccountId";
                LPFrom.Properties.DataSource = dbContext.spGetAccounts();
                //LPTo.Properties.DisplayMember = "AccountTitle";
                //LPTo.Properties.ValueMember = "AccountId";
                //LPTo.Properties.DataSource = dbContext.spGetAccounts();
                txtStockCode.Properties.DisplayMember = "stockno";
                txtStockCode.Properties.ValueMember = "stockno";

                txtStockCode.Properties.DataSource = dbContext.GetMasterPurchase(Term);
               
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


            txtStockCode.Select();
            
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



            if (e.Column.FieldName == "colQty" && e.IsGetData == true)
            {
                // XtraMessageBox.Show("0");
                e.Value = getTotalQty(view, e.ListSourceRowIndex);
            }
            else if (e.Column.FieldName == "colTotal" && e.IsGetData == true)
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


        private decimal getTotalQty(GridView gridview, int rowIndex)
        {
            if (gridview.RowCount == 0)
            {
                return 0;
            }
            else
            {
                if (gridview.GetListSourceRowCellValue(rowIndex, colPacking).ToString() == "")
                {
                   
                     gridview.SetFocusedRowCellValue(colPacking, 0);
                   return 0;

                }
                else
                {
                    if (gridview.GetListSourceRowCellValue(rowIndex, colPacking) == null || gridview.GetListSourceRowCellValue(rowIndex, colPacking).ToString() == "0")
                    {
                        return 0;
                    }
                    else
                    {
                        decimal packing = 0;
                        decimal packedss = 0;
                        //decimal qty = 0;
                        packing =Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPacking));
                        packedss = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPacked));

                        return packing * packedss;
                    }
                }
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
            qty = Convert.ToDecimal(getTotalQty(gridview, rowIndex));
            purchPrice = Convert.ToDecimal(gridview.GetListSourceRowCellValue(rowIndex, colPurchPrice)); 

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
                if (gridview.GetListSourceRowCellValue(rowIndex, colDiscountRate).ToString() == "" || gridview.GetListSourceRowCellValue(rowIndex, colPacking).ToString() == "")
                {
                    gridview.SetFocusedRowCellValue(colDiscountRate, 0.00m);
                    gridview.SetFocusedRowCellValue(colPacking, 0.00m);
                    return 0.00m;

                }
                else
                {
                   
                    //decimal purchPrice = 0.00m;
                    //decimal qty = 0;
                    //decimal packing = 0;
                    //decimal packedss = 0;
                    decimal amount = 0.00m;
                    decimal discount = 0.00m;
                    //packing = decimal.Parse(gridview.GetListSourceRowCellValue(rowIndex, colPacking).ToString());

                    //packedss = decimal.Parse(gridview.GetListSourceRowCellValue(rowIndex, colPacked).ToString());
                    //qty = packing * packedss;

                    //purchPrice = decimal.Parse(gridview.GetListSourceRowCellValue(rowIndex, colPurchPrice).ToString());

                    //amount = purchPrice * qty;


                    //disc = decimal.Parse(gridview.GetListSourceRowCellValue(rowIndex, colDiscountRate).ToString());
                    //discount = amount * (disc / 100.00m);

                    discount = getDiscount(gridview, rowIndex);
                    amount = getTotalValue(gridview, rowIndex);
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
            
            GridView ro = sender as GridView;

            
            //if (ro.IsNewItemRow(e.RowHandle))
            //{

            //    BeginInvoke(new Action(() =>
            //    {
            //        ro.FocusedColumn = colPacking;
            //        ro.ShowEditor();
            //    }));
            //}
            
            if (ro.GetFocusedRowCellValue(colPacking).ToString() == "0") //|| ro.GetFocusedRowCellValue(colProductName).ToString()== "Enter Code or Name of Product")
            {

                
            
                //XtraMessageBox.Show(ro.GetFocusedDataSourceRowIndex().ToString());
                //  GCViewStockItems.DeleteRow(ro.GetFocusedDataSourceRowIndex()+1);
                //XtraMessageBox.Show(//ro.GetFocusedRowCellValue(colProductName).ToString());
            }
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

            



                //    //  ro.FocusedColumn = ro.VisibleColumns[4];
                //    // XtraMessageBox.Show(ro.VisibleColumns[4].Name.ToString());
                //    //ro.FocusedColumn
                //}

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

            if (txtTotal.Text == "0.00" )
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
                    
                    if (Convert.ToDecimal(this.txtDiscount.Text) <= curOtherDiscount)
                    {

                        disRs = Convert.ToDecimal(this.txtDiscount.Text);

                    }
                    else
                    {
                        XtraMessageBox.Show("You can enter minimum value from " +curOtherDiscount.ToString());
                        this.txtDiscount.Text = "0.00";
                    }
                    if (Convert.ToDecimal(this.txtCharges.Text) <= curOtherCharges)
                    {

                        charges = Convert.ToDecimal(this.txtCharges.Text);

                    }
                    else
                    {
                        XtraMessageBox.Show("You can enter minimum value from "+curOtherCharges.ToString());
                        this.txtCharges.Text = "0.00";
                    }
                    
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

        private void New_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(PublicFunctions.ClearDialogeBoxText, PublicFunctions.ClearDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
            {
                ds.Tables[0].Rows.Clear();
                

                this.StockDate.Text = "";
                this.txtStockCode.Text = "";
                this.LPFrom.EditValue = null;
                //this.LPTo.EditValue = null;
                this.txtRemarks.Text = "";
                this.txtCharges.Text = "0.00";
                this.txtDiscount.Text = "0.00";
                this.txtSuppInvoice.Text = "";
                this.StockDate.Select();
            }
            else
            { }
          
        }

        private void Save_Click(object sender, EventArgs e)
        {

            
            try
            {

                if (txtReturnId.Text == "")
                {


                    if (LPFrom.EditValue == null || StockDate.Text == "")
                    {
                        XtraMessageBox.Show("Date and Accounts details is mendatory");
                    }
                    else
                    {
                        //if (LPFrom.EditValue.ToString() == LPTo.EditValue.ToString())
                        //{
                        //    XtraMessageBox.Show("Both account mustly different");
                        //}
                        //else
                        //{
                        if (XtraMessageBox.Show(PublicFunctions.SaveDialogeBoxText, PublicFunctions.SaveDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                        {

                            decimal? PurchaseMasterId = Convert.ToDecimal(txtStockCode.EditValue);
                            decimal? PurchaseMasterReturnId = 0;
                            using (System.Transactions.TransactionScope scop = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required))
                            {


                                using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                                {
                                   
                                //Master_Purchase mp =  dbContext.Master_Purchases.Single(x => x.stockno == Convert.ToDecimal(txtStockCode.EditValue));


                                //    dbContext.sp_PurchaseMaster_Update(PurchaseMasterId, decimal.Parse(LPFrom.EditValue.ToString()), null, null, txtSuppInvoice.Text, StockDate.DateTime.Date, 0, 0,(mp.TotalCost-Convert.ToDecimal(this.txtTotal.Text)), mp.OtherCharges-Convert.ToDecimal(this.txtCharges.Text), mp.OtherDiscount-Convert.ToDecimal(this.txtDiscount.Text), mp.NetTotal-Convert.ToDecimal(this.txtNetTotal.Text), txtRemarks.Text, null);
                                    
                                   
                                //    for (int i = 0; i <= this.GCViewStockItems.RowCount - 2; i++)
                                //    {
                                //        DataRow r = this.GCViewStockItems.GetDataRow(i);

                                //        Master_Purchase_Detail mpd = dbContext.Master_Purchase_Details.Single(x => x.StockDetId == Convert.ToDecimal(r[colStockDetId.Name]));

                                   
                                //        dbContext.sp_PurchaseMasterDetails_Update(Convert.ToDecimal(r[colStockDetId.Name]),PurchaseMasterId, decimal.Parse(r[colProductName.Name].ToString()), mpd.Packing-decimal.Parse(r[colPacking.Name].ToString()),mpd.Quantity- decimal.Parse(getTotalQty(GCViewStockItems, i).ToString()),mpd.Bonus-decimal.Parse(r[colBonus.Name].ToString()), decimal.Parse(r[colPurchPrice.Name].ToString()), decimal.Parse(r[colSalePrice.Name].ToString()),mpd.Total-decimal.Parse(getTotalValue(this.GCViewStockItems, i).ToString()),mpd.DiscountRate-decimal.Parse(r[colDiscountRate.Name].ToString()),mpd.DiscountValue-decimal.Parse(getDiscount(GCViewStockItems, i).ToString()),mpd.NetTotal-decimal.Parse(getNetTotal(GCViewStockItems, i).ToString()), DateTime.Parse(r[colExpiry.Name].ToString()));


                                //    }

                                   

                                    dbContext.sp_PurchaseMasterReturn_Insert(ref PurchaseMasterReturnId,PurchaseMasterId, decimal.Parse(LPFrom.EditValue.ToString()), null, null, txtSuppInvoice.Text, DateTime.Now.Date, 0, 0, Convert.ToDecimal(this.txtTotal.Text), Convert.ToDecimal(this.txtCharges.Text), Convert.ToDecimal(this.txtDiscount.Text), Convert.ToDecimal(this.txtNetTotal.Text), txtRemarks.Text, null,Term);

                                    for (int i = 0; i <= this.GCViewStockItems.RowCount - 2; i++)
                                    {
                                        DataRow r = this.GCViewStockItems.GetDataRow(i);

                                        dbContext.sp_PurchaseMasterDetailsReturn_Insert(PurchaseMasterReturnId, decimal.Parse(r[colStockDetId.Name].ToString()), decimal.Parse(r[colProductName.Name].ToString()), decimal.Parse(r[colPacking.Name].ToString()), decimal.Parse(getTotalQty(GCViewStockItems, i).ToString()), decimal.Parse(r[colBonus.Name].ToString()), decimal.Parse(r[colPurchPrice.Name].ToString()), decimal.Parse(r[colSalePrice.Name].ToString()), decimal.Parse(getTotalValue(this.GCViewStockItems, i).ToString()), decimal.Parse(r[colDiscountRate.Name].ToString()), decimal.Parse(getDiscount(GCViewStockItems, i).ToString()), decimal.Parse(getNetTotal(GCViewStockItems, i).ToString()), DateTime.Parse(r[colExpiry.Name].ToString()));
                                    }
                               

                                    string remarks = "";
                                    if (txtRemarks.Text == "")
                                    { }
                                    else
                                    {
                                        remarks = " NOTE: " + txtRemarks.Text;
                                    }


                               //     dbContext.sp_Accounts_Ledgers_Delete(PurchaseMasterId, "PURINV");
                                    //dbContext.sp_Accounts_Ledgers_Insert(Convert.ToDecimal(LPFrom.EditValue), StockDate.DateTime, "PURCHASE RETURN " + " " + remarks, PurchaseMasterReturnId.ToString(), "PURRTN", Convert.ToDecimal(txtNetTotal.Text),0, true);

                                    //dbContext.sp_Accounts_Ledgers_Insert(null, StockDate.DateTime, "PURCHASE RETURN " + " TO " + LPFrom.Text + " " + remarks, PurchaseMasterReturnId.ToString(), "PURRTN", 0, Convert.ToDecimal(txtNetTotal.Text), true);

                                }

                                scop.Complete();


                            }
                            txtReturnId.Text = PurchaseMasterReturnId.ToString();
                            XtraMessageBox.Show("Purchase Return Saved successfully", "Saving");

                        }
                        else
                        { }
                        //}

                    }

                }
                else
                {
                    XtraMessageBox.Show("Already Saved");
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
                    PurchaseInvoice stdreg = new PurchaseInvoice();

                    ReportPrintTool tool = new ReportPrintTool(stdreg);


                    stdreg.Parameters["FMStockId"].Value = txtStockCode.Text;
                    stdreg.Parameters["FMStockId"].Visible = false;

                    stdreg.Parameters["FMStockIdTo"].Value = txtStockCode.Text;
                    stdreg.Parameters["FMStockIdTo"].Visible = false;

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

        private void GCViewStockItems_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (e.Column.Name == colPacking.Name)
            {
               // XtraMessageBox.Show("colpacking");
            }
            
        }

        //private void LPTo_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (LPTo.Text == "")
        //    { }
        //    else
        //    {
        //        using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
        //        {
        //            this.repositoryItemGridLookUpEdit1.DataSource = dbContext.spGetAllProducts(Convert.ToDecimal(LPTo.EditValue));
        //        }
        //    }
        //}

        private void GCViewStockItems_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void GCViewStockItems_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            
        }

        private void GCViewStockItems_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridColumn packingColumn = GCViewStockItems.Columns[colPacking.Name];
            GridColumn stkColumn = GCViewStockItems.Columns[colPurchStock.Name];

            int pac = Convert.ToInt32(GCViewStockItems.GetRowCellValue(GCViewStockItems.FocusedRowHandle, packingColumn));
            int stk = Convert.ToInt32(GCViewStockItems.GetRowCellValue(GCViewStockItems.FocusedRowHandle, stkColumn));

            if (pac <= 0)
            {
                e.Valid = false;
                e.ErrorText = "Packing should be 1 or more than 1 ";
            }
            else if (pac > stk)
            {
                e.Valid = false;
                e.ErrorText = "Your given packing is exceed from purchase that is " + stk.ToString();
            }

        }
        decimal curOtherCharges = 0.00m;
        decimal curOtherDiscount = 0.00m;
        private void txtStockCode_EditValueChanged(object sender, EventArgs e)
        {
            if (txtStockCode.Text == "")
            { }
            else
            {

                using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                {
                    this.repositoryItemGridLookUpEdit1.DataSource = dbContext.spGetAllPurchaseDetails(Convert.ToDecimal(txtStockCode.EditValue));


                    GetMasterPurchaseResult GetMasterPurch = dbContext.GetMasterPurchase(Term).Single(s => s.stockno == Convert.ToDecimal(txtStockCode.EditValue));
                    LPFrom.EditValue = null;
                    // LPTo.EditValue = null;
                    StockDate.DateTime = Convert.ToDateTime(GetMasterPurch.ReceiveDate);
                    LPFrom.EditValue = Convert.ToDecimal(GetMasterPurch.FromAccountId);
                    //LPTo.EditValue = Convert.ToDecimal(GetMasterPurch.ToAccountId);
                    //Term = Convert.ToString(GetMasterPurch.Term);
                    txtSuppInvoice.Text = Convert.ToString(GetMasterPurch.SuppInv);
                    curOtherCharges = Convert.ToDecimal(GetMasterPurch.OtherCharges);
                    curOtherDiscount = Convert.ToDecimal(GetMasterPurch.OtherDiscount);
                    
                  //  txtTotal.Text = Convert.ToString(GetMasterPurch.TotalCost);
                //    //DataTable dt = new DataTable();
                //    //ds.Tables
                    
                //    //dt.Columns.Add(colProductName.Name, typeof(decimal));

                //    //dt.Columns.Add(colQty.Name, typeof(decimal));
                //    ds.Tables[0].Clear();
                //    foreach (GetMasterPurchaseDetailsResult s in dbContext.GetMasterPurchaseDetails(Convert.ToDecimal(txtStockCode.EditValue)))
                //    {
                        
                //        ds.Tables[0].Rows.Add(s.colProductName, s.colProductName, s.colPurchCost, s.colSaleCost, s.colPacking,s.colPacked,s.colExpiry ,s.colBonus,s.colDiscountRate);

                //    }


                //    this.GCStockItems.DataSource = ds.Tables[0];

                //    txtCharges.Text = string.Format("{0:N2}", GetMasterPurch.OtherCharges).ToString();
                //    txtDiscount.Text = string.Format("{0:N2}", GetMasterPurch.OtherDiscount).ToString();
                  
                }

               
                
            }
        }
      
    }
}
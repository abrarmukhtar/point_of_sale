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


    public partial class FMExpense : DevExpress.XtraEditors.XtraForm
    {


        public FMExpense()
        {

            InitializeComponent();



        }

        string filterString;
        DataSet ds = new DataSet();

        private void createDataTable()
        {
            DataTable dt = new DataTable("ParentTable");

            DataColumn col;
            col = new DataColumn();
            col.DataType = typeof(Decimal);
            col.ColumnName = "colID";
            col.Caption = "Expense Detail Id";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);


            col = new DataColumn();
            col.DataType = typeof(string);
            col.ColumnName = "colDescrip";
            col.Caption = "Description";
            col.AutoIncrement = false;
            col.AllowDBNull = false;
            col.ReadOnly = false;
            col.Unique =true;
            dt.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(decimal);
            col.ColumnName = "colamount";
            col.AllowDBNull = false;
            col.Caption = "Amount";
            col.DefaultValue = "0.00";
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(string);
            col.ColumnName = "colComments";
            col.Caption = "Comments";
            col.AutoIncrement = false;
            col.DefaultValue = "";
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);

            


            ds.Tables.Add(dt);

        }



       

        
        private void AddStock_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            



            createDataTable();
            GCStockItems.DataSource = ds.Tables[0];
            

            ExpenseDate.Select();
            GCViewExpenseDetails.AddNewRow();
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


                
                
            
        }



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
            
            if (ro.GetFocusedRowCellValue(colComments).ToString() == "0") //|| ro.GetFocusedRowCellValue(colProductName).ToString()== "Enter Code or Name of Product")
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

       

        private void GCStockItems_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
         
        }

        private void New_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(PublicFunctions.ClearDialogeBoxText, PublicFunctions.ClearDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
            {
                ds.Tables[0].Rows.Clear();
                ds.Tables[1].Rows.Clear();

                this.ExpenseDate.Text = "";
                this.txtExpenseSheetId.Text = "";
              
                this.txtRemarks.Text = "";
              
                this.ExpenseDate.Select();
            }
            else
            { }
          
        }

        private void Save_Click(object sender, EventArgs e)
        {


            try
            {
                if (txtExpenseSheetId.Text == "")
                {


                    if ( ExpenseDate.Text == "")
                    {
                        XtraMessageBox.Show("Date and Accounts details is mendatory");
                    }
                    else
                    {
                       
                            if (XtraMessageBox.Show(PublicFunctions.SaveDialogeBoxText, PublicFunctions.SaveDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                            {

                                decimal? ExpenseSheetId = 0;
                                using (System.Transactions.TransactionScope scop = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required))
                                {


                                    using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                                    {

                                        dbContext.sp_Master_Expense_Insert(ref ExpenseSheetId, Convert.ToDateTime(ExpenseDate.DateTime),null, Convert.ToDecimal(this.txtTotal.Text), txtRemarks.Text);

                                        for (int i = 0; i <= this.GCViewExpenseDetails.RowCount - 2; i++)
                                        {
                                            DataRow r = this.GCViewExpenseDetails.GetDataRow(i);

                                            dbContext.sp_Master_Expense_Details_Insert(ExpenseSheetId, Convert.ToDateTime(ExpenseDate.DateTime), r[colDescrip.Name].ToString(), decimal.Parse(r[colamount.Name].ToString()), r[colComments.Name].ToString());
                                        }


                                        //dbContext.sp_Accounts_Ledgers_Insert(Convert.ToDecimal(LPFrom.EditValue), ExpenseDate.DateTime, "SENT DIFFERENT PRODUCTS " + " TO " + LPTo.Text, "P.INV" + ExpenseSheetId.ToString(), "PURINV", 0, Convert.ToDecimal(txtNetTotal.Text), true);

                                        dbContext.sp_Accounts_Ledgers_Insert(null, ExpenseDate.DateTime, "FROM EXPENSE SHEET "+ this.txtRemarks.Text , "EXP" + ExpenseSheetId.ToString(), "EXPSHT",  0,Convert.ToDecimal(txtTotal.Text), true); 

                                    }

                                    scop.Complete();


                                }

                                XtraMessageBox.Show("Expense Sheet saved successfully", "Saved");
                                txtExpenseSheetId.Text = ExpenseSheetId.ToString();
                            }
                            else
                            { }
                        

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

                if (txtExpenseSheetId.Text == "")
                { }
                else
                {
                    ExpenseSheet stdreg = new ExpenseSheet();

                    ReportPrintTool tool = new ReportPrintTool(stdreg);


                    stdreg.Parameters["ExpF"].Value = txtExpenseSheetId.Text;
                    stdreg.Parameters["ExpF"].Visible = false;

                    stdreg.Parameters["ExpT"].Value = txtExpenseSheetId.Text;
                    stdreg.Parameters["ExpT"].Visible = false;

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
            if (e.Column.Name == "colamount")
            {
                this.txtTotal.Text = string.Format("{0:N0}", e.Column.SummaryText.Substring(4));
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

           
        }
      
    }
}
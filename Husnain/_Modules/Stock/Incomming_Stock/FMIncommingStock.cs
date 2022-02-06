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
using System.Data.SqlClient;
using System.Data.Linq;
using System.Numerics;
using DevExpress.XtraGrid.Views.Grid;
using System.Reflection;
using DevExpress.Data.Filtering;
namespace Husnain
{
    public partial class FMIncommingStock : DevExpress.XtraEditors.XtraForm
    {
        //private int _ticks;

        public FMIncommingStock()
        {
            InitializeComponent();
            //timer1.Start();
        }


        

        private void ClearContant()
        {
           
            SPPacking.Value = 0;
            CalPurchPrice.Value = 0.00m;
          
            txtNote.Text = "";
           
            
          //  SLBrands.Text = "";
        }


       
        private void VisibleTrue()
        {

        }
       

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearContant();
            DisableControl();
            SLProducts.Select();
        }


        private void EnableControl()
        {
          
            Add.Enabled = false;
        }
        private void DisableControl()
        {

           
            Add.Enabled = true;
        }
        public void fillBrands()
        {
             
            try
            {

                
                                
                using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                {


                    GCViewStockDetail.DataSource = dbContext.GetIncomingStockDetail();

                 

                    SLProducts.Properties.DisplayMember = "ProductName";
                    SLProducts.Properties.ValueMember = "ProductId";
                    SLProducts.Properties.DataSource = dbContext.spGetAllProductsStock();
                }
                ClearContant();
                DisableControl();
                //using (SqlConnection con = new SqlConnection(PublicFunctions.ConString))
                //{
                //    SqlDataAdapter da = new SqlDataAdapter();
                //    DataSet ds = new DataSet();
                //    SqlCommand cmd = new SqlCommand();
                //    ////to fill grid control with Brand
                //    //cmd.CommandText = "select B.BrandName, CPC.CityName, B.BrandId, B.ActiveStatus, CPC.CityId from Brand as B inner join Country_Province_Cities as CPC on B.CityId = CPC.CityId";

                //    //cmd.Connection = con;
                //    //da.SelectCommand = cmd;
                //    //da.Fill(ds, "Brand");
                //    //GCBrands.DataSource = ds.Tables["Brand"];
                //    //ViewBrands.Columns["CityId"].Visible = false;

                //    // this code to file the City
                //    cmd.CommandText = "select (BC.BrandCat +' ('+ B.BrandName+')') as Catego, BC.BrandCat, B.BrandName, M.Manufacturer,BC.BCActive ,BC.BrandCatID from Brand_Category as BC inner join Brand as B on BC.BrandId = B.BrandId inner join Manufacturer as M on M.ManufId = B.ManfId";
                //    cmd.Connection = con;
                //    da.SelectCommand = cmd;
                //    da.Fill(ds, "BrandsCate");


                //    SLCategories.Properties.DisplayMember = ds.Tables["BrandsCate"].Columns["Catego"].ToString();

                //    SLCategories.Properties.ValueMember = ds.Tables["BrandsCate"].Columns["BrandCatID"].ToString();

                //    SLCategories.Properties.DataSource = ds.Tables["BrandsCate"];

                    
                //    DisableControl();
                //}
            }
            catch (Exception ex)
            {
                GeneralAlerts.RedefinedExceptions(ex);
            }
        }

        private void BrandRegistration_Load(object sender, EventArgs e)
        {
            
            //this is set for non negative values on SpinEditor
            
         
          SPPacking.Properties.MaxValue = Int32.MaxValue;
            
          //  fillBrands();
           //BeginInvoke(new fillBrand(fillBrands));

          //  this.BeginInvoke(() => fillBrands());
          ClearContant();
          BeginInvoke(new MethodInvoker(() => fillBrands()));
          this.GCViewStockDetail.Select();
           // BeginInvoke(fillBrand);
           // fillBrands();
          
        }

      
        //private void txtFind_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtFind.Text == "")
        //        {
        //            fillBrands();
        //        }
        //        else
        //        {
        //            using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
        //            {
        //                string find = txtFind.Text;
        //                GCBrands.DataSource = dbContext.FindBrand(find, find, find);

        //            }


        //            //using (SqlConnection con = new SqlConnection(PublicFunctions.ConString))
        //            //{

        //            //    SqlCommand cmd = new SqlCommand("select B.BrandName, CPC.CityName, B.BrandId, B.ActiveStatus from Brand as B inner join Country_Province_Cities as CPC on B.CityId = CPC.CityId where B.BrandName like '%'+@BrandName+'%' OR Cast(B.BrandId as nvarchar(10)) = @BrandId OR CPC.CityName like '%'+@CityName+'%'", con);

        //            //    DataSet ds = new DataSet();

        //            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            //    string find = txtFind.Text;
        //            //    da.SelectCommand.Parameters.AddWithValue("@BrandName", find);
        //            //    da.SelectCommand.Parameters.AddWithValue("@BrandId", find);
        //            //    da.SelectCommand.Parameters.AddWithValue("@CityName", find);

        //            //    da.Fill(ds, "Brand");

        //            //    GCBrands.DataSource = ds.Tables["Brand"];
        //            //}
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        GeneralAlerts.RedefinedExceptions(ex);
        //    }
        //}

       

      

       
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (SLProducts.Text=="" || SPPacking.Value==0 )

                {
                }else{
                    using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                    {

                        if (XtraMessageBox.Show(PublicFunctions.SaveDialogeBoxText, PublicFunctions.SaveDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                        {
                            decimal? IncomingStockId = 0;
                            using (System.Transactions.TransactionScope scop = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required))
                            {



                                dbContext.sp_Master_Incoming_Stock_Insert(ref IncomingStockId, DateTime.Now.Date, Convert.ToDecimal(SLProducts.EditValue), CalPurchPrice.Value, SPPacking.Value, Convert.ToInt64(SPQuantity.Value), Convert.ToDecimal(SPAmount.Value), txtNote.Text, txtGatePass.Text);

                                string remarks = "";
                                if (txtNote.Text == "")
                                { }
                                else
                                {
                                    remarks = " NOTE: " + txtNote.Text;
                                }

                                dbContext.sp_Accounts_Ledgers_Insert(null, DateTime.Now.Date, "INCOMING STOCK " + remarks,IncomingStockId.ToString(), "INSTK", 0, Convert.ToDecimal(SPAmount.Value), true);

                                    scop.Complete();

                                    XtraMessageBox.Show(IncomingStockId.ToString());

                            }

                            
                          


                         //   dbContext.sp_Accounts_Ledgers_Insert(null, DateTime.Now.Date, "Incoming Stock "+  remarks, PurchaseMasterReturnId.ToString(), "PURRTN", 0, Convert.ToDecimal(txtNetTotal.Text), true);
                           

                        }
                    }
                    GeneralAlerts.ShowAlerts(PublicFunctions.SaveKeyPoint);
                    fillBrands();
                    SLProducts.Select();
                 
                }



            }
            catch (Exception ex)
            {
                GeneralAlerts.RedefinedExceptions(ex);
            }
        }

        
        
        private void BrandRegistration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                ExitForm();
            }
        }
        private void ExitForm()
        {
            if (XtraMessageBox.Show(PublicFunctions.ExitDialogeBoxText, PublicFunctions.ExitDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
            {
                this.Close();
            }
            else
            { }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ExitForm();
        }

       
        private void txtNewBrand_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyData == Keys.Enter) || (e.KeyData == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //_ticks++;
            
            //this.Text = _ticks.ToString();
            
            //if (this.Text == "10")
            //{
            //    this.Text = "done";
            //    timer1.Stop();
            //}
            
        }

        private void BrandsCategoriesProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void ViewBrandsProducts_CustomFilterDisplayText(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            filterGridControl(sender);
        }

        //string filterString;
        private void filterGridControl(object sender)
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
              // XtraMessageBox.Show(sender.GetType().ToString());
            //    GridLookUpEdit editor = sender as GridLookUpEdit;

                //GridView gridview = sender as GridView;

                //FieldInfo fi = (gridview.GetType()).GetField("extraFilter", BindingFlags.NonPublic | BindingFlags.Instance);

                //filterString = this.GCBrandsCategoriesProducts.AutoSearchText;

                //BinaryOperator op1 = new BinaryOperator("ProductName", editor.AutoSearchText + "%", BinaryOperatorType.Like);
                //BinaryOperator op2 = new BinaryOperator("ProductId", "%" + editor.AutoSearchText + "%", BinaryOperatorType.Like);
                //string filterCondition = "";
                //filterCondition = new GroupOperator((GroupOperatorType.Or), new CriteriaOperator[] { op1, op2 }).ToString();

                //fi.SetValue(gridview, filterCondition);
                //MethodInfo mi = (gridview.GetType()).GetMethod("ApplyColumnsFilterEx", BindingFlags.NonPublic | BindingFlags.Instance);

                //mi.Invoke(gridview, null);



            }
            catch (Exception ex)
            {
                GeneralAlerts.RedefinedExceptions(ex);
            }

        }

        private void ViewBrandsProducts_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            
            //filterGridControl(sender);
        }
        decimal curQuantity = 0.00m;
        decimal curPrice = 0.00m;
        decimal curAmount = 0.00m;

        private void SLProducts_EditValueChanged(object sender, EventArgs e)
        {
            if (SLProducts.Text == "")
            {
                curQuantity = 0.00m;
                curPrice = 0.00m;
             SPAmount.Value= 0.00m;
            }
            else
            {
                
                SPPacking.Value = 0;
                CalPurchPrice.Value = 0;
               
            }

        }

        private void SPPacking_EditValueChanged(object sender, EventArgs e)
        {
            if (SLProducts.Text == "")
            { }
            else
            {
                using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                {
                    spGetAllProductsStockResult spallProducts = dbContext.spGetAllProductsStock().SingleOrDefault(x => x.ProductId == Convert.ToDecimal(SLProducts.EditValue));

                    SPQuantity.Value =Convert.ToDecimal(spallProducts.Packing ) * SPPacking.Value;
                    CalPurchPrice.Value = Convert.ToDecimal(spallProducts.PurchPrice);
                    SPAmount.Value = Convert.ToDecimal(spallProducts.PurchPrice) * SPQuantity.Value;

                }
        }
        }

        
    }
}
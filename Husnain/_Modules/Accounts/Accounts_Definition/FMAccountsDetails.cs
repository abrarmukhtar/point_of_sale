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
    public partial class FMAccountsDetails : DevExpress.XtraEditors.XtraForm
    {
        //private int _ticks;

        public FMAccountsDetails()
        {
            InitializeComponent();
            //timer1.Start();
        }


        

        private void ClearContant()
        {
            txtNewAccountTitle.Text = "";
            txtContactName.Text = "";
            txtResAddress.Text = "";
            txtWorkAddress.Text = "";
            SLCity.EditValue = null;
            txtMobile.Text = "";
            txtMobile2.Text = "";
            txtOtherPh.Text = "";
            txtFax.Text = "";
            CalOpDr.Value = 0.00m;
            CalOpCr.Value = 0.00m;
            this.ActiveDate.DateTime = DateTime.Now;
            CalCrLimit.Value = 0.00m;
            txtRemarks.Text = "";
            CheckProductActive.Checked = false;
            txtAccountNumber.Text = "";
            txtAccountNumber.Visible = false;
            lbBrandIdText.Visible = false;
            this.SLAccountsHead.Enabled = true;
          //  SLBrands.Text = "";
        }


       
        private void VisibleTrue()
        {
            lbBrandIdText.Visible = true;
            txtAccountNumber.Visible = true;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearContant();
            DisableControl();
            txtNewAccountTitle.Select();
        }


        private void EnableControl()
        {
            Update.Enabled = true;
            Delete.Enabled = true;
            Add.Enabled = false;
        }
        private void DisableControl()
        {

            Update.Enabled = false;
            Delete.Enabled = false;
            Add.Enabled = true;
        }
        public void fillBrands()
        {
             
            try
            {

                
                                
                using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                {


                    GCBrandsCategoriesProducts.DataSource = dbContext.GetAccountsDetails();

                    SLAccountsHead.Properties.DisplayMember = "HeadDetail";
                    SLAccountsHead.Properties.ValueMember = "HeadId";
                    SLAccountsHead.Properties.DataSource = dbContext.GetAccountsHead();

                    SLCity.Properties.DisplayMember = "CityDetail";
                    SLCity.Properties.ValueMember = "CityId";
                    SLCity.Properties.DataSource = dbContext.GetCountaryProvinceCity();
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
            
     
          //  fillBrands();
           //BeginInvoke(new fillBrand(fillBrands));

          //  this.BeginInvoke(() => fillBrands());
          ClearContant();
          BeginInvoke(new MethodInvoker(() => fillBrands()));
          this.ActiveDate.DateTime = DateTime.Now;
            this.GCBrandsCategoriesProducts.Select();
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

        private void GetGridValues()
        {
            try
            {
            
                ClearContant();
                VisibleTrue();

                SLAccountsHead.EditValue = Convert.ToDecimal(ViewAccountsDetails.GetFocusedRowCellValue(colHeadId));
                txtAccountNumber.Text = Convert.ToDecimal(ViewAccountsDetails.GetFocusedRowCellValue(colAccountId)).ToString();
                txtNewAccountTitle.Text = Convert.ToString(ViewAccountsDetails.GetFocusedRowCellValue(colAccountTitle));
                txtContactName.Text = Convert.ToString(ViewAccountsDetails.GetFocusedRowCellValue(colContactName));
                txtResAddress.Text = Convert.ToString(ViewAccountsDetails.GetFocusedRowCellValue(colResAddress));
                txtWorkAddress.Text = Convert.ToString(ViewAccountsDetails.GetFocusedRowCellValue(colWorkAdd));
             SLCity.EditValue = Convert.ToDecimal(ViewAccountsDetails.GetFocusedRowCellValue(colCityId));
             txtMobile.Text = Convert.ToString(ViewAccountsDetails.GetFocusedRowCellValue(colMobile));
             txtMobile2.Text = Convert.ToString(ViewAccountsDetails.GetFocusedRowCellValue(colMobile2));
             txtOtherPh.Text = Convert.ToString(ViewAccountsDetails.GetFocusedRowCellValue(colOtherPh));
             txtFax.Text = Convert.ToString(ViewAccountsDetails.GetFocusedRowCellValue(colFax));
             
          
                CalOpDr.Value = Convert.ToDecimal(ViewAccountsDetails.GetFocusedRowCellValue(colOpdr).ToString());
              CalOpCr.Value = Convert.ToDecimal(ViewAccountsDetails.GetFocusedRowCellValue(colOpcr).ToString());
              ActiveDate.DateTime = Convert.ToDateTime(ViewAccountsDetails.GetFocusedRowCellValue(colActivedt).ToString());
             CalCrLimit.Value = Convert.ToDecimal(ViewAccountsDetails.GetFocusedRowCellValue(colLimit).ToString());
             txtRemarks.Text = Convert.ToString(ViewAccountsDetails.GetFocusedRowCellValue(colRemarks));

             CheckProductActive.Checked = Convert.ToBoolean(ViewAccountsDetails.GetFocusedRowCellValue(colAActive));
                BrandCategoriesProductsTabs.SelectedTabPageIndex = 1;
                txtNewAccountTitle.Select();
                EnableControl();

                //Old Method to get Data from grid control
            //this.txtBrandId.Text = ViewBrands.GetFocusedRowCellDisplayText("BrandId").ToString();

            //txtNewBrand.Text = ViewBrands.GetFocusedRowCellDisplayText("BrandName").ToString();
            //SLCity.EditValue = ViewBrands.GetFocusedRowCellDisplayText("CityId").ToString();
            //CheckBrandActive.Checked = bool.Parse(ViewBrands.GetFocusedRowCellValue("BActive").ToString());
                
                
            //if (txtBrandId.Text == "")
            //{ }
            //else
            //{
            //    using(PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
            //    {
            //        Brand brand = dbContext.Brands.SingleOrDefault(x => x.BrandId == decimal.Parse(txtBrandId.Text));
            //        txtNewBrand.Text = brand.BrandName;
            //        SLCity.EditValue = brand.CityId;
            //        CheckBrandActive.Checked = brand.ActiveStatus;
            //    }
            //    BrandRegistrationTabs.SelectedTabPageIndex = 1;
            //    txtNewBrand.Select();
            //    EnableControl();
            //}
            //CheckBrandActive.Checked = (bool)ViewBrands.Columns["ActiveStatus"];
            }
            catch (Exception ex)
            {
                GeneralAlerts.RedefinedExceptions(ex);
            }
        }
        
        

        private void GCBrands_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyData == Keys.Enter)
                {
                    GetGridValues();   
                }
        }

       
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccountNumber.Text == "" && SLAccountsHead.Text!="")
                {
                    using (System.Transactions.TransactionScope scop = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required))
                    {
                        using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                        {
                            decimal? accNo = 0;
                            if (XtraMessageBox.Show(PublicFunctions.SaveDialogeBoxText, PublicFunctions.SaveDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                            {


                                dbContext.sp_Accounts_Details_Insert(ref accNo, txtNewAccountTitle.Text, Convert.ToDecimal(SLAccountsHead.EditValue.ToString()), txtContactName.Text, txtResAddress.Text, txtWorkAddress.Text, "", "",txtMobile.Text, txtMobile2.Text, txtFax.Text,txtOtherPh.Text,CalOpDr.Value,CalOpCr.Value, Convert.ToDecimal(SLCity.EditValue), CheckProductActive.Checked, txtRemarks.Text, ActiveDate.DateTime,CalCrLimit.Value);
                                
                                dbContext.sp_Accounts_Ledgers_Insert(Convert.ToDecimal(accNo), DateTime.Now.Date, "OPENING BALANCE", "OAB", "OAB", 0, CalOpCr.Value - CalOpDr.Value, true);
                                scop.Complete();
                                
                            }
                            else
                            {

                            }
                        }

                    }
                    GeneralAlerts.ShowAlerts(PublicFunctions.SaveKeyPoint);
                    txtNewAccountTitle.Select();
                    txtNewAccountTitle.Text = "";

                    fillBrands();
                }
            

                

                //below  is used to update / insert data using sql command in form
                //using (SqlConnection con = new SqlConnection(PublicFunctions.ConString))
                //{
                //    con.Open();

                //        SqlCommand cmd = new SqlCommand("insert into Brand values (@BrandName,@City, @Active)", con);
                //        cmd.Parameters.AddWithValue("@BrandName", txtNewBrand.Text);
                //        cmd.Parameters.AddWithValue("@City", SLCity.EditValue);
                //        cmd.Parameters.AddWithValue("@Active", CheckBrandActive.Checked);
                //        cmd.ExecuteNonQuery();
                //        XtraMessageBox.Show("Successfully Inserted");
                //        fillBrands();
                //        txtNewBrand.Select();
                //    }
                //    else
                //    {
                //        SqlCommand cmd = new SqlCommand("update Brand set BrandName = @BrandName, ActiveStatus = @Active, CityId=@CityId where BrandId = @BrandId", con);
                //        cmd.Parameters.AddWithValue("@BrandName", txtNewBrand.Text);
                //        cmd.Parameters.AddWithValue("@Active", CheckBrandActive.Checked);
                //        cmd.Parameters.AddWithValue("@CityId", SLCity.EditValue);
                //        cmd.Parameters.AddWithValue("@BrandId", txtBrandId.Text);
                //        cmd.ExecuteNonQuery();
                //        XtraMessageBox.Show("Successfully Updated");
                //        fillBrands();
                //        BrandRegistrationTabs.SelectedTabPageIndex = 0;
                //        GCBrands.Select();
                //    }

                ////}




                // below code is practice on cuncorrency control
                //try
                //{

                //    using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                //    {
                //        try
                //        {
                //            Brand br = dbContext.Brands.First(x => x.BrandId == 10);
                //            br.BrandName = "TEST3";
                //            dbContext.SubmitChanges();
                //            fillBrands();
                //        }
                //        catch (Exception ex)
                //        {
                //            dbContext.ChangeConflicts.ResolveAll(RefreshMode.OverwriteCurrentValues);
                //            //Exception_Codes.RedefinedExceptions(ex);
                //            dbContext.SubmitChanges();
                //            fillBrands();

                //        }
                //    }


                //}
                //catch (Exception ex)
                //{
                //    Exception_Codes.RedefinedExceptions(ex);
                //}


            }
            catch (Exception ex)
            {
                GeneralAlerts.RedefinedExceptions(ex);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                //using (SqlConnection con = new SqlConnection(PublicFunctions.ConString))
                //{
                //    con.Open();
                //    if (txtBrandId.Text == "")
                //    {
                //    }
                //    else
                //    {
                //        SqlCommand cmd = new SqlCommand("delete from Brand where BrandId = @BrandId", con);
                //        cmd.Parameters.AddWithValue("@BrandId", txtBrandId.Text);
                //        cmd.ExecuteNonQuery();
                //        XtraMessageBox.Show("Successfully Deleted");
                //    }

                using(PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                {
                    try
                    {
                        if (XtraMessageBox.Show(PublicFunctions.DeleteDialogeBoxText, PublicFunctions.DeleteDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
                        {
                            Accounts_Detail AccountsDelete = dbContext.Accounts_Details.SingleOrDefault(x => x.AccountId == decimal.Parse(txtAccountNumber.Text));
                            dbContext.Accounts_Details.DeleteOnSubmit(AccountsDelete);
                            dbContext.SubmitChanges();
                            GeneralAlerts.ShowAlerts(PublicFunctions.DeleteKeyPoint);
                          //  txtFind.Text = "";
                            ClearContant();
                            fillBrands();


                            txtNewAccountTitle.Select();
                        }
                        else
                        { }
                    }catch (ChangeConflictException ex)
                        {
                            GeneralAlerts.RedefinedExceptions(ex);
                            dbContext.ChangeConflicts.ResolveAll(RefreshMode.OverwriteCurrentValues);
                            ClearContant();    
                        fillBrands();
                            BrandCategoriesProductsTabs.SelectedTabPageIndex = 0;
                            GCBrandsCategoriesProducts.Select();
                        }
                }
                    
                
            }
            catch (Exception ex)
            {
                GeneralAlerts.RedefinedExceptions(ex);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccountNumber.Text == "")
                { }
                else
                {
                    
                    using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                    {
                        try
                        {
                            using (System.Transactions.TransactionScope scop = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required))
                            {
                                if (XtraMessageBox.Show(PublicFunctions.UpdateDialogeBoxText, PublicFunctions.UpdateDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                                {
                                    //dbContext.spUpdateBrand(Decimal.Parse(txtBrandId.Text), txtNewBrand.Text, decimal.Parse(SLCity.EditValue.ToString()), CheckBrandActive.Checked);
                                    Accounts_Detail UpdateAccounts_Detail = dbContext.Accounts_Details.SingleOrDefault(x => x.AccountId == decimal.Parse(txtAccountNumber.Text));
                                    UpdateAccounts_Detail.HeadId = Convert.ToDecimal(SLAccountsHead.EditValue);
                                    UpdateAccounts_Detail.AccountTitle = txtNewAccountTitle.Text;
                                    UpdateAccounts_Detail.ContactName = txtContactName.Text;
                                    UpdateAccounts_Detail.ResAddress = txtResAddress.Text;
                                    UpdateAccounts_Detail.WorkAdd = txtWorkAddress.Text;
                                    UpdateAccounts_Detail.CityId = Convert.ToDecimal(SLCity.EditValue);

                                    UpdateAccounts_Detail.Mobile = txtMobile.Text;
                                    UpdateAccounts_Detail.Mobile2 = txtMobile2.Text;
                                    UpdateAccounts_Detail.OtherPh = txtOtherPh.Text;
                                    UpdateAccounts_Detail.Fax = txtFax.Text;
                                    UpdateAccounts_Detail.Opdr = CalOpDr.Value;
                                    UpdateAccounts_Detail.Opcr = CalOpCr.Value;
                                    UpdateAccounts_Detail.Activedt = ActiveDate.DateTime;
                                    UpdateAccounts_Detail.Limit = CalCrLimit.Value;
                                    UpdateAccounts_Detail.Remarks = txtRemarks.Text;
                                    UpdateAccounts_Detail.AActive = CheckProductActive.Checked;

                                    dbContext.SubmitChanges();

                                    GeneralAlerts.ShowAlerts(PublicFunctions.UpdateKeyPoint);

                                    dbContext.sp_Accounts_Ledgers_Delete(Convert.ToDecimal(txtAccountNumber.Text), "OAB");
                                    dbContext.sp_Accounts_Ledgers_Insert(Convert.ToDecimal(txtAccountNumber.Text), DateTime.Now.Date, "OPENING BALANCE", "OAB", "OAB", CalOpDr.Value, CalOpCr.Value, true);
                                    
                                    scop.Complete();

                                }
                                //BrandRegistrationTabs.SelectedTabPageIndex = 0;
                                
                                
                            }
                            GCBrandsCategoriesProducts.Select();
                            txtNewAccountTitle.Select();
                            ClearContant();
                            fillBrands();
                           
                        }
                        catch (ChangeConflictException ex)
                        {
                            GeneralAlerts.RedefinedExceptions(ex);
                            dbContext.ChangeConflicts.ResolveAll(RefreshMode.OverwriteCurrentValues);
                            ClearContant();
                            fillBrands();
                            BrandCategoriesProductsTabs.SelectedTabPageIndex = 0;
                            GCBrandsCategoriesProducts.Select();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                GeneralAlerts.RedefinedExceptions(ex);
            }
        }

        private void GCBrands_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GetGridValues();
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

        private void SLCity_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Left || e.KeyData == Keys.Right || e.KeyData == Keys.Down)
            {
                SLAccountsHead.ShowPopup();
            }
            
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

        string filterString;
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

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

       


        
    }
}
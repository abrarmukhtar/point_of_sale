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
    public partial class BrandsProductsGroups : DevExpress.XtraEditors.XtraForm
    {
        //private int _ticks;

        public BrandsProductsGroups()
        {
            InitializeComponent();
            //timer1.Start();
        }


        string filterString;
        DataSet ds = new DataSet();

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
            col.DataType = typeof(uint);
            col.ColumnName = "colQty";
            col.Caption = "Qty";
            col.DefaultValue = "1";
            col.AllowDBNull = false;
            col.AutoIncrement = false;
            col.ReadOnly = false;
            col.Unique = false;
            dt.Columns.Add(col);


            ds.Tables.Add(dt);

        }

        private void ClearContant()
        {
            txtNewBrandProductsSet.Text = "";
            
            CalPurchPrice.Value = 0.00m;
            CalSalePrice.Value = 0.00m;
            SPEndLimit.Value = 0;
            txtNote.Text = "";
            CheckProductActive.Checked = false;
            txtBrandProdSetId.Text = "";
            txtBrandProdSetId.Visible = false;
            lbSetIdText.Visible = false;
         
            this.GCProducts.DataSource = null;
            ds.Tables[0].Clear();
            this.GCProducts.DataSource = ds.Tables[0];
            //  SLBrands.Text = "";
        }


       
        private void VisibleTrue()
        {
            lbSetIdText.Visible = true;
            txtBrandProdSetId.Visible = true;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearContant();
            DisableControl();

            txtNewBrandProductsSet.Select();

            
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


                    GCBrandsProductsSets.DataSource = dbContext.spGetAllProductsSets();
                    this.repositoryItemGridLookUpEdit1.DataSource = dbContext.spGetAllProductsForSets(0);//.spGetAllProductsByBrandsId(Convert.ToDecimal(SLBrands.EditValue));
                   
                    DisableControl();
                }
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
        private void BrandRegistration_Load(object sender, EventArgs e)
        {
            createDataTable();
           
            GCProducts.DataSource = ds.Tables[0];
            
         

            this.repositoryItemGridLookUpEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(repositoryItemsGridLookEdit_EditValueChanginng);


           


            //using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
            //{

            //    this.repositoryItemGridLookUpEdit1.DataSource = dbContext.spGetAllProductsByBrandsId(Convert.ToDecimal(SLBrands.EditValue));

            //    ds.Tables[0].Clear();
            //    spGetGroupsProductDetailsResult sp = (spGetGroupsProductDetailsResult)dbContext.spGetGroupsProductDetails(Convert.ToDecimal(txtBrandProdSetId.Text));
            //    //this.GCProducts.DataSource = dbContext.spGetGroupsProductDetails(Convert.ToDecimal(txtBrandProdSetId.Text));

            //    this.GCProducts.DataSource = sp;
            //}


            //this is set for non negative values on SpinEditor

          SPEndLimit.Properties.MaxValue = Int32.MaxValue;
        
            
          //  fillBrands();
           //BeginInvoke(new fillBrand(fillBrands));

          //  this.BeginInvoke(() => fillBrands());
          ClearContant();
          BeginInvoke(new MethodInvoker(() => fillBrands()));
          this.GCBrandsProductsSets.Select();
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
                
    
                this.txtBrandProdSetId.Text = ViewBrandsProductsSets.GetFocusedRowCellValue(colGCProductId).ToString();
                txtNewBrandProductsSet.Text = ViewBrandsProductsSets.GetFocusedRowCellValue(colGCProductName).ToString();

                CalPurchPrice.Value = Convert.ToDecimal(ViewBrandsProductsSets.GetFocusedRowCellValue(colPurchPrice).ToString());
              CalSalePrice.Value = Convert.ToDecimal(ViewBrandsProductsSets.GetFocusedRowCellValue(colSalePrice).ToString());
                SPEndLimit.Value = Convert.ToDecimal(ViewBrandsProductsSets.GetFocusedRowCellValue(colStockEndLimit).ToString());
                txtNote.Text = Convert.ToString(ViewBrandsProductsSets.GetFocusedRowCellValue(colnote));
                CheckProductActive.Checked = bool.Parse(ViewBrandsProductsSets.GetFocusedRowCellValue(colBCPActive).ToString());
                
                BrandProductsGroupsTabs.SelectedTabPageIndex = 1;
                txtNewBrandProductsSet.Select();
                EnableControl();
                fillProductGrid();
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
                if (txtBrandProdSetId.Text == "")
                {
                    if (this.GCViewProducts.RowCount == 1 || this.GCViewProducts.RowCount == 2)
                    {
                        XtraMessageBox.Show("you mustly enter 2 or more than 2 products");
                    }
                    else
                    {
                        using (System.Transactions.TransactionScope scop = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required))
                        {

                            decimal? GPId = 0;
                            using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                            {

                                if (XtraMessageBox.Show(PublicFunctions.SaveDialogeBoxText, PublicFunctions.SaveDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                                {


                                    dbContext.sp_Brands_Products_Group_Insert(ref GPId, txtNewBrandProductsSet.Text, 0, Convert.ToDecimal(CalSalePrice.Value), Convert.ToDecimal(CalPurchPrice.Value), 1,null,null,null,Convert.ToDecimal(SPEndLimit.Value), txtNote.Text, null, CheckProductActive.Checked,null);


                                    for (int i = 0; i <= this.GCViewProducts.RowCount - 2; i++)
                                    {
                                        DataRow r = this.GCViewProducts.GetDataRow(i);

                                        dbContext.sp_Brands_Products_Group_Details_Insert(decimal.Parse(r[colProductName.Name].ToString()), decimal.Parse(r[colQty.Name].ToString()), null, GPId);
                                    }

                                }
                                else
                                {

                                }

                            }

                            scop.Complete();



                        }

                        GeneralAlerts.ShowAlerts(PublicFunctions.SaveKeyPoint);
                        txtNewBrandProductsSet.Select();
                        txtNewBrandProductsSet.Text = "";
                        
                        ClearContant();
                        fillBrands();
                    }
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
              


                    using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                    {
                        try
                        {
                            if (XtraMessageBox.Show(PublicFunctions.DeleteDialogeBoxText, PublicFunctions.DeleteDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
                            {
                                Brand_Category_Product brandDelete = dbContext.Brand_Category_Products.SingleOrDefault(x => x.ProductId == decimal.Parse(txtBrandProdSetId.Text));
                                dbContext.Brand_Category_Products.DeleteOnSubmit(brandDelete);
                                dbContext.SubmitChanges();
                                GeneralAlerts.ShowAlerts(PublicFunctions.DeleteKeyPoint);
                                //  txtFind.Text = "";
                                ClearContant();
                                fillBrands();

                                txtNewBrandProductsSet.Select();
                            }
                            else
                            { }
                        }
                        catch (ChangeConflictException ex)
                        {
                            GeneralAlerts.RedefinedExceptions(ex);
                            dbContext.ChangeConflicts.ResolveAll(RefreshMode.OverwriteCurrentValues);
                            ClearContant();
                            fillBrands();
                            BrandProductsGroupsTabs.SelectedTabPageIndex = 0;
                            GCBrandsProductsSets.Select();
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
                if (txtBrandProdSetId.Text == "")
                { }
                else
                {
                  
                        try
                        {
                            if (XtraMessageBox.Show(PublicFunctions.UpdateDialogeBoxText, PublicFunctions.UpdateDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                            {
                                //dbContext.spUpdateBrand(Decimal.Parse(txtBrandId.Text), txtNewBrand.Text, decimal.Parse(SLCity.EditValue.ToString()), CheckBrandActive.Checked);
                               // Brands_Products_Group brandCateProdUpdate = dbContext.Brands_Products_Groups.SingleOrDefault(x => x.GPId == decimal.Parse(txtBrandProdSetId.Text));
                                using (System.Transactions.TransactionScope scop = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required))
                                {
                                    using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                                    {
                                        dbContext.sp_Brands_Products_Group_Update(decimal.Parse(txtBrandProdSetId.Text), txtNewBrandProductsSet.Text, 0, CalSalePrice.Value, CalPurchPrice.Value, 1,null, null, null,SPEndLimit.Value, txtNote.Text, null,CheckProductActive.Checked,null);
                                        dbContext.sp_Brands_Products_Group_Details_Delete(decimal.Parse(txtBrandProdSetId.Text));

                                        for (int i = 0; i <= this.GCViewProducts.RowCount - 2; i++)
                                        {
                                            DataRow r = this.GCViewProducts.GetDataRow(i);

                                            dbContext.sp_Brands_Products_Group_Details_Insert(decimal.Parse(r[colProductName.Name].ToString()), decimal.Parse(r[colQty.Name].ToString()), null, decimal.Parse(txtBrandProdSetId.Text));
                                        }

                                    }
                                    scop.Complete();
                                }


                                GeneralAlerts.ShowAlerts(PublicFunctions.UpdateKeyPoint);
                               
                                //BrandRegistrationTabs.SelectedTabPageIndex = 0;
                                GCBrandsProductsSets.Select();
                                txtNewBrandProductsSet.Select();
                                ClearContant();
                                fillBrands();
                            }
                            else
                            { }
                        }
                        catch (ChangeConflictException ex)
                        {
                            GeneralAlerts.RedefinedExceptions(ex);
                            PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext();
                            dbContext.ChangeConflicts.ResolveAll(RefreshMode.OverwriteCurrentValues);
                            ClearContant();
                            fillBrands();
                            BrandProductsGroupsTabs.SelectedTabPageIndex = 0;
                            GCBrandsProductsSets.Select();
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

        private void GCViewStockItems_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.Name == "colSr")
            {
                e.Value = e.ListSourceRowIndex + 1;

            }
        }


        private void fillProductGrid()
        {
           
                using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                {



                    if (txtBrandProdSetId.Text == "")
                    {


                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add(colProductName.Name, typeof(decimal));

                        dt.Columns.Add(colQty.Name, typeof(decimal));
                        
                        foreach (spGetGroupsProductDetailsResult s in dbContext.spGetGroupsProductDetails(Convert.ToDecimal(txtBrandProdSetId.Text)))
                        {
                            dt.Rows.Add(s.colProductName, s.colQty);
                            
                        }


                        this.GCProducts.DataSource = dt;//dbContext.spGetGroupsProductDetails(Convert.ToDecimal(txtBrandProdSetId.Text));
                        
                    }
                }
            
        }
        private void SLBrands_EditValueChanged(object sender, EventArgs e)
        {
            
           
            
        }

        
    }
}
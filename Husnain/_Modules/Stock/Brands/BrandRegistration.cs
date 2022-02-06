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
    public partial class BrandRegistration : DevExpress.XtraEditors.XtraForm
    {
        //private int _ticks;
      
        public BrandRegistration()
        {
            InitializeComponent();
            //timer1.Start();
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
                
                GridLookUpEdit editor = sender as GridLookUpEdit;
                
                GridView gridview =  editor.Properties.View;
             
                FieldInfo fi = (gridview.GetType()).GetField("extraFilter", BindingFlags.NonPublic | BindingFlags.Instance);

                filterString = editor.AutoSearchText;

                BinaryOperator op1 = new BinaryOperator("CityName", editor.AutoSearchText + "%", BinaryOperatorType.Like);
                BinaryOperator op2 = new BinaryOperator("BrandName", "%" + editor.AutoSearchText + "%", BinaryOperatorType.Like);
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


        private void ClearContant()
        {
            txtNewBrand.Text = "";
            CheckBrandActive.Checked = false;
            txtBrandId.Text = "";
            txtBrandId.Visible = false;
            lbBrandIdText.Visible = false;
           LPFrom.Text = "";
        }
       
        private void VisibleTrue()
        {
            lbBrandIdText.Visible = true;
            txtBrandId.Visible = true;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearContant();
            DisableControl();
            txtNewBrand.Select();
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


                    GCBrands.DataSource = dbContext.GetBrands();
                    LPFrom.Properties.DisplayMember = "AccountTitle";
                    LPFrom.Properties.ValueMember = "AccountId";
                    LPFrom.Properties.DataSource = dbContext.spGetAccounts();
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
                //    cmd.CommandText = "select M.Manufacturer, M.ManufId, M.MActive from  Manufacturer as M where  M.MActive = 1";
                //    cmd.Connection = con;
                //    da.SelectCommand = cmd;
                //    da.Fill(ds, "Manf");


                //    LPFrom.Properties.DisplayMember = ds.Tables["Manf"].Columns["Manufacturer"].ToString();

                //    LPFrom.Properties.ValueMember = ds.Tables["Manf"].Columns["ManufId"].ToString();

                //    LPFrom.Properties.DataSource = ds.Tables["Manf"];

                    
                //}
            }
            catch (Exception ex)
            {
                GeneralAlerts.RedefinedExceptions(ex);
            }
        }

        private void BrandRegistration_Load(object sender, EventArgs e)
        {

          //  fillBrands();
           //BeginInvoke(new fillBrand(fillBrands));

          //  this.BeginInvoke(() => fillBrands());

          BeginInvoke(new MethodInvoker(() => fillBrands()));
          this.GCBrands.Select();
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
                
    
                this.txtBrandId.Text = ViewBrands.GetFocusedRowCellValue(colBrandId).ToString();
                txtNewBrand.Text = ViewBrands.GetFocusedRowCellValue(colBrandName).ToString();
                LPFrom.EditValue = ViewBrands.GetFocusedRowCellValue(colManfId).ToString();
                CheckBrandActive.Checked = bool.Parse(ViewBrands.GetFocusedRowCellValue(colActive).ToString());
                
                BrandRegistrationTabs.SelectedTabPageIndex = 1;
                txtNewBrand.Select();
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
                if (txtBrandId.Text == "")
                {

                    using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                    {

                        if (XtraMessageBox.Show(PublicFunctions.SaveDialogeBoxText, PublicFunctions.SaveDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                        {
                            Brand newBrand = new Brand
                            {
                                BrandName = txtNewBrand.Text,
                                ManfId = decimal.Parse(LPFrom.EditValue.ToString()),
                                BActive = CheckBrandActive.Checked,
                                LastUpdated = PublicFunctions.CurrentTime
                            };
                            dbContext.Brands.InsertOnSubmit(newBrand);
                            dbContext.SubmitChanges();
                            txtNewBrand.Select();
                            GeneralAlerts.ShowAlerts(PublicFunctions.SaveKeyPoint);
                            fillBrands();
                        }
                        else
                        {

                        }
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

                using(PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                {
                    try
                    {
                        if (XtraMessageBox.Show(PublicFunctions.DeleteDialogeBoxText, PublicFunctions.DeleteDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
                        {
                            Brand brandDelete = dbContext.Brands.SingleOrDefault(x => x.BrandId == decimal.Parse(txtBrandId.Text));
                            dbContext.Brands.DeleteOnSubmit(brandDelete);
                            dbContext.SubmitChanges();
                            GeneralAlerts.ShowAlerts(PublicFunctions.DeleteKeyPoint);
                          //  txtFind.Text = "";
                            fillBrands();
                            txtNewBrand.Select();
                        }
                        else
                        { }
                    }catch (ChangeConflictException ex)
                        {
                            GeneralAlerts.RedefinedExceptions(ex);
                            dbContext.ChangeConflicts.ResolveAll(RefreshMode.OverwriteCurrentValues);
                            fillBrands();
                            BrandRegistrationTabs.SelectedTabPageIndex = 0;
                            GCBrands.Select();
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
                    using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                    {
                        try
                        {
                            if (XtraMessageBox.Show(PublicFunctions.UpdateDialogeBoxText, PublicFunctions.UpdateDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                            {
                                //dbContext.spUpdateBrand(Decimal.Parse(txtBrandId.Text), txtNewBrand.Text, decimal.Parse(SLCity.EditValue.ToString()), CheckBrandActive.Checked);
                                Brand brandUpdate = dbContext.Brands.SingleOrDefault(x => x.BrandId == decimal.Parse(txtBrandId.Text));
                                brandUpdate.BrandName = txtNewBrand.Text;
                                brandUpdate.ManfId = decimal.Parse(LPFrom.EditValue.ToString());
                                brandUpdate.BActive= CheckBrandActive.Checked;
                                brandUpdate.LastUpdated = PublicFunctions.CurrentTime;
                                dbContext.SubmitChanges();

                                GeneralAlerts.ShowAlerts(PublicFunctions.UpdateKeyPoint);
                                //BrandRegistrationTabs.SelectedTabPageIndex = 0;
                                GCBrands.Select();
                                txtNewBrand.Select();
                               
                                fillBrands();
                            }
                            else
                            { }
                        }
                        catch (ChangeConflictException ex)
                        {
                            GeneralAlerts.RedefinedExceptions(ex);
                            dbContext.ChangeConflicts.ResolveAll(RefreshMode.OverwriteCurrentValues);
                            fillBrands();
                            BrandRegistrationTabs.SelectedTabPageIndex = 0;
                            GCBrands.Select();
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
                LPFrom.ShowPopup();
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

        
    }
}
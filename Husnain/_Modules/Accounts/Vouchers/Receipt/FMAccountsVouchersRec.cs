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
    public partial class FMAccountsVouchersRec : DevExpress.XtraEditors.XtraForm
    {
        //private int _ticks;

        public FMAccountsVouchersRec()
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
           

          LPFrom.Text = "";
        
          txtNarration.Text = "";
          CalAmount.Value = 0.00m;
         
        }
       
        
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearContant();
            VcDate.Text = "";
            CBVcType.SelectedText = null;
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            LPFrom.Select();
        }


        public void fillBrands()
        {
             
            try
            {
                PosDataFile_DataDataContext dbContexts = new PosDataFile_DataDataContext();
                GCVouchers.DataSource = dbContexts.spGetAllVouchersFrom();
              

                using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                {
                    

                        LPFrom.Properties.DisplayMember = "AccountTitle";
                        LPFrom.Properties.ValueMember = "AccountId";
                        LPFrom.Properties.DataSource = dbContext.spGetAccounts();
                  
                }

              
                ClearContant();
              
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
          this.GCVouchers.Select();
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

       
        private void GCBrands_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyData == Keys.Enter)
                {
                   // GetGridValues();   
                }
        }

       
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if(VcDate.Text =="" || CBVcType.Text == null|| LPFrom.Text=="" || txtNarration.Text=="" || CalAmount.Value == 0 )
                {}
                else
                {

                    using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                    {
                         decimal? Vcnum = 0;

                        if (XtraMessageBox.Show(PublicFunctions.SaveDialogeBoxText, PublicFunctions.SaveDialogeBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                        {
                            using (System.Transactions.TransactionScope scop = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required))
                            {

                                dbContext.sp_Accounts_Head_Vouchers_Insert(ref Vcnum, CBVcType.SelectedItem.ToString(), VcDate.DateTime, Convert.ToDecimal(LPFrom.EditValue), null, txtNarration.Text, CalAmount.Value);

                                dbContext.sp_Accounts_Ledgers_Insert(Convert.ToDecimal(LPFrom.EditValue), VcDate.DateTime.Date, txtNarration.Text, "VC" + Vcnum.ToString(), CBVcType.SelectedItem.ToString(), 0, CalAmount.Value, true);

                                dbContext.sp_Accounts_Ledgers_Insert(null, VcDate.DateTime.Date, txtNarration.Text +" FROM "+LPFrom.Text, "VC" + Vcnum.ToString(), CBVcType.SelectedItem.ToString(), CalAmount.Value, 0, true);
                                LPFrom.Select();
                                GeneralAlerts.ShowAlerts(PublicFunctions.SaveKeyPoint);
                                
                                
                                scop.Complete();
                            }
                            fillBrands();
                        }
                        else
                        {

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
           // GetGridValues();
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

        private string getDateContents(string type, int n)
        {
            string month = "";
            if (type == "M")
            {

                switch (n)
                {
                    case 1:
                        month = "January";
                        break;
                    case 2:
                        month = "February";
                        break;
                    case 3:
                        month = "March";
                        break;
                    case 4:
                        month = "April";
                        break;
                    case 5:
                        month = "May";
                        break;
                    case 6:
                        month = "June";
                        break;
                    case 7:
                        month = "July";
                        break;
                    case 8:
                        month = "August";
                        break;
                    case 9:
                        month = "September";
                        break;
                    case 10:
                        month = "October";
                        break;
                    case 11:
                        month = "November";
                        break;
                    case 12:
                        month = "December";
                        break;
                }
                
            }
           

            return month;
           
        }
        private void VcDate_EditValueChanged(object sender, EventArgs e)
        {
            txtMonth.Text = getDateContents("M", VcDate.DateTime.Month);
            txtDay.Text = VcDate.DateTime.DayOfWeek.ToString(); 
            txtYear.Text = VcDate.DateTime.Year.ToString();
        }

        
    }
}
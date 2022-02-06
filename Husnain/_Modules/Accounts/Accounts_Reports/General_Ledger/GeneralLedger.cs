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
using DevExpress.XtraReports.UI;

namespace Husnain
{
    public partial class GeneralLedger : DevExpress.XtraEditors.XtraForm
    {
        public GeneralLedger()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GeneralLedger_Load(object sender, EventArgs e)
        {
            using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
            {
                LPFrom.Properties.DisplayMember = "AccountTitle";
                LPFrom.Properties.ValueMember = "AccountId";
                LPFrom.Properties.DataSource = dbContext.spGetAccounts();
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (LPFrom.Text == "" || dtfrom.Text == "" || dtTo.Text == "")
                { 
                }
                else
                {
                    decimal previousbalance = 0.00m;
                    decimal betweenBalance = 0.00m;
                    decimal totalbalance = 0.00m;
                    




                    if (DateTime.Parse(dtTo.Text) >= DateTime.Parse(dtfrom.Text))
                    {
                        LedgerReport salsproduct = new LedgerReport();

                        ReportPrintTool tool = new ReportPrintTool(salsproduct);
                        //salsproduct.blc.Text = (-1075).ToString();
                        if (LPFrom.EditValue == null)
                        {
                            using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                            {

                                foreach (spGetTotalBalanceWithNullResult s in dbContext.spGetTotalBalanceWithNull())
                                {
                                    totalbalance = Convert.ToDecimal(s.TotalBalance);
                                }

                                foreach (spGetBalanceBetweenTwoDatesWithNullResult s in dbContext.spGetBalanceBetweenTwoDatesWithNull(dtfrom.DateTime, dtTo.DateTime))
                                {
                                    betweenBalance = Convert.ToDecimal(s.BetweenBalance);
                                    previousbalance = totalbalance - Convert.ToDecimal(s.BetweenBalance);
                                }

                            }
                            salsproduct.FilterString = "[trdate] Between(?dtfrm, ?dtto) And [accountno] Is Null";
                            salsproduct.lbaccNo.Visible = false;
                            salsproduct.lbTitle.Visible = false;
                        }
                        else
                        {

                            using (PosDataFile_DataDataContext dbContext = new PosDataFile_DataDataContext())
                            {

                                foreach (spGetTotalBalanceResult s in dbContext.spGetTotalBalance(Convert.ToDecimal(LPFrom.EditValue)))
                                {
                                    totalbalance = Convert.ToDecimal(s.TotalBalance);
                                }

                                foreach (spGetBalanceBetweenTwoDatesResult s in dbContext.spGetBalanceBetweenTwoDates(dtfrom.DateTime, dtTo.DateTime, Convert.ToDecimal(LPFrom.EditValue)))
                                {
                                    betweenBalance = Convert.ToDecimal(s.BetweenBalance);
                                    previousbalance = totalbalance - Convert.ToDecimal(s.BetweenBalance);
                                }

                            }

                            salsproduct.FilterString = "[trdate] Between(?dtfrm, ?dtto) And [accountno] = ?ac";

                        }

                        Closing.Text = totalbalance.ToString();
                        opening.Text = previousbalance.ToString();
                        salsproduct.Parameters["ac"].Value = Convert.ToDecimal(LPFrom.EditValue);
                        salsproduct.Parameters["ac"].Visible = false;
                        salsproduct.Parameters["dtfrm"].Value = dtfrom.DateTime.Date;
                        salsproduct.Parameters["dtfrm"].Visible = false;
                        salsproduct.Parameters["dtto"].Value = dtTo.DateTime.Date;
                        salsproduct.Parameters["dtto"].Visible = false;
                        salsproduct.Parameters["prebln"].Value = previousbalance;
                        salsproduct.Parameters["prebln"].Visible = false;
                        salsproduct.Parameters["totalbalance"].Value = totalbalance;
                        salsproduct.Parameters["totalbalance"].Visible = false;
                        salsproduct.xrBetBalance.Text = betweenBalance.ToString();
                        tool.AutoShowParametersPanel = false;

                        
                  //      [trdate] Between(?dtfrm, ?dtto) And [accountno] = ?ac


                        tool.ShowPreview();
                    }
                    else
                    {

                    }
                }
            }

            catch (Exception ex)
            {
                GeneralAlerts.RedefinedExceptions(ex);
            }
        }
    }
}
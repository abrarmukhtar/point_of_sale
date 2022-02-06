using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Husnain
{
    public partial class LedgerReport : DevExpress.XtraReports.UI.XtraReport
    {
        public LedgerReport()
        {
            InitializeComponent();
        }


        //public MainForm MdiParent { get; set; }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        private void DetailReport_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {
            prebln.Value = 0;
        }

        

      

       
    }
}

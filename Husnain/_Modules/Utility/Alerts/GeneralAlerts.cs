using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace Husnain
{
    class GeneralAlerts 
    {
        public static void RedefinedExceptions(Exception ex)
        {
            string code = ex.HResult.ToString();
            switch (code)
            {
                case "-2146233088":
                    XtraMessageBox.Show("This record is Updated\\Deleted by other User, so your changes are rollbacked. Please try again");
                    break;
                case "-2146233033":
                    XtraMessageBox.Show("Please fill all the record");
                    break;
                default:
                    XtraMessageBox.Show("Error Message: " +ex.Message+ "; Error Code "+ code);
                    break;
            }
        }


        public static void ShowAlerts(string Action)
        {
            switch (Action)
            {
                case "s":
                    XtraMessageBox.Show("Information Successfully Saved","Information", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
                    break;
                case "u":
                    XtraMessageBox.Show("Information Successfully Updated", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    break;
                case "d":
                    XtraMessageBox.Show("Information Successfully Deleted", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    break;
                default:
                    XtraMessageBox.Show(Action);
                    break;
            }
        }


        
    }
}

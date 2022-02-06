using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using System.Data;
namespace Husnain
{
    public class PublicFunctions
    {

        public static string ConString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public static string SaveKeyPoint = "s";
        public static string SaveDialogeBoxText = "Do you want to save";
        public static string SaveDialogeBoxCaption = "Saving Record";
        public static DateTime CurrentTime = DateTime.Now;

        public static string UpdateKeyPoint = "u";
        public static string UpdateDialogeBoxText = "Do you want to update";
        public static string UpdateDialogeBoxCaption = "Updating Record";
        public static string DeleteKeyPoint = "d";
        public static string DeleteDialogeBoxText = "Do you want to delete";
        public static string DeleteDialogeBoxCaption = "Deleting Record";

        public static string ExitDialogeBoxText = "Do you want to Close";
        public static string ExitDialogeBoxCaption = "Exiting";

        public static string ClearDialogeBoxText = "Do you want to Clear";
        public static string ClearDialogeBoxCaption = "Clearing";

        //this is term of invoice like credit or sale
         public static string CreditTerm = "1";
         public static string CashTerm = "2";

        public static void Connecting(string StrCMD, GridControl grids)
        {
         
            using (SqlConnection con = new SqlConnection(ConString))
            {
                SqlCommand cmd = new SqlCommand(StrCMD, con);
                con.Open();
                grids.DataSource = cmd.ExecuteReader();
            }
        }

                
    
        
    }
}

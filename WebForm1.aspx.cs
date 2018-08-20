using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WebTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            
            DateTime start = new DateTime(2015, 09, 01);
            TimeSpan span = now.Subtract(start);
            lblDateDifference.Text = span.ToString();
            tbxDateDifference.Text = span.TotalDays.ToString();
            lblDateDifference2.Text = span.TotalDays.ToString();
        }
        

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblResult.Text = HttpUtility.UrlDecode(tbxInput.Text);
            tbcInOut.Text = HttpUtility.UrlDecode(tbcInOut.Text).Substring(HttpUtility.UrlDecode(tbcInOut.Text).LastIndexOf("http") + 0);
        }

        protected void btnEncode_Click(object sender, EventArgs e)
        {
            lblResult.Text = HttpUtility.UrlEncode(tbxInput.Text);
        }

        public void DateDifference(object sender, EventArgs e)
        {
            DateTime now = new DateTime();
            DateTime start = new DateTime(2015, 09, 01);
            TimeSpan span = now.Subtract(start);
            lblDateDifference.Text = span.ToString();
            tbxDateDifference.Text = span.TotalDays.ToString();

        }

        protected void tbxInput_TextChanged(object sender, EventArgs e)
        {
            lblMisc1.Text = HttpUtility.UrlDecode(tbxInput.Text);
            tbxOutput.Text = HttpUtility.UrlDecode(tbxInput.Text).Substring(HttpUtility.UrlDecode(tbxInput.Text).LastIndexOf("http")+0);
            
            //tbxOutput.Attributes.Add("onfocus", "this.select();");
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            string url = HttpUtility.UrlDecode(tbxInput.Text).Substring(HttpUtility.UrlDecode(tbxInput.Text).LastIndexOf("http") + 0);
            Response.Redirect(url);
            //Response.Redirect(HttpUtility.UrlDecode(tbxInput.Text).Substring(HttpUtility.UrlDecode(tbxInput.Text).LastIndexOf("http") + 0));
        }

        protected void tbxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnDecode_Click(object sender, EventArgs e)
        {

        }

        protected void btnCopy_Click(object sender, EventArgs e)
        {
            tbcInOut.Focus();
        }

        protected void btnGoToPage_Click(object sender, EventArgs e)
        {

        }

        
         
       
    }
}
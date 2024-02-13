using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginS3L2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Username"] != null)
            {
                Response.Redirect("SecondPage.aspx");
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {            
            string username = txtUsername.Text;
            
            Response.Cookies["Username"].Value = username;
            Response.Redirect("SecondPage.aspx");
        }
    }
}
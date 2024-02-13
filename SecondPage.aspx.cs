using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginS3L2
{
    public partial class SecondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            
            lblUsername.Text = "Username: " + Request.Cookies["Username"].Value;

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {           
            Response.Cookies["Username"].Expires = DateTime.Now.AddYears(-1);
            Response.Redirect("Login.aspx");
        }
    }
}
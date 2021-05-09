using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultTech1
{
    public partial class LKTeacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = Page.Session["name"].ToString() + '!';

            string s = Page.Session["id"].ToString();
            
        }
    }
}
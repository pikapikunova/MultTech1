using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultTech1
{
    public partial class LKStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Label2.Text = Page.Session["name"].ToString();

            string s = Page.Session["id"].ToString();

            var context = new MediaTech1DBContext();

            Menu1.Items[1].NavigateUrl += "?id=" + s;

            int id = Convert.ToInt32(s);

            SqlDataSource2.FilterExpression = "[ID] = " + id.ToString();

        }
    }
}
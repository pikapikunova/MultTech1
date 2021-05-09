using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultTech1
{
    public partial class Auth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.ServerVariables[0].ToString();

            if (s.Contains("http://localhost:50388/LKStudent.aspx"))
            {
                Request.Cookies.Clear();
                Session.Abandon();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string log = TextBox1.Text.ToString();
            string pas = TextBox2.Text.ToString();

            var context = new MediaTech1DBContext();

            var query = from c in context.Teacher
                        where c.login == log && c.password == pas
                        select c.name;

            var query3 = from c in context.Teacher
                        where c.login == log && c.password == pas
                        select c.id;

            var query2 = from c in context.Student
                        where c.login == log && c.password == pas
                        select c.ID;

            if (query.ToList().Count != 0)
            {
                Page.Session["id"] = query3.ToList()[0];
                Page.Session["name"] = query.ToList()[0];
                Response.Redirect("LKTeacher.aspx");
            }
            else
            {
                var query1 = from c in context.Student
                             where c.login == log && c.password == pas
                             select c.name;

                if (query1.ToList().Count != 0)
                {
                    Page.Session["id"] = query2.ToList()[0];
                    Page.Session["name"] = query1.ToList()[0];
                    Response.Redirect("LKStudent.aspx");

                }
            }
        }
    }
}
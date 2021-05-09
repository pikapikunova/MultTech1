using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace MultTech1
{
    public partial class Theory : System.Web.UI.Page
    {
        static View view1 = new View();
        static int index;


        protected void Page_PreInit(object sender, EventArgs e)
        {
            var context = new MediaTech1DBContext();

            var query = from c in context.Theory
                        select c.paragraph;
            

            var im = from c in context.Theory
                         select c.image;

            var vid = from c in context.Theory
                     select c.video;

            var aud = from c in context.Theory
                     select c.audio;

            var gif = from c in context.Theory
                      select c.gif;

            

            index = query.ToList().Count();

            for (int i = 0; i < index; i++)
            {

                HtmlGenericControl control = new HtmlGenericControl();
                HtmlGenericControl controlImg = new HtmlGenericControl();
                HtmlGenericControl controlAudio = new HtmlGenericControl();
                HtmlGenericControl controlVideo = new HtmlGenericControl();
                HtmlGenericControl controlGif = new HtmlGenericControl();

                view1 = new View();
                view1.Controls.Add(control);
                view1.Controls.Add(controlImg);
                view1.Controls.Add(controlAudio);
                view1.Controls.Add(controlVideo);
                view1.Controls.Add(controlGif);


                MultiView1.Views.Add(view1);

                control.InnerHtml = "<div>" + query.ToList()[i].ToString() + "</div>";

                if (im.ToList()[i] != null)
                    controlImg.InnerHtml = "<img src=" + im.ToList()[i].ToString() + "> ";
               
                if (aud.ToList()[i] != null)
                    controlAudio.InnerHtml = "<audio controls> <source src=" + aud.ToList()[i].ToString() + "> </audio> ";

                if (vid.ToList()[i] != null)
                    controlVideo.InnerHtml = "<video controls width=/'/300/'/ height=/'/200/'/ src =" + vid.ToList()[i].ToString() + "></ video >";

                if (gif.ToList()[i] != null)
                    controlGif.InnerHtml = "<img src=" + gif.ToList()[i].ToString() + "> ";
                
            }

            string s = Request.ServerVariables[0].ToString();

            if (s.Contains("http://localhost:50388/Test.aspx"))
                MultiView1.ActiveViewIndex = Convert.ToInt32(Request.QueryString["idOfTheory"]);
            else
                MultiView1.ActiveViewIndex = 0;

            Button2.Visible = false;

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            MultiView1.ActiveViewIndex++;

            if (MultiView1.ActiveViewIndex == index - 1)
                Button1.Visible = false;

            if (MultiView1.ActiveViewIndex != 0)
                     Button2.Visible = true;

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex--;

            if (MultiView1.ActiveViewIndex < index - 1)
                Button1.Visible = true;

            if (MultiView1.ActiveViewIndex == 0)
                Button2.Visible = false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace MultTech1
{
    public partial class Test : System.Web.UI.Page
    {
        static View view1 = new View();
        static int index;
        static View[] views;
        static int[] test;



        protected void Page_PreInit(object sender, EventArgs e)
        {
            var context = new MediaTech1DBContext();

            var ques = from c in context.Questions
                        select c.ques;

            var falseAnsw = from c in context.Answers
                        select c.falseAnsw;

            var trueAnsw = from c in context.Answers
                        select c.trueAnsw;

            var radioB = from c in context.Answers
                         select c.radioBut;

            var checkB = from c in context.Answers
                         select c.checkBox;

            var textB = from c in context.Answers
                                select c.texBox;

            
            index = ques.ToList().Count();
            
            views = new View[index];

            if (!IsPostBack)
            {
                test = new int[index];
                for (int i = 0; i < index; i++)
                    test[i] = -1;
            }


            for (int i = 0; i < index; i++)
            {

                string[] fAnsw = new string[0];

                if (falseAnsw.ToList()[i] != null)
                {
                    fAnsw = falseAnsw.ToList()[i].Split(';');

                    for (int j = 0; j < fAnsw.Length; j++)
                    {
                        fAnsw[j] = fAnsw[j].Trim(' ');
                    }
                }

                string[] tAnsw = trueAnsw.ToList()[i].Split(';');

                for (int j = 0; j < tAnsw.Length; j++)
                {
                    tAnsw[j] = tAnsw[j].Trim(' ');
                }

                string[] answ = fAnsw.Union(tAnsw).ToArray();



                if (!IsPostBack)
                {
                    Random rand = new Random();
                    for (int j = 0; j < answ.Length; j++)
                    {
                        int t = rand.Next(0, j);
                        string temp = answ[j];
                        answ[j] = answ[t];
                        answ[t] = temp;
                    }
                }

                views[i] = new View();
                Label lbl = new Label();

                lbl.Text = ques.ToList()[i].ToString();
                views[i].Controls.Add(lbl);

                if (Convert.ToBoolean(radioB.ToList()[i]))
                {
                    RadioButtonList rbList = new RadioButtonList();

                    views[i].Controls.Add(rbList);

                    for (int j = 0; j < answ.Length; j++)
                        rbList.Items.Add(answ[j]);
                }
                else
                {
                    if (Convert.ToBoolean(checkB.ToList()[i]))
                    {
                        CheckBoxList chbList = new CheckBoxList();

                        views[i].Controls.Add(chbList);

                        for (int j = 0; j < answ.Length; j++)
                            chbList.Items.Add(answ[j]);
                    }
                    else
                    {
                        if (Convert.ToBoolean(textB.ToList()[i]))
                        {
                            TextBox textb = new TextBox();
                            views[i].Controls.Add(textb);
                        }
                    }
                }

                MultiView1.Views.Add(views[i]);
            }
            
            MultiView1.ActiveViewIndex = 0;
            
            Button2.Visible = false;

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex--;

            if (MultiView1.ActiveViewIndex < index - 1)
                Button1.Visible = true;

            if (MultiView1.ActiveViewIndex == 0)
                Button2.Visible = false;

            if (test[MultiView1.ActiveViewIndex] == -1)
                Button3.Visible = true;
            else
                Button3.Visible = false;

            //Button3.Text = test[MultiView1.ActiveViewIndex].ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex++;

            if (MultiView1.ActiveViewIndex == index - 1)
            {
                Button1.Visible = false;
                Button4.Visible = true;
            }

            if (MultiView1.ActiveViewIndex != 0)
                Button2.Visible = true;

            if (test[MultiView1.ActiveViewIndex] == -1)
                Button3.Visible = true;
            else
                Button3.Visible = false;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            var context = new MediaTech1DBContext();

            Label lbl = views[MultiView1.ActiveViewIndex].FindControl(views[MultiView1.ActiveViewIndex].Controls[0].ClientID) as Label;

            var answ = from c in context.Questions
                         where c.ques == lbl.Text
                         select c.answers_id;

            var idOfTheory = from c in context.Questions
                             where c.ques == lbl.Text
                             select c.theory_id;


            int a = answ.ToList()[0];
            int idOfTh = idOfTheory.ToList()[0];



            var trueAnsw = from c in context.Answers
                           where c.id == a
                           select c.trueAnsw;
            
            var radioB = from c in context.Answers
                         where c.id == a
                         select c.radioBut;

            var checkB = from c in context.Answers
                         where c.id == a
                         select c.checkBox;

            var textB = from c in context.Answers
                        where c.id == a
                        select c.texBox;

            string idOfAnsw = views[MultiView1.ActiveViewIndex].Controls[1].ClientID;
            List<string> list = new List<string>();

            Label label = new Label();

            if (Convert.ToBoolean(radioB.ToList()[0]))
            {
                RadioButtonList t = views[MultiView1.ActiveViewIndex].FindControl(idOfAnsw) as RadioButtonList;

                list.Add(t.SelectedValue);

                if (list[0] == trueAnsw.ToList()[0].Trim(' '))
                    funForTrue(label);
                else
                    funForFalse(label, idOfTh);
                
            }
            else
            {
                if (Convert.ToBoolean(checkB.ToList()[0]))
                {
                    CheckBoxList t = views[MultiView1.ActiveViewIndex].FindControl(idOfAnsw) as CheckBoxList;

                    for (int i = 0; i < t.Items.Count; i++)
                    {
                        if (t.Items[i].Selected)
                        {
                            list.Add(t.Items[i].Text);  
                        }
                    }

                    string[] tAnsw = trueAnsw.ToList()[0].Split(';');

                    for (int j = 0; j < tAnsw.Length; j++)
                    {
                        tAnsw[j] = tAnsw[j].Trim(' ');
                    }

                    int k = 0;
                    for (int i = 0; i < list.Count; i++)
                        for (int j = 0; j < tAnsw.Length; j++)
                        {
                            if (list[i] == tAnsw[j])
                                k++;
                        }
     
                    if (k == list.Count && k == tAnsw.Length)
                    {
                        funForTrue(label);
                    }
                    else
                    {
                        funForFalse(label, idOfTh); 
                    }
                }
                else
                {
                    if (Convert.ToBoolean(textB.ToList()[0]))
                    {
                        TextBox t = views[MultiView1.ActiveViewIndex].FindControl(idOfAnsw) as TextBox;

                        list.Add(t.Text);

                        if (list[0] == trueAnsw.ToList()[0].Trim())
                            funForTrue(label);
                        else
                            funForFalse(label, idOfTh);
                    }
                }
            }
            
        }

        void funForTrue(Label label)
        {
            label.Text = "Ответ верный!";
            Button3.Visible = false;

            views[MultiView1.ActiveViewIndex].Controls.Add(label);
            test[MultiView1.ActiveViewIndex] = 1;
            
        }

        void funForFalse(Label label, int idOfTh)
        {
            label.Text = "Ответ неверный!";
            Button3.Visible = false;

            HyperLink hype = new HyperLink();
            hype.Text = "Перейти к теории";
            
            hype.NavigateUrl = "/Theory.aspx?idOfTheory= " + idOfTh.ToString();

            views[MultiView1.ActiveViewIndex].Controls.Add(label);
            views[MultiView1.ActiveViewIndex].Controls.Add(hype);

            test[MultiView1.ActiveViewIndex] = 0;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label newLbl = new Label();
            int k = 0;
            for (int i = 0; i < index; i++)
                if (test[i] != -1)
                    k += test[i];
            newLbl.Text = "Ваш результат " + k + " баллов из " + index;
            views[MultiView1.ActiveViewIndex].Controls.Add(newLbl);
            Button3.Visible = false;
            Button2.Visible = false;
            Button1.Visible = false;
            
            int s = Convert.ToInt32(Request.QueryString["id"]);

            var context = new MediaTech1DBContext();

            var query = context.Student.Single(c => c.ID == s);
            query.marks = k;

            var query1 = context.Student.Single(c => c.ID == s);
            query.dateOfTest = DateTime.Today;

            context.SaveChanges();

            Button4.Visible = false;
                         
        }
    }
}
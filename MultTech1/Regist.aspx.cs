using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultTech1
{
    public partial class Regist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var context = new MediaTech1DBContext();

            string log = TextBox4.Text.ToString();
            string pas = TextBox5.Text.ToString();

            var query = from c in context.Student
                         where c.login == log || c.password == pas
                         select c.ID;

            var query1 = from c in context.Teacher
                        where c.login == log || c.password == pas
                        select c.id;

            if (query.ToList().Count == 0 && query1.ToList().Count == 0)
            {
                if (RadioButtonList1.SelectedItem.ToString() == "Студент")
                    context.Student.Add(new Student { name = TextBox1.Text.ToString(), surname = TextBox2.Text.ToString(), patronymic = TextBox3.Text.ToString(), login = TextBox4.Text.ToString(), password = TextBox5.Text.ToString(), dateOfTest = null, marks = null });
                else
                    context.Teacher.Add(new Teacher { name = TextBox1.Text.ToString(), surname = TextBox2.Text.ToString(), patronymic = TextBox3.Text.ToString(), login = TextBox4.Text.ToString(), password = TextBox5.Text.ToString() });

                Button1.Visible = false;

                Label7.Text = "Вы успешно зарегистрировались!";

                context.SaveChanges();
            }
            else
                Label7.Text = "Такой логин или пароль уже существует";
        }
    }
}
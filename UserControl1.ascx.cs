using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControl1 : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        //UserControl uc1 = (UserControl)LoadControl("UserControl1.ascx");
        //Page.Form.Controls.Add(uc1);
        //TextBox TextBox1 = (TextBox)uc1.FindControl("TextBox1");
        Session["number1"] = Convert.ToInt32(TextBox1.Text);
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        //UserControl uc1 = (UserControl)LoadControl("UserControl1.ascx");
        //Page.Form.Controls.Add(uc1);
        //TextBox TextBox2 = (TextBox)uc1.FindControl("TextBox2");
        Session["number2"] = Convert.ToInt32(TextBox2.Text);
    }
}
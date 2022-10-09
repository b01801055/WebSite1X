using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControl3 : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button5_Click(object sender, EventArgs e)
    {


        switch (Session["math"])
        {
            case "+":
                Session["result"] = Convert.ToInt32(Session["number1"]) + Convert.ToInt32(Session["number2"]);
                break;
            case "-":
                Session["result"] = Convert.ToInt32(Session["number1"]) - Convert.ToInt32(Session["number2"]);
                break;
            case "*":
                Session["result"] = Convert.ToInt32(Session["number1"]) * Convert.ToInt32(Session["number2"]);
                break;
            case "/":
                Session["result"] = Convert.ToDouble(Convert.ToInt32(Session["number1"])) / Convert.ToInt32(Session["number2"]);
                break;
            default:
                Session["result"] = 0;
                break;
        }

        //UserControl uc3 = (UserControl)LoadControl("UserControl3.ascx");
        //Page.Form.Controls.Add(uc3);
        //Label Label1 = (Label)uc3.FindControl("Label1");
        Label1.Text = Session["result"].ToString();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControl2 : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        switch (btn.Text.ToString())
        {
            case "+":
                Session["math"] = "+";

                break;
            case "-":
                Session["math"] = "-";
                break;
            case "*":
                Session["math"] = "*";
                break;
            case "/":
                Session["math"] = "/";
                break;
            default:
                Session["math"] = "@";
                break;
        }
    }
}
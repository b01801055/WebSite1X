using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2: System.Web.UI.Page
{
    int number1;
    int number2;
    double result;
    //string math;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        //Session.Timeout = 30;//更改Session過期時間
        //Session.Remove("yoyo");//移除 Session["yoyo"]的值
        //Session.RemoveAll();//移除所有Session變數
        //Session.Clear(); //移除所有Session變數
        //Session.Abandon();/
    }

    protected void Button5_Click(object sender, EventArgs e)
    {


        switch (Session["math"])
        {
            case "+":
                result = Convert.ToInt32(Session["number1"]) + Convert.ToInt32(Session["number2"]);
                break;
            case "-":
                result = Convert.ToInt32(Session["number1"]) - Convert.ToInt32(Session["number2"]);
                break;
            case "*":
                result = Convert.ToInt32(Session["number1"]) * Convert.ToInt32(Session["number2"]);
                break;
            case "/":
                result = Convert.ToDouble(Convert.ToInt32(Session["number1"])) / Convert.ToInt32(Session["number2"]);
                break;
            default:
                result = 0;
                break;
        }
        Usercontrol3 usercontrol3 = UserControl
        Label1.Text = result.ToString();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
        Session["number1"] = Convert.ToInt32(TextBox1.Text);
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        Session["number2"] = Convert.ToInt32(TextBox2.Text);
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        switch (btn.Text.ToString())
        {
            case "+":
                Session["math"] = "+";
                //Response.Write(number1 + math + number2);
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
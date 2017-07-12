using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
int  a=10 , b = 5;
        int c = a + b;
        Response.Write("Sum is" +" = "+ c+"</br>");
        c = a - b;
        Response.Write("Subs. is " + " = " + c+"</br>");
        c = a * b;
        Response.Write("Mul. is " + " = " + c+"</br>");
        c = a / b;
        Response.Write("Div. is " + " = " + c+"</br>");
        string str = "Hello";
        Response.Write("String is " + str+"</br>");
        int x = 1;
        while (x < 5)
        {
            Response.Write(x);
            x = x + 1;
        }
        Response.Write("</br>");
        do
        {
            Response.Write(x);
            x = x + 1;
        } while (x <= 9);
    }
}
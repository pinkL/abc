using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ceshi : System.Web.UI.Page
{
    static int a = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        string url = Request.Url.ToString();// HttpContext.Current.Request.Url.PathAndQuery.ToString();
        Label1.Text = url;
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if(Session["name"]==null)
        {
            Response.Redirect("Default.aspx");

        }
     
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)  
{  
   ViewState["no"] = DataList1.SelectedIndex.ToString();  
   DataList1.DataBind();  
}  
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)  
{  
      LinkButton linbtn = (LinkButton)e.Item.FindControl("LinkButton1");  
     linbtn.ForeColor = System.Drawing.Color.Blue;  
     if (ViewState["no"] != null)  
     {  
         if (e.Item.ItemIndex == Convert.ToInt16(ViewState["no"]))  
linbtn.ForeColor = System.Drawing.Color.Red;  
    }  
}


    
}
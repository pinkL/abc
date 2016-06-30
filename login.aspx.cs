using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
{
     int uid ;

    protected void Page_Load(object sender, EventArgs e)
    {
      conn = new SqlConnection("server=LUSHAN-PC\\SQLEXPRESS;database=part-time-job;uid=sa;pwd=1995217ls");
      txtName.Attributes.Add("value","请输入手机号/邮箱");
      txtName.Attributes.Add("onfocus", "if(this.value=='请输入手机号/邮箱'){this.value=''}");
      txtName.Attributes.Add("onblur", "if(this.value==''){this.value='请输入手机号/邮箱'}");
    }
    SqlConnection conn;
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        if(txtName.Text.Trim () ==""||txtPass.Text.Trim()=="")
        {
            Response.Write("<script>alert('用户名或密码不能为空!')</script>");
           
        }
        else
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from userlist where uname='" + txtName.Text.Trim() + "' and upsw='" + txtPass.Text.Trim() + "'", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    sdr.Close();
                   
                   SqlCommand  cmd1 = new SqlCommand("select uid from userlist where uname='" + txtName.Text.Trim() + "' and upsw='" + txtPass.Text.Trim() + "'", conn);
                    uid = (int)cmd1.ExecuteScalar();
                    conn.Close();
                   // Lable1.Text = userid.ToString();
                    Session["userid"] = uid ;
                    Session["uname"] = txtName.Text.Trim();
                    
                    if(Session["aa"]=="1")//zhiwei
                    {
                        Response.Redirect("~/position.aspx");
                    }
                    if(Session["bb"]=="2")
                    {
                        Response.Redirect("~/search.aspx");
                    }
                   if (Session["cc"]=="3")
                   {
                       Response.Redirect("~/CompusRecruitment.aspx");
                      
                   }
                    if(Session["dd"]=="4")
                    {
                        Response.Redirect("~/findjjob.aspx");
                    }
                    if(Session["ee"]=="5")
                    {
                        Response.Redirect("~/findqjob.aspx");
                    }
                    if(Session["ff"]=="6")
                    {
                        Response.Redirect("~/result.aspx");
                    }
                    else
                    Response.Redirect("~/homePage.aspx");
                }
                else
                    Lable1.Text = "用户名或密码错误！";
            }
            catch(Exception ex)
            {
                Lable1.Text = ex.Message;
                conn.Close();
            }
        }
       
    }

   
}
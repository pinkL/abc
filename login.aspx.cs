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
     int userid ;
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

                SqlCommand cmd = new SqlCommand("select * from login where name='" + txtName.Text.Trim() + "' and password='" + txtPass.Text.Trim() + "'", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    sdr.Close();
                   
                   SqlCommand  cmd1 = new SqlCommand("select login_id from login where name='" + txtName.Text.Trim() + "' and password='" + txtPass.Text.Trim() + "'", conn);
                    userid = (int)cmd1.ExecuteScalar();
                    conn.Close();
                   // Lable1.Text = userid.ToString();
                    Session["userid"] = userid ;
                    Response.Redirect("~/personal_center.aspx");
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

public partial class personal_center : System.Web.UI.Page
{
    SqlConnection conn;
    int  userid;
    SqlCommand cmd1;
    SqlDataAdapter sda;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindYear();
            BindMonth();
        }
        userid=(int)Session["userid"];
        conn = new SqlConnection("server=LUSHAN-PC\\SQLEXPRESS;database=part-time-job;uid=sa;pwd=1995217ls");
       /* try
        {
            conn.Open();

            cmd1 = new SqlCommand("select * from information where login_id='" +userid + "'", conn);
            SqlDataReader sdr = cmd1.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)
            {
               
                btn_information.Visible = false;
                btnAlter.Visible = true;
               // Lable1.Text = sdr[1].ToString();
                    txtName.Text = sdr[2].ToString();
                    txtSex.Text = sdr[3].ToString();
                    txtAge.Text = sdr[4].ToString();
                    txtSchool.Text = sdr[5].ToString();
                    txtAcademy.Text = sdr[6].ToString();
                    txtMajor.Text = sdr[7].ToString();
                    txtSpecialty.Text = sdr[8].ToString();
                
                sdr.Close();
                conn.Close();
            }
            else
            {
                btn_information.Visible = true;
                btnAlter.Visible = false;
                conn.Close();
            }
               
        }
        catch (Exception ex)
        {
            Lable1.Text = ex.Message;
            //sdr.close();
            conn.Close();
        }*/
        
        
    }
   protected void BindYear()
    {
        ddlYear.Items.Clear();
        int startYear = DateTime.Now.Year - 40;
        int currentYear = DateTime.Now.Year;
       for(int i=startYear;i<=currentYear;i++)
       {
           ddlYear.Items.Add(new ListItem(i.ToString()));
       }
       ddlYear.SelectedValue = currentYear.ToString();

    }
   
    protected void BindMonth()
   {
       ddlMonth.Items.Clear();
        for(int i=1;i<=12;i++)
        {
            ddlMonth.Items.Add(i.ToString());
        }
   }
    protected void btninformation_Click(object sender, EventArgs e)
    {
        pan_information.Visible = true;
        pan_resume.Visible = false;
        pan_publish.Visible = false;
       
        pan_findjob.Visible = false;
        pan_employ.Visible = false;
        pan_collection.Visible = false;
    }
    protected void btnresume_Click(object sender, EventArgs e)
    {
        pan_information.Visible = false;
        pan_resume.Visible = true;
        pan_publish.Visible = false;
        
        pan_findjob.Visible = false;
        pan_employ.Visible = false;
        pan_collection.Visible = false;
    }
   
   
    protected void btnpublish_Click(object sender, EventArgs e)
    {
        pan_information.Visible = false;
        pan_resume.Visible = false;
        pan_publish.Visible = true;
       
        pan_findjob.Visible = false;
        pan_employ.Visible = false;
        pan_collection.Visible = false;
    }
    protected void btncollection_Click(object sender, EventArgs e)
    {
        pan_information.Visible = false;
        pan_resume.Visible = false;
        pan_publish.Visible = false;
        
        pan_findjob.Visible = false;
        pan_employ.Visible = false;
        pan_collection.Visible = true;
    }
    protected void btnfindjob_Click(object sender, EventArgs e)
    {
        pan_information.Visible = false;
        pan_resume.Visible = false;
        pan_publish.Visible = false;
       
        pan_findjob.Visible = true;
        pan_employ.Visible = false;
        pan_collection.Visible = false;
    }
    protected void btnemploy_Click(object sender, EventArgs e)
    {
        pan_information.Visible = false;
        pan_resume.Visible = false;
        pan_publish.Visible = false;
       
        pan_findjob.Visible = false;
        pan_employ.Visible = true;
        pan_collection.Visible = false;
    }


    protected void btn_information_Click(object sender, EventArgs e)
    {
        try
        {
            conn.Open();
           SqlCommand cmd2 = new SqlCommand("insert into information values( '" +userid +"','"+ txtName.Text.Trim() + "','" + txtSex.Text.Trim() + "','" + txtAge.Text.Trim() + "','" + txtSchool.Text.Trim() + "','" + txtAcademy.Text.Trim() + "','" + txtMajor.Text.Trim() + "','" + txtSpecialty.Text.Trim() + "')", conn);
            cmd2.ExecuteNonQuery();
            conn.Close();
        }
        catch(Exception ex)
        {
            Response.Write("<script>alert(ex.Message)</script>");
           Label1.Text="您未进行任何改动，请重试！";
           conn.Close();
        }
        
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/login.aspx");
    }
    protected void btnPublishresume_Click(object sender, EventArgs e)
    {

    }
    protected void btnAlter_Click(object sender, EventArgs e)
    {
        
        try
        {
            conn.Open();
            Lable1.Text = txtName.Text.Trim();
           SqlCommand cmd3 = new SqlCommand("update information set name='"+ txtName.Text.Trim() + "',sex='" + txtSex.Text.Trim() + "',age='" + txtAge.Text.Trim() + "',school='" + txtSchool.Text.Trim() + "',xueyuan='" + txtAcademy.Text.Trim() + "',profession='" + txtMajor.Text.Trim() + "',feature='" + txtSpecialty.Text.Trim() + "'  where login_id='"+userid+"'", conn);
           cmd3.ExecuteNonQuery();
          // Lable1.Text = cmd3.ExecuteNonQuery().ToString();
            conn.Close();
            Response.Write("<script>alert('修改成功!')</script>");
        }
        catch (Exception ex)
        {
            Lable1.Text = ex.Message;
            Response.Write("<script>alert('修改失败!')</script>");
            conn.Close();
        }
    }
}
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ceshi.aspx.cs" Inherits="ceshi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       



         DataSet ds;
        try
        {

            conn.Open();
           SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand("select * from information where login_id='" + userid + "'", conn);
            ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            sda.FillSchema(dt, SchemaType.Mapped);
            DataRow dr = dt.Rows.Find(userid);
            dr["name"] = txtName.Text.Trim();
            dr["sex"] = txtSex.Text.Trim();
            dr["age"] = txtAge.Text.Trim();
            dr["school"]=txtSchool.Text.Trim();
            dr["xueyuan"]=txtAcademy.Text.Trim();
            dr["profession"]=txtMajor.Text.Trim();
            dr["feature"] = txtSpecialty.Text.Trim();
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(sda);
            sda.Update(dt);
            conn.Close();
           
        }
        catch (Exception ex)
        {
            Lable1.Text = ex.Message;
           
            conn.Close();
        }
    aaaaaaa<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
       
         <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        用户名：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        姓名：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        联系方式：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
         <br />
         <br />
         <asp:Button ID="Button1" runat="server" Text="收藏" OnClick="Button1_Click" />
         <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="申请职位" />
         <br />
         <br />
         <br />
        <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
    </div>
        <div style="width:100%;height:100%">
            <iframe src="login.aspx"  style="height: 100%; "></iframe>
        </div>
        <div>

            
[csharp] view plain copy

 <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" RepeatColumns="5" SelectedIndex="0" Height="67px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" Width="317px">  
     <SelectedItemStyle BackColor="Fuchsia" />  
   <ItemTemplate>  
    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Select"  >        
</asp:LinkButton> 

   </ItemTemplate>  
</asp:DataList>  


        </div>
    </form>
</body>
</html>

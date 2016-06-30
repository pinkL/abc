<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 45px;
            font-size: large;
        }
        .auto-style2 {
            height: 22px;
        }
        .auto-style3 {
            height: 233px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style ="width :100%; ">
        
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style4">*</span>标题：<asp:TextBox ID="txttile" runat="server" Font-Size="Medium" Width="377px"></asp:TextBox>
                             <br />
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style5">*</span>职位类型：<asp:TextBox ID="txtjobstyle" runat="server" Font-Size="Medium" Width="377px"></asp:TextBox>
                             <br />
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style5">*</span>姓名：<asp:TextBox ID="txtrealname" runat="server" Font-Size="Medium" Width="377px"></asp:TextBox>
                             <br />
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 性别：<asp:DropDownList ID="ddSex" runat="server" Font-Size="Medium">
                                 <asp:ListItem Value="man">男</asp:ListItem>
                                 <asp:ListItem Value="women">女</asp:ListItem>
                             </asp:DropDownList>
                             &nbsp;&nbsp; 出生年月：<asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="true" Font-Size="Medium">
                             </asp:DropDownList>
                             &nbsp;年 
                             <asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="true" Font-Size="Medium">
                             </asp:DropDownList>
                             &nbsp;月<br /> 
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="auto-style5">*</span>工作年限：<asp:DropDownList ID="ddlWorkyear" runat="server" Font-Size="Medium">
                                 <asp:ListItem>一年</asp:ListItem>
                                 <asp:ListItem>两年</asp:ListItem>
                                 <asp:ListItem>三年</asp:ListItem>
                                 <asp:ListItem>三年以上</asp:ListItem>
                                 <asp:ListItem>无工作经验</asp:ListItem>
                             </asp:DropDownList>
                             <br />
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style5">*</span>学历：<asp:DropDownList ID="ddlEducation" runat="server" Font-Size="Medium">
                                 <asp:ListItem>本科</asp:ListItem>
                                 <asp:ListItem>专科</asp:ListItem>
                                 <asp:ListItem>硕士</asp:ListItem>
                                 <asp:ListItem>博士</asp:ListItem>
                             </asp:DropDownList>
                             <br />
                             <br />
                             <span class="auto-style5">*</span>期望工作区域：<asp:TextBox ID="txtWorkplace" runat="server" Font-Size="Medium" Width="378px"></asp:TextBox>
                             <br />
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="auto-style5"> *</span>期望月薪：<asp:DropDownList ID="ddlEmoney" runat="server" Font-Size="Medium">
                                 <asp:ListItem>1000到3000</asp:ListItem>
                                 <asp:ListItem>3000到5000</asp:ListItem>
                                 <asp:ListItem>5000以上</asp:ListItem>
                             </asp:DropDownList>
                             <br />
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style5">*</span>手机：<asp:TextBox ID="txtPhone" runat="server" Font-Size="Medium" Width="202px"></asp:TextBox>
                             <br />
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 邮箱：<asp:TextBox ID="txtMail" runat="server" Font-Size="Medium" Width="204px"></asp:TextBox>
                             <br />
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 籍贯：<asp:TextBox ID="txtHome" runat="server" Font-Size="Medium" Width="378px"></asp:TextBox>
                             <br />
&nbsp;
                             <div style="width:auto">
                                 <div style="width:auto">
                                     <label style="float:left;">
                                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 自我描述：</label>
                                 </div>
                                 &nbsp;<asp:TextBox ID="txtDescribe" runat="server" Font-Size="Medium" Height="115px" TextMode="MultiLine" Width="386px"></asp:TextBox>
                             </div>
                             &nbsp;&nbsp;
                            <br />
                            <br />
                            <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnPublishresume" runat="server" Font-Size="Medium"  Text="立即发布" />
                        
    </div>
    </form>
</body>
</html>

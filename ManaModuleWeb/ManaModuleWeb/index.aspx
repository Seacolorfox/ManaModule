<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ManaModuleWeb.index" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="toolsBar">
            <a href="option/add.aspx">添加</a>
            <a href="#">刷新</a>
        </div>
        <div class="main">
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped">
                        <thead>
                            <tr>
                                <td>ID</td>
                                <td>用户编号</td>
                                <td>姓名</td>
                                <td>性别</td>
                                <td>籍贯</td>
                                <td>手机</td>
                                <td>出生年月</td>
                                <td>年龄</td>
                                <td>兴趣爱好</td>
                                <td>教育经历</td>
                                <td>操作</td>
                            </tr>
                        </thead>
                        <%
                            string id = Request.QueryString["id"];
                            if (id != null)
                            {
                                ManaModuleWeb_BLL.UserInfo_BLL.del(int.Parse(id));
                                ManaModuleWeb_Utility.JsHelper.AlertAndRedirect("删除成功！", "index.aspx");
                            }

                        %>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Id") %></td>
                        <td><%# Eval("Userid") %></td>
                        <td><%# Eval("Name") %></td>
                        <td><%# Eval("sex").ToString()=="1"?"男":"女"%></td>
                        <td><%# Eval("Address") %></td>
                        <td><%# Eval("Phone") %></td>
                        <td><%# Eval("Birthday") %></td>
                        <td><%# DateTime.Now.Year-Convert.ToDateTime(Eval("Birthday")).Year %></td>
                        <td><%# Eval("Hobby") %></td>
                        <td><a href="option/detail.aspx?userid=<%# Eval("userid")%>">查看</a></td>
                        <td>
                            <a href="option/edit_info.aspx?id=<%# Eval("id") %>">编辑</a>
                            <a href="index.aspx?id=<%# Eval("id") %>">删除</a>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            <table style="margin-left: 50%">
                <tr>
                    <td class="style1">
                        <asp:HyperLink ID="first" runat="server">首页</asp:HyperLink>
                        <asp:HyperLink ID="up" runat="server">上一页</asp:HyperLink>
                        <asp:HyperLink ID="next" runat="server">下一页</asp:HyperLink>
                        <asp:HyperLink ID="last" runat="server">末页</asp:HyperLink>
                    </td>
                </tr>

                <tr>
                    <td class="style1">
                        <asp:Label ID="lblCurrentPage" runat="server" Text="Label"></asp:Label>&nbsp;
                共<asp:Label ID="labPage" runat="server" Text="Label"></asp:Label>
                        页</td>

                </tr>
            </table>
        </div>
    </form>
</body>
</html>

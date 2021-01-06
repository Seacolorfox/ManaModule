<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detail.aspx.cs" Inherits="ManaModuleWeb.option.detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>教育经历</td>
                    <td>时间段</td>
                    <td>所获证书</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="timeQ" runat="server" TextMode="MultiLine" Height="67px"></asp:TextBox></td>
                    <td>
                        <asp:TextBox ID="school" runat="server" TextMode="MultiLine" Height="67px"></asp:TextBox></td>
                    <td>
                        <asp:TextBox ID="certificate" runat="server" TextMode="MultiLine" Height="67px"></asp:TextBox></td>
                </tr>
            </table>
        </div>
        <asp:Button ID="update" runat="server" Text="更新" OnClick="update_Click" />
        <asp:Button ID="returnToIndex" runat="server" Text="返回" OnClick="returnToIndex_Click" />
    </form>
</body>
</html>

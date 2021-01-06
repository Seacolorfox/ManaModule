<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit_info.aspx.cs" Inherits="ManaModuleWeb.option.edit_info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="/css/laydate.css" />
    <script src="/js/jquery.min.js"></script>
    <script src="/js/laydate.js"></script>
    <style type="text/css">
        .select-date {
            font-family: "sta cartman"
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <p>姓&nbsp; 名：<asp:TextBox ID="name" runat="server"></asp:TextBox></p>
            <p>
                性&nbsp; 别：<asp:DropDownList ID="sex" runat="server">
                    <asp:ListItem Value="1">男</asp:ListItem>
                    <asp:ListItem Value="0">女</asp:ListItem>
                </asp:DropDownList>
            </p>
            <div id="dist">
                <p>
                    地&nbsp; 址：
                    <select name="province_select" id="province_select" runat="server" data-role="province" data-value="四川" data-placeholder="全国"></select>
                    <select name="city_select" id="city_select" runat="server" data-role="city" data-value="南充" data-placeholder="全省"></select>
                    <select name="county_select" id="county_select" runat="server" data-role="county" data-value="蓬安县" data-placeholder="全市"></select>
                </p>
            </div>
            <p>
                手&nbsp; 机：<asp:TextBox ID="phone" name="fname" min="11" runat="server"></asp:TextBox>
                <span class="checkExistRong" id="checkExistPhone"></span>
            </p>
            <p>出生日期：</p>
            <div class="laydate-box">
                <input type="text" name="birthday" id="laydateInput" placeholder="xxxx年xx月xx日" />
                <img src="/images/calendar.png" alt="" class="icon data-icon" />
                <div class="select-date">
                    <div class="select-date-header">
                        <ul class="heade-ul">
                            <li class="header-item header-item-one">
                                <select name="" id="yearList"></select>
                            </li>
                            <li class="header-item header-item-two" onselectstart="return false">
                                <select name="" id="monthList"></select>
                            </li>
                            <li class="header-item header-item-three" onselectstart="return false">
                                <span class="reback">回到今天</span>
                            </li>
                        </ul>
                    </div>
                    <div class="select-date-body">
                        <ul class="week-list">
                            <li>日</li>
                            <li>一</li>
                            <li>二</li>
                            <li>三</li>
                            <li>四</li>
                            <li>五</li>
                            <li>六</li>
                        </ul>
                        <ul class="day-tabel"></ul>
                    </div>
                </div>
            </div>

            <p>爱&nbsp; 好：<asp:TextBox ID="hobby" runat="server"></asp:TextBox></p>
            <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" style="height: 27px" />
            <asp:Button ID="Button2" runat="server" Text="清空" />

            <asp:HiddenField ID="id" runat="server" />

        </div>

    </form>
    <script src="https://cdn.bootcss.com/jquery/3.3.1/jquery.min.js"></script>
    <script src="distPicker.js"></script>
    <script>
        function getSelectDate(result) {
            //这里获取选择的日期
            console.log(result);
        }
        // 验证手机号
        function isPhoneNo(phone) {
            var pattern = /^1[34578]\d{9}$/;
            return pattern.test(phone);
        }
        function userTel(inputid, spanid) {
            $(inputid).blur(function () {
                if ($.trim($(inputid).val()).length == 0) {
                    $(spanid).html("× 手机号没有输入");
                } else {
                    if (isPhoneNo($.trim($(inputid).val())) == false) {
                        $(spanid).html("× 手机号码不正确");
                    }
                }
                $(inputid).focus(function () {
                    $(spanid).html("");
                });
            });
        };
        userTel('#phone', "#checkExistPhone");
        $("#dist").distPicker();
    </script>
</body>
</html>
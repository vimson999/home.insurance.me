<%@ Page Title="" Language="C#" MasterPageFile="~/FormUI/Shared/Main.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="home.insurance.cn.FormUI._01Account.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="f-wrap01">
        <form id="form1" runat="server">
            <div class="f-form-title f-form-title-01">
                <div class="f-form-register-tips">已有账号？<a href="http://local.testxdf.cn/insurance.me/FormUI/Home">立即登录</a></div>
                注册云之保
            </div>
            <div class="f-form">
                <label class="f-form-label"><i>*</i>手机号码：</label>
                <span class="f-form-content">
                    <asp:TextBox ID="txtPhone" runat="server" Width="250px" data-flag="phone"></asp:TextBox>
                    <span class="f-form-tips-gray">11位手机号</span>
                    <span class="f-form-tips">请输入正确手机号</span>
                </span>
            </div>
            <div class="f-form">
                <label class="f-form-label"><i>*</i>验证码：</label>
                <span class="f-form-content">
                    <asp:TextBox ID="txtSMSCode" runat="server" Width="120px"></asp:TextBox>
                    <span class="f-form-tips-gray">获取短信验证码</span>
                </span>
            </div>
            <div class="f-form">
                <label class="f-form-label"><i>*</i>密码：</label>
                <span class="f-form-content">
                    <asp:TextBox ID="txtPassword" runat="server" Width="250px"></asp:TextBox>
                </span>
            </div>
            <div class="f-form">
                <label class="f-form-label"><i>*</i>姓名：</label>
                <span class="f-form-content">
                    <asp:TextBox ID="txtName" runat="server" Width="250px"></asp:TextBox>
                </span>
            </div>
            <%--        <div class="f-form">
            <label class="f-form-label"><i>*</i>所在地区：</label>
            <span class="f-form-content">
                <select><option>请选择</option></select>
                <select><option>请选择</option></select>
                <select><option>请选择</option></select>
            </span>
        </div>--%>
            <div class="f-form">
                <label class="f-form-label">&nbsp;</label>
                <span class="f-form-content">
                    <asp:CheckBox ID="ckAgree" runat="server" />
                    <a href="#">同意云之保网协议</a>
                </span>
            </div>
            <div class="f-form">
                <label class="f-form-label">&nbsp;</label>
                <span class="f-form-content">
                    <asp:Button ID="btnRegister" runat="server" Text="立即注册" CssClass="f-form-submit" OnClick="btnRegister_Click" />
                </span>
            </div>
        </form>
    </div>



    <script type="text/javascript">
  


    </script>

</asp:Content>

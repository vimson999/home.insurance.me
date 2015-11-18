<%@ Page Title="" Language="C#" MasterPageFile="~/FormUI/Shared/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="home.insurance.cn.FormUI.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="poster" runat="server">
        <div class="f-indexLogin-wrap">
            <div class="f-indexLogin">
                <div class="f-indexLogin-login">

                    <h2>会员登陆</h2>
                    <div class="f-indexLogin-main">
                        <div class="f-indexLogin-tips">请输入正确手机号</div>
                        <label class="user">
                            <%--<input type="text" placeholder="请输入用户名">--%>
                            <asp:TextBox ID="txtMobile" runat="server" placeholder="请输入用户名"></asp:TextBox>

                        </label>
                        <label class="password">
                            <asp:TextBox ID="txtPassword" runat="server" placeholder="请输入用密码"></asp:TextBox>
                            <%--<input type="password" placeholder="请输入用密码">--%></label>
                    </div>
                    <div class="f-indexLogin-other">
                        <a href="http://local.testxdf.cn/insurance.me/FormUI/01Account/Register" class="register">立即注册</a>
                        <label>
                            <input type="checkbox">记住密码！</label>
                        &nbsp;
                    <a href="http://local.testxdf.cn/insurance.me/FormUI/01Account/FindPassword">忘记密码</a>
                    </div>
                    <asp:Button ID="btnLogin" runat="server" Text="立即登录" CssClass="f-indexLogin-submit" OnClick="btnLogin_Click" />
                    <%--<input type="submit" value="" class="f-indexLogin-submit">--%>
                </div>
            </div>
        </div>
    </form>
    <div class="wrap980">
        <div class="mt20">
            <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/banner01.jpg">
        </div>
        <div class="f-text04">我们提供更方便的投保流程</div>
        <div>
            <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/banner02.jpg">
        </div>
    </div>
    <div class="j-cooperation-wrap">
        <h4>合作公司</h4>
        <div class="j-cooperation">
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_01.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_02.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_03.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_04.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_05.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_06.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_07.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_08.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_09.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_10.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_11.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_12.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_13.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_14.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_15.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_16.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_17.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_18.jpg"></a>
            <a href="#">
                <img src="http://local.testxdf.cn/insurance.me/Scripts/public/images/cooperation/pic_19.jpg"></a>
        </div>
    </div>

</asp:Content>

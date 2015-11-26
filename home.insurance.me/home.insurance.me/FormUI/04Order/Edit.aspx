<%@ Page Title="" Language="C#" MasterPageFile="~/FormUI/Shared/Main.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="home.insurance.cn.FormUI._04Order.EditOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="f-wrap01">
        <div class="j-step-wrap">
            <div class="j-step">
                <div class="j-step-dot j-step-dot-01 j-step-current">填写投保信息</div>
                <div class="j-step-dot j-step-dot-02">确认投保信息</div>
                <div class="j-step-dot j-step-dot-03">支付并完成投保</div>
            </div>
        </div>
        <form id="form1" runat="server">
            <div class="f-form-title">投保计划</div>
            <div class="f-form">
                <label class="f-form-label">保险时间：</label>
                <span class="f-form-content">
                    <%--<input type="text" style="width: 200px;" value="" />--%>
                    至
                    <%--<input type="text" style="width: 200px;" value="" />--%>
                </span>
            </div>
            <div class="f-form-title">投保人信息</div>
            <div class="f-form">
                <label class="f-form-label">姓名：</label>
                <span class="f-form-content">
                    <%--<input type="text" style="width: 250px;" value="" />--%>
                    <asp:TextBox ID="txtName" runat="server" Width="250px" data-flag='name'></asp:TextBox>
                    <span class="f-form-tips" style="display:none" id="name-tip">请输入姓名</span>
                </span>
            </div>
            <div class="f-form">
                <label class="f-form-label">身份证：</label>
                <span class="f-form-content">
                    <%--<input type="text" style="width: 250px;" value="" />--%>
                    <asp:TextBox ID="txtIDCardNo" runat="server" Width="250px" data-flag='idcardNo'></asp:TextBox>
                    <span class="f-form-tips" style="display:none" id="idCard-tip">请输入身份证</span>
                </span>
            </div>
            <div class="f-form">
                <label class="f-form-label">手机号码：</label>
                <span class="f-form-content">
                    <%--<input type="text" style="width: 250px;" value="" />--%>
                    <asp:TextBox ID="txtMobile" runat="server" Width="250px" MaxLength="11" data-flag='mobile'></asp:TextBox>
                    <span class="f-form-tips" style="display:none" id="mobile-tip">请输入正确手机号</span>
                </span>-
            </div>
            <div class="f-form">
                <label class="f-form-label">邮箱：</label>
                <span class="f-form-content">
                    <%--<input type="text" style="width: 250px;" value="" />--%>
                    <asp:TextBox ID="txtEmail" runat="server" Width="250px" data-flag='email'></asp:TextBox>
                    <span class="f-form-tips" style="display:none" id="email-tip">请输入邮箱</span>
                </span>
            </div>
            <div class="f-form">
                <label class="f-form-label">&nbsp;</label>
                <span class="f-form-content">
                    <%--<input type="submit" value="下一步" class="f-form-submit">--%>
                    <asp:Button ID="btnSave" runat="server" Text="下一步" CssClass="f-form-submit" OnClick="btnSave_Click" />
                </span>
            </div>
        </form>
    </div>

    <script type="text/javascript">
        //check page
        function checkPage() {
            var name = $("input[data-flag='name']").val().trim();
            var mobile = $("input[data-flag='phone']").val().trim();
            var password = $("input[data-flag='password']").val().trim();

            if (mobile.length != 11 || name.length == 0 || password.length < 6) {
                $("#mobile-tips").text("请检查手机号码！");
                $("#mobile-tips").fadeIn();

                $("#passowrd-tips").text("密码长度应大于6位，请检查密码！");
                $("#passowrd-tips").fadeIn();

                $("#name-tips").text("请检查姓名！");
                $("#name-tips").fadeIn();

                return false;
            }

            $("input[data-flag='phone']").removeAttr("disabled");
            $("input[data-flag='sms']").removeAttr("disabled");

            return true;
        }

    </script>
</asp:Content>

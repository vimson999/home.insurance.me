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
        <form action="#">
            <div class="f-form-title">投保计划</div>
            <div class="f-form">
                <label class="f-form-label">保险时间：</label>
                <span class="f-form-content">
                    <input type="text" style="width: 200px;" value="" />
                    至
                <input type="text" style="width: 200px;" value="" />
                </span>
            </div>
            <div class="f-form-title">投保人信息</div>
            <div class="f-form">
                <label class="f-form-label">姓名：</label>
                <span class="f-form-content">
                    <input type="text" style="width: 250px;" value="" />
                </span>
            </div>
            <div class="f-form">
                <label class="f-form-label">身份证：</label>
                <span class="f-form-content">
                    <input type="text" style="width: 250px;" value="" />
                </span>
            </div>
            <div class="f-form">
                <label class="f-form-label">手机号码：</label>
                <span class="f-form-content">
                    <input type="text" style="width: 250px;" value="" />
                    <span class="f-form-tips">请输入正确手机号</span>
                </span>
            </div>
            <div class="f-form">
                <label class="f-form-label">邮箱：</label>
                <span class="f-form-content">
                    <input type="text" style="width: 250px;" value="" />
                </span>
            </div>
            <div class="f-form">
                <label class="f-form-label">&nbsp;</label>
                <span class="f-form-content">
                    <input type="submit" value="下一步" class="f-form-submit">
                </span>
            </div>
        </form>
    </div>


</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/FormUI/Shared/Main.Master" AutoEventWireup="true" CodeBehind="Pay.aspx.cs" Inherits="home.insurance.cn.FormUI._04Order.Pay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="f-wrap01">
    <div class="j-step-wrap">
        <div class="j-step">
            <div class="j-step-dot j-step-dot-01">填写投保信息</div>
            <div class="j-step-dot j-step-dot-02">确认投保信息</div>
            <div class="j-step-dot j-step-dot-03 j-step-current">支付并完成投保</div> 
        </div>
    </div>
    <div class="B-ui-table-ext01" style="padding: 0;">
        <table class="B-ui-table B-ui-table-thead-center B-ui-table-tbody-center B-ui-table-ext01-thead-fef8f2">
            <thead>
                <tr>
                    <th><div class="B-ui-table-ext">被保信息</div></th>
                    <th><div class="B-ui-table-ext">险种</div></th>
                    <th><div class="B-ui-table-ext">生效日期</div></th>
                    <th><div class="B-ui-table-ext">金额(元)</div></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td><div class="B-ui-table-ext">肖起源</div></td>
                    <td><div class="B-ui-table-ext">肖起源</div></td>
                    <td><div class="B-ui-table-ext">2015-11-09</div></td>
                    <td><div class="B-ui-table-ext">19.90</div></td>
                </tr>
            </tbody>
        </table>
    </div>
    <div class="f-bank-title">
        选择支付方式
        <span>请您在24小时内完成支付，否则可能需要重新报价</span>
    </div>
    <div class="f-bank clearfix">
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_01.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_02.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_03.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_04.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_05.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_06.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_07.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_08.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_09.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_10.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_11.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_12.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_13.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_14.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_15.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_16.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_17.png"></label>
        <label><input type="radio" name="bank"><img src="./public/images/bank/bank_18.png"></label>
    </div>
    <input type="submit" value="确认支付" class="f-bank-submit">
</div>


</asp:Content>

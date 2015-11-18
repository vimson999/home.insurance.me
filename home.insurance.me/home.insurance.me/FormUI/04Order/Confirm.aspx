﻿<%@ Page Title="" Language="C#" MasterPageFile="~/FormUI/Shared/Main.Master" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="home.insurance.cn.FormUI._04Order.Confirm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="f-wrap01">
        <div class="j-step-wrap">
            <div class="j-step">
                <div class="j-step-dot j-step-dot-01">填写投保信息</div>
                <div class="j-step-dot j-step-dot-02 j-step-current">确认投保信息</div>
                <div class="j-step-dot j-step-dot-03">支付并完成投保</div>
            </div>
        </div>
        <div class="f-title01">保险责任与明细</div>
        <div class="B-ui-table-ext01" style="padding: 0;">
            <table class="B-ui-table B-ui-table-thead-center B-ui-table-tbody-center B-ui-table-ext01-thead-fef8f2">
                <thead>
                    <tr>
                        <th>
                            <div class="B-ui-table-ext">保险范围</div>
                        </th>
                        <th>
                            <div class="B-ui-table-ext">保险金额（元/人）</div>
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <div class="B-ui-table-ext">地铁、火车、轻轨</div>
                        </td>
                        <td>
                            <div class="B-ui-table-ext">500,000.00元</div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="B-ui-table-ext">公交车、出租车、长途汽车</div>
                        </td>
                        <td>
                            <div class="B-ui-table-ext">300,000.00元</div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="B-ui-table-ext">自驾车</div>
                        </td>
                        <td>
                            <div class="B-ui-table-ext">300,000.00元</div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="B-ui-table-ext">轮船、渡船、邮轮</div>
                        </td>
                        <td>
                            <div class="B-ui-table-ext">500,000.00元</div>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class="f-title01">投保人信息</div>
        <dl class="f-text01 clearfix">
            <dt>姓名：</dt>
            <dd>肖起源</dd>
            <dt>出生日期：</dt>
            <dd>1989 年 04 月 04 日</dd>
        </dl>
        <dl class="f-text01 clearfix">
            <dt>证件号码：</dt>
            <dd>350000000000000000</dd>
            <dt>手机号码：</dt>
            <dd>18610842051</dd>
        </dl>
        <dl class="f-text01 clearfix">
            <dt>电子邮箱：</dt>
            <dd>384267842@qq.com</dd>
        </dl>
        <div class="f-title01">保单明细</div>
        <dl class="f-text01 clearfix">
            <dt>保险期间：</dt>
            <dd>2015 年 11 月 09 日</dd>
            <dt>受益人：</dt>
            <dd>法定</dd>
        </dl>
        <dl class="f-text01 clearfix">
            <dt>保险天数：</dt>
            <dd>1年</dd>
            <dt>支付方式：</dt>
            <dd>网上支付</dd>
        </dl>
        <dl class="f-text01 clearfix">
            <dt>投保份数：</dt>
            <dd>1份/人</dd>
            <dt>发票及保单配送：</dt>
            <dd>电子保单</dd>
        </dl>
        <div class="f-text02">保费：19.90元</div>
        <div class="f-text03">
            投保人声明：<br>
            &nbsp;&nbsp;&nbsp;&nbsp;保险人已将投保险种对应的保险条款（包括责任免除部分）向本人作了明确说明，本人已充分理解，上述所填写的内容均属事实，同意签订本保险合同。
            <br>
            &nbsp;&nbsp;&nbsp;&nbsp;投保人签字（盖章)：肖起源    2015年11月08日
        </div>
        <div style="padding: 10px 0;">
            <input type="checkbox">我同意以上告知和声明
        </div>
        <input type="submit" value="下一步" class="f-submit01">
    </div>


</asp:Content>

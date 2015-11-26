$(function(){
    $(".js-tab li").click(function(){
        $(this).addClass('current').siblings().removeClass("current");
        var index = $(this).index();
        var _index = $(this).attr("data-flag") - 1;
		var num = index + _index * 5;
        $(".f-tabContent").hide();
	   	$(".f-tabContent").eq(num).show();
    });
});





    <!--2.引入js-->
    <script type="text/javascript" src="http://res.wx.qq.com/open/js/jweixin-1.0.0.js"></script>
    <script type="text/javascript">
        var appId =  "<%=AppId %>";
        var timestamp = <%=TimeStamp %>;
        var nonceStr = "<%=NonceStr %>";
        var signature = "<%=Signature %>";

        //alert("appId:"+appId);
        //alert("timestamp:"+timestamp);
        //alert("nonceStr:"+nonceStr);
        //alert("signature:"+signature);
        
        wx.config({
            debug: true, // 开启调试模式,调用的所有api的返回值会在客户端alert出来，若要查看传入的参数，可以在pc端打开，参数信息会通过log打出，仅在pc端时才会打印。
            appId: appId, // 必填，公众号的唯一标识
            timestamp: timestamp, // 必填，生成签名的时间戳
            nonceStr: nonceStr, // 必填，生成签名的随机串
            signature: signature,// 必填，签名，见附录1
            jsApiList: ['onMenuShareTimeline()', 'onMenuShareAppMessage()'] // 必填，需要使用的JS接口列表，所有JS接口列表见附录2
        });

        wx.ready(function () {

            // config信息验证后会执行ready方法，所有接口调用都必须在config接口获得结果之后，config是一个客户端的异步操作，所以如果需要在页面加载时就调用相关接口，则须把相关接口放在ready函数中调用来确保正确执行。对于用户触发时才调用的接口，则可以直接调用，不需要放在ready函数中。

        });

        //判断当前客户端版本是否支持指定JS接口
        wx.checkJsApi({
            jsApiList: ['chooseImage'], // 需要检测的JS接口列表，所有JS接口列表见附录2,
            success: function (res) {
                // 以键值对的形式返回，可用的api值true，不可用为false
                // 如：{"checkResult":{"chooseImage":true},"errMsg":"checkJsApi:ok"}
            }
        });

        //分享朋友圈
        wx.onMenuShareTimeline({
            title: '', // 分享标题
            link: '', // 分享链接
            imgUrl: '', // 分享图标
            success: function () {
                // 用户确认分享后执行的回调函数

                var organizerOpenId = getQueryString("organizerOpenId");
                var redirectUrl = "../Market/RaisingList.aspx?organizerOpenId=" + organizerOpenId;
                alert("分享朋友圈成功！"+redirectUrl);
                location.href = redirectUrl;
            },
            cancel: function () {
                // 用户取消分享后执行的回调函数
                var organizerOpenId = getQueryString("organizerOpenId");
                var redirectUrl = "../Market/RaisingList.aspx?organizerOpenId=" + organizerOpenId;
            }
        });

        //分享朋友
        wx.onMenuShareAppMessage({
            title: '', // 分享标题
            desc: '', // 分享描述
            link: '', // 分享链接
            imgUrl: '', // 分享图标
            type: '', // 分享类型,music、video或link，不填默认为link
            dataUrl: '', // 如果type是music或video，则要提供数据链接，默认为空
            success: function () {
                // 用户确认分享后执行的回调函数
                var organizerOpenId = getQueryString("organizerOpenId");
                var redirectUrl = "../Market/RaisingList.aspx?organizerOpenId=" + organizerOpenId;
                alert("分享朋友圈成功！"+redirectUrl);
                location.href = redirectUrl;
            },
            cancel: function () {
                // 用户取消分享后执行的回调函数
                var organizerOpenId = getQueryString("organizerOpenId");
                var redirectUrl = "../Market/RaisingList.aspx?organizerOpenId=" + organizerOpenId;
            }
        });

    </script>
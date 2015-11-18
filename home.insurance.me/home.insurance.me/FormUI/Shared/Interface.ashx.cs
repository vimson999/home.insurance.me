using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using X3;
using home.insurance.cn.Data;


namespace home.insurance.cn.FormUI.Shared
{
    /// <summary>
    /// Interface 的摘要说明
    /// </summary>
    public class Interface : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            var action = "GetUserByMobile";
            var service = new Repository();

            switch (action)
            {
                case "GetUserByMobile":
                    var mobile = string.Empty;

                    service.GetUserInfoByMobile(mobile,UtilX3.GetRealIP());

                    break;
                case "1":
                    break;
                default:
                    break;
            }

            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
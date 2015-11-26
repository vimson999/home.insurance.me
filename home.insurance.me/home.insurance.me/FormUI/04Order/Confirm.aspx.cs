using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using I.Utility.Helper;
using I.Utility.Extensions;
using home.insurance.cn.Data;

namespace home.insurance.cn.FormUI._04Order
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var productId = this.Request.QueryString["productId"];
                var _orderId = this.Request.QueryString["orderId"];

                var orderId = 0;
                if (!string.IsNullOrEmpty(_orderId))
                    orderId = _orderId.ParseTo<int>();

                var order = new Repository().GetOrderByID(orderId);
                if (order != null)
                {










                }
            }
        }
    }
}
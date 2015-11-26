using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using home.insurance.cn.Data;

namespace home.insurance.cn.FormUI._04Order
{
    public partial class EditOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text.Trim();
            var email = this.txtEmail.Text.Trim();
            var mobile = this.txtMobile.Text.Trim();
            var cardNo = this.txtIDCardNo.Text.Trim();

            var order = new Order_BaseInfo
            {

            };
            var item = new Order_ItemInfo
            {

            };
            var policyHolder = new Order_PolicyHolder
            {
                 
            };

            var itemList = new List<Order_ItemInfo>();
            itemList.Add(item);
            order.Order_ItemInfo = itemList;

            //item. todo 

            try
            {
                new Repository().AddOrder(order);

                Response.Redirect("confirm.aspx?id=" + order.ID);
            }
            catch
            {

            }
        }
    }
}
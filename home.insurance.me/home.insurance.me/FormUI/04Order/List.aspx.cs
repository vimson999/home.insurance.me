﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;

using I.Utility.Helper;
using I.Utility.Extensions;
using X3;

using home.insurance.cn.Data;

namespace home.insurance.cn.FormUI._04Order
{
    public partial class List : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.CurrentUser == null)
                Response.Redirect(ConfigurationManager.AppSettings["SiteUrl"] + "FormUI/Home");

            if (!this.Page.IsPostBack)
            {
                this.BindList();

                //this.Literal1.Text = this.CurrentUser.Name;
            }
        }

        void BindList()
        {
            var status = this.Request.QueryString["status"];


        }
    }
}
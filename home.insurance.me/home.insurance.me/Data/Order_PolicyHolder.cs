//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace home.insurance.cn.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_PolicyHolder
    {
        public int ID { get; set; }
        public string InsuredName { get; set; }
        public string IdentifyType { get; set; }
        public string IdentifyNumber { get; set; }
        public string Sex { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string CountryCode { get; set; }
        public Nullable<System.DateTime> IdentifyTypeEnddate { get; set; }
        public string InsuredAddr { get; set; }
        public string InsuredTel { get; set; }
    }
}

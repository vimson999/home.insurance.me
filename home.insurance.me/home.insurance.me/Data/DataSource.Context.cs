﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntityMember : DbContext
    {
        public EntityMember()
            : base("name=EntityMember")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SYS_LogInfo> SYS_LogInfo { get; set; }
        public virtual DbSet<BaseInfo_UserInfo> BaseInfo_UserInfo { get; set; }
        public virtual DbSet<Order_BaseInfo> Order_BaseInfo { get; set; }
        public virtual DbSet<Order_Beneficiary> Order_Beneficiary { get; set; }
        public virtual DbSet<Order_InsuredPerson> Order_InsuredPerson { get; set; }
        public virtual DbSet<Order_ItemInfo> Order_ItemInfo { get; set; }
        public virtual DbSet<Order_PolicyHolder> Order_PolicyHolder { get; set; }
    }
}

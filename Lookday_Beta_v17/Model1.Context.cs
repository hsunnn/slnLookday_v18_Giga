﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lookday_Beta_v17
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dblookdaysEntities : DbContext
    {
        public dblookdaysEntities()
            : base("name=dblookdaysEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActionJoint> ActionJoint { get; set; }
        public virtual DbSet<ActionType> ActionType { get; set; }
        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<ActivitiesAlbum> ActivitiesAlbum { get; set; }
        public virtual DbSet<Bookings> Bookings { get; set; }
        public virtual DbSet<BookingStates> BookingStates { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ClassJoint> ClassJoint { get; set; }
        public virtual DbSet<ClassName> ClassName { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CreditCardInfo> CreditCardInfo { get; set; }
        public virtual DbSet<Hotels> Hotels { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}

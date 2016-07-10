﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AMSEntities : DbContext
    {
        public AMSEntities()
            : base("name=AMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<AroundProvider> AroundProviders { get; set; }
        public virtual DbSet<AroundProviderCategory> AroundProviderCategories { get; set; }
        public virtual DbSet<AroundProviderProduct> AroundProviderProducts { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<BalanceSheet> BalanceSheets { get; set; }
        public virtual DbSet<Block> Blocks { get; set; }
        public virtual DbSet<BlockPoll> BlockPolls { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<HelpdeskRequestHelpdeskSupporter> HelpdeskRequestHelpdeskSupporters { get; set; }
        public virtual DbSet<HelpdeskRequestLog> HelpdeskRequestLogs { get; set; }
        public virtual DbSet<HelpdeskServiceCategory> HelpdeskServiceCategories { get; set; }
        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<HouseCategory> HouseCategories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<NotificationChange> NotificationChanges { get; set; }
        public virtual DbSet<NotificationObject> NotificationObjects { get; set; }
        public virtual DbSet<Poll> Polls { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAnswerPoll> UserAnswerPolls { get; set; }
        public virtual DbSet<UserRateAroundProvider> UserRateAroundProviders { get; set; }
        public virtual DbSet<UtilityService> UtilityServices { get; set; }
        public virtual DbSet<UtilityServiceRangePrice> UtilityServiceRangePrices { get; set; }
        public virtual DbSet<UtilServiceCategory> UtilServiceCategories { get; set; }
        public virtual DbSet<UtilServiceForHouseCat> UtilServiceForHouseCats { get; set; }
        public virtual DbSet<HelpdeskRequest> HelpdeskRequests { get; set; }
    }
}

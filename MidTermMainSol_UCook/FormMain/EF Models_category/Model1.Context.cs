﻿//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormMain.EFModels
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class iSpanDataBaseICookEntities : DbContext
    {
        public iSpanDataBaseICookEntities()
            : base("name=iSpanDataBaseICookEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CATEGORY_食譜分類_LEVEL_ONE> CATEGORY_食譜分類_LEVEL_ONE { get; set; }
        public DbSet<CATEGORY_食譜分類_LEVEL_THREE> CATEGORY_食譜分類_LEVEL_THREE { get; set; }
        public DbSet<CATEGORY_食譜分類_LEVEL_TWO> CATEGORY_食譜分類_LEVEL_TWO { get; set; }
        public DbSet<RECIPE_食譜> RECIPE_食譜 { get; set; }
        public DbSet<CATEGORY_食譜分類_LEVEL_ONE_TMP> CATEGORY_食譜分類_LEVEL_ONE_TMP { get; set; }
        public DbSet<CATEGORY_食譜分類_LEVEL_THREE_TMP> CATEGORY_食譜分類_LEVEL_THREE_TMP { get; set; }
        public DbSet<CATEGORY_食譜分類_LEVEL_TWO_TMP> CATEGORY_食譜分類_LEVEL_TWO_TMP { get; set; }
        public DbSet<RECIPE_食譜_TMP> RECIPE_食譜_TMP { get; set; }
        public DbSet<RECIPE_食譜_TMPTest> RECIPE_食譜_TMPTest { get; set; }
    }
}

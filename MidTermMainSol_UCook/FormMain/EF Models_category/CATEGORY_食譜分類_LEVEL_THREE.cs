//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CATEGORY_食譜分類_LEVEL_THREE
    {
        public CATEGORY_食譜分類_LEVEL_THREE()
        {
            this.RECIPE_食譜 = new HashSet<RECIPE_食譜>();
        }
    
        public int FEATURED_CATEGORY精選分類LEVEL_THREE_PK { get; set; }
        public string FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱 { get; set; }
        public int LEVEL_TWO_FK { get; set; }
        public string UPDATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_TIME { get; set; }
    
        public virtual CATEGORY_食譜分類_LEVEL_TWO CATEGORY_食譜分類_LEVEL_TWO { get; set; }
        public virtual ICollection<RECIPE_食譜> RECIPE_食譜 { get; set; }
    }
}

//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Reviews
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int ActivityID { get; set; }
        public string Comment { get; set; }
        public string Rating { get; set; }
    
        public virtual Activities Activities { get; set; }
        public virtual User User { get; set; }
    }
}

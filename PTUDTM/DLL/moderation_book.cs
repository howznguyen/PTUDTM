//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class moderation_book
    {
        public long id { get; set; }
        public long idbook { get; set; }
        public string moderator { get; set; }
        public Nullable<long> moderation { get; set; }
        public string content { get; set; }
        public bool review { get; set; }
        public Nullable<System.DateTime> createdat { get; set; }
        public Nullable<System.DateTime> updatedat { get; set; }
    
        public virtual book book { get; set; }
        public virtual user user { get; set; }
    }
}
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
    
    public partial class episode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public episode()
        {
            this.moderation_episode = new HashSet<moderation_episode>();
            this.points = new HashSet<point>();
        }
    
        public long idepisode { get; set; }
        public long idbook { get; set; }
        public long index { get; set; }
        public string name { get; set; }
        public string content { get; set; }
        public int view { get; set; }
        public int status { get; set; }
        public System.DateTime createdat { get; set; }
        public System.DateTime updatedat { get; set; }
    
        public virtual book book { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<moderation_episode> moderation_episode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<point> points { get; set; }
    }
}
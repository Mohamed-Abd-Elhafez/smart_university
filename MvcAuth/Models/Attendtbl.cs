//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcAuth.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attendtbl
    {
        public int ID { get; set; }
        public int St_ID { get; set; }
        public string Date { get; set; }
        public Nullable<int> Course_ID { get; set; }
    
        public virtual CourseTbl CourseTbl { get; set; }
        public virtual StudentTbl StudentTbl { get; set; }
    }
}

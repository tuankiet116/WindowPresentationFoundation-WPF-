//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OutPutDetailTable
    {
        public int ID { get; set; }
        public int ID_Output { get; set; }
        public int ID_Product { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public int TotalPrice { get; set; }
        public string Status { get; set; }
    
        public virtual OutputTable OutputTable { get; set; }
        public virtual ProductTable ProductTable { get; set; }
    }
}

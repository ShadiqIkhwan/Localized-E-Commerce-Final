//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Localized_E_commerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Size
    {
        public int Id { get; set; }
        public string size1 { get; set; }
        public int productId { get; set; }
    
        public virtual Product Product { get; set; }
    }
}

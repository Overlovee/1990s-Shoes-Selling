//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1990s_Shoes_Selling_Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class Favorite_Detaill
    {
        public int FavoriteID { get; set; }
        public string ShoesID { get; set; }
        public int ColourID { get; set; }
        public string StyleType { get; set; }
    
        public virtual Favorite Favorite { get; set; }
        public virtual Sho Sho { get; set; }
    }
}

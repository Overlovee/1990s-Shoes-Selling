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
    
    public partial class Related_staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Related_staff()
        {
            this.OrderSystems = new HashSet<OrderSystem>();
            this.Sales = new HashSet<Sale>();
        }
    
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public string UserID { get; set; }
        public string ShopBranchs { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string EmploymentStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderSystem> OrderSystems { get; set; }
        public virtual Shop_Branchs Shop_Branchs { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TEST01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CargoType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CargoType()
        {
            this.Jobs = new HashSet<Job>();
        }
    
        public string CargoID { get; set; }
        public string CargoDescription { get; set; }
        public string CargoWeight { get; set; }
        public string CargoHeight { get; set; }
        public string CargoLength { get; set; }
        public string CargoWidth { get; set; }
        public string AbnormalLoad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
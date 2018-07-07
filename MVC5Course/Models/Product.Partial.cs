namespace MVC5Course.Models
{
    using MVC5Course.Models.newAttribute;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
    }
    
    public partial class ProductMetaData
    {
        [Required]
        public int ProductId { get; set; }
        
        [StringLength(80, ErrorMessage="欄位長度不得大於 80 個字元")]
        [Required]
        [IdentityCard]
        public string ProductName { get; set; }
        [Required]
        [Range(10,99999)]
        public Nullable<decimal> Price { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public Nullable<bool> Active { get; set; }
        [Required]
        public Nullable<decimal> Stock { get; set; }
    
        public virtual ICollection<OrderLine> OrderLine { get; set; }
    }
}

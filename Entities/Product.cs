namespace Shoes.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(50)]
        public string ProductArticle { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductTitle { get; set; }

        public decimal ProductPrice { get; set; }

        public int ManufacturerID { get; set; }

        public int ProviderID { get; set; }

        public int CategoryID { get; set; }

        public int MaxSale { get; set; }

        public int? CurrentSale { get; set; }

        public int ProductAmount { get; set; }

        [Required]
        [StringLength(50)]
        public string Measurement { get; set; }

        public string ProductDescription { get; set; }

        [StringLength(50)]
        public string ProductPhoto { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual Provider Provider { get; set; }
    }
}

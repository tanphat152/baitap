namespace test_template.Models.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int ProducerID { get; set; }

        public int CategoryID { get; set; }

        public int Price { get; set; }

        [Required]
        public string IMG { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Description { get; set; }

        public int TopHot { get; set; }

        public int NewProduct { get; set; }

        public string Active { get; set; }
    }
}

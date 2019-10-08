namespace test_template.Models.EF
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

        public Product()
        {
            this.Name = "Vợt cầu lông Yonex Duora 10";
            this.IMG = "~/Access/images/products/small/forza-mega-speed-99-nano.jpg";
            this.Price = 350000;
        }
        
    }
}

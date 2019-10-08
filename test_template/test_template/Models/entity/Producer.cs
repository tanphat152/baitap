namespace test_template.Models.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producer")]
    public partial class Producer
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Images { get; set; }
    }
}

namespace test_template.Models.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News_Type
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int Active { get; set; }
    }
}

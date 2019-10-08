namespace test_template.Models.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        public int IsPublic { get; set; }

        [Required]
        public string Content { get; set; }

        public string Author { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        public int NewsTypeID { get; set; }
    }
}

namespace Book_Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        // Get id:10 charaters
        [StringLength(10)]
        public string id { get; set; }

        // Get ISBN
        [Column(TypeName = "text")]
        public string ISBN { get; set; }

        // Get title
        [Column(TypeName = "text")]
        [Required]
        public string title { get; set; }

        // Get category_id
        [Required]
        [StringLength(10)]
        public string category_id { get; set; }

        // Get publisher_id
        [Required]
        [StringLength(10)]
        public string publisher_id { get; set; }

        // Get publisher_date
        [Column(TypeName = "date")]
        public DateTime publish_date { get; set; }

        // Get author_id
        [Required]
        [StringLength(10)]
        public string author_id { get; set; }

        // Get price
        [Column(TypeName = "money")]
        public decimal prise { get; set; }

        // Get url
        [Column(TypeName = "text")]
        [Required]
        public string url { get; set; }

        public virtual Author Author { get; set; }

        public virtual Category Category { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}

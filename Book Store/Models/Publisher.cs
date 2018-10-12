namespace Book_Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Publisher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        // Get id: 10 characters
        [StringLength(10)]
        public string id { get; set; }

        // Get publisher_name
        [Column(TypeName = "text")]
        [Required]
        public string publish_name { get; set; }

        // Get company_name
        [Column(TypeName = "text")]
        public string company_name { get; set; }

        // Get address
        [Column(TypeName = "text")]
        public string address { get; set; }

        // Get postal_code
        [Column(TypeName = "text")]
        public string postal_code { get; set; }

        // Get country
        [Column(TypeName = "text")]
        public string country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Books { get; set; }
    }
}

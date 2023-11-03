using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    [Table("Books")]
    public class Book {
        [Key]
        [Column("BOOK_ID")]
        public string BookId { set; get; }

        [Required]
        [StringLength(50)]
        [Column("BOOKNAME")]
        public string BookName { set; get; }

        [StringLength(50)]
        [Column("AUTHOR")]
        public string Author { set; get; }

        
        [Column("PUBLISHCATION_YEAR")]
        public int PublicationYear { set; get; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace DTO {
    [Table("Borrow")]
    public class Borrow {

        [Key]
        public int ID { get; set; }

        [ForeignKey("BORROWER_ID")]
        public Borrower BorrowerId { set; get; }

        [ForeignKey("BOOK_ID")]
        public Book BookId { set; get; }

        [StringLength(50)]
        [Column("BORROWED_DATE")]
        public string BorrowedDate { get; set; }

        [StringLength(50)]
        [Column("RETURN_DATE")]
        [AllowNull]
        public string? ReturnDate { get; set; }
    }
}

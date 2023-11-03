using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DTO {
    [Table("Borrow")]
    public class Borrow {

        [Key]
        public int BorrowId { set; get; }

        [ForeignKey("BorrowerId")]
        public Borrower Borrower { set; get; }

        [ForeignKey("BookId")]
        public Book Book { set; get; }

        [StringLength(50)]
        public string DateBorrow { get; set; }
    }
}
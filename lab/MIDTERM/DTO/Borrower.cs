using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DTO {

    [Table("Borrower")]
    public class Borrower {

        [Key]
        [Column("BORROWER_ID")]
        public int BorowerId { set; get; }

        [Required]
        [StringLength(50)]
        [Column("FIRST_NAME")]
        public string FirstName { set; get; }

        [Required]
        [StringLength(50)]
        [Column("LASTNAME")]
        public string LastName { set; get; }


        [Required]
        [StringLength(50)]
        [Column("ADDRESS")]
        public string Address { set; get; }


        [Required]
        [StringLength(50)]
        [Column("PHONE")]
        public string Phone { set; get; }
    }
}
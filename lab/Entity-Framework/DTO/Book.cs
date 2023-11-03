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
        public int BookId { set; get; }

        [Required]
        [StringLength(50)]
        public string Name { set; get; }

        [StringLength(50)]
        public string Publication { set; get; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {

    [Table("Borrower")]
    public class Borrower {

        [Key]
        public int BorowerId { set; get; }

        [Required]
        [StringLength(50)]
        public string Name { set; get; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Testwork.Data
{
    [Table("tblItemName")]
    public class ItemName
    {       
            [Key]
            public int Id { get; set; }
            [Required, StringLength(255)]
            public string Name { get; set; }
            public virtual ICollection<ItemTipe> ItemTipes { get; set; }
        }
}

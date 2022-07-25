﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFoot.Data.Models
{
    public class Admin
    {

        [Key]
        public int ID { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        [StringLength(1)]
        public string Rol { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Models
{
    public class NationalPark
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String State { get; set; }
        public DateTime Craeted { get; set; }
        public DateTime Established { get; set; }


    }
}

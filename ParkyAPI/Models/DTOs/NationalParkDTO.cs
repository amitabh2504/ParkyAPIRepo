﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Models.DTOs
{
    public class NationalParkDTO
    {
        
        public int Id { get; set; }
        
        public String Name { get; set; }
        
        public String State { get; set; }
        public DateTime Craeted { get; set; }
        public DateTime Established { get; set; }


    }
}

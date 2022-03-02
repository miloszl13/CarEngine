﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Engine
    {
        [Key]
        public int Engine_Id { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public int SerialNumber { get; set; }
        [Required]
        public string Type { get; set; }
    }
}

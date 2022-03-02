using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Car
    {
        [Key]
        public int Car_Id { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string ChassisNumber { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }

        public Engine Engine { get; set; }
    }
}

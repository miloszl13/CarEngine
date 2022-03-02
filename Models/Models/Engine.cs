using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Car")]
        public int Car_Id { get; set; }
        public Car Car { get; set; }

        [ForeignKey("EngineType")]
        public int EngineType_Id { get; set; }
        public EngineType EngineType { get; set; }
    }
}

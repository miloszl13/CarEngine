using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class EngineType
    {
        [Key]
        public int EngineType_Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Engine> Engines { get; set; }

    }
}

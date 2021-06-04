using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Uppgift_2_MVC_med_CF.Models
{
    public class CalculatorModel
    {
        [Required]
        public decimal ValueA { get; set; }
        [Required]
        public decimal ValueB { get; set; }
    }
}

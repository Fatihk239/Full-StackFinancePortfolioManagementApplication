using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage ="Symbol cannot be over 10 characters")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(10, ErrorMessage ="Company name cannot be over 10 characters")]
        public  string CompanyName { get; set; } = String.Empty;

        [Required]
        [Range(1,100000000)]
       
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001,100)]
      
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage ="Industry cannot be over 10 characters")]
        public string Industry { get; set; } = string.Empty;

        [Range(1,50000000000)]
        public long MarketCap { get; set; } 

        
    
    
    } 
}
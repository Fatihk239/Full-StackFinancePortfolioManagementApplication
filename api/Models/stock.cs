using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class stock
    {
        public int Id { get; set; }
        public string symbol { get; set; } = string.Empty;
        public  string CompanyName { get; set; } = String.Empty;
        [Column(TypeName="decimal(18/2)")]
        public decimal Purchase { get; set; }
        [Column(TypeName="decimal(18/2)")]
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty
        public long MarketCap { get; set; } 
        public  List<Comment> Comments { get; set; }
        public class Comment 
        [  
            public int Id { get; set; }
            public string Title { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public DateTime CreatedOn { get; set; } = DateTime.Now;
            public int? StockId { get; set; }
            public Stock? Stock { get; set; }


        ]

     
        

    }
}   
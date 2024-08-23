using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stock
    {
        public int Id { get; set; }
    MvcDataAnnotationsMvcCoreBuilderExtensions  
        public  List<Comment> Comments { get; set; } = new List<Comment>(); 
        
        
     
        

    }
}   